using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game;
using GameTools;
using PlayFab;
using PlayFab.ClientModels;
using UnityEditor;
using UnityEngine;
using ZergRush.ReactiveCore;
using LoginResult = PlayFab.ClientModels.LoginResult;

public class SocialUtils : MonoBehaviour
{
    static bool waitingResult
    {
        get => waitingResultCell.value;
        set => waitingResultCell.value = value;
    }
    public static Cell<bool> waitingResultCell = new Cell<bool>(false);
    public static AuthData currentAuth => LocalSettings.Instance.authData;
    public static AuthType CurrentAuthType => LocalSettings.Instance.authData.type;
    
    
    
    public static async Task<PlayFabResult<LoginResult>> ExistingSocialLogin(AuthData auth)
    {
        switch (auth.type)
        {
            // case AuthType.GameCenter:
            //     return await LoginGameCenter();
            //     break;
            // case AuthType.FaceBook:
            //     return await LoginFacebook();
            default:
                return null;
        }
    }
    
    #if false

    static bool initialized = false;
    public static async Task Init()
    {
#if !UNITY_STANDALONE || UNITY_EDITOR
        if(initialized)
            return;
        try
        {
            AppsFlyer.setAppsFlyerKey("r7wiq6XtzToNjBSSfziAN9");
            AppsFlyer.setAppID("id1458601852");
        
            AppsFlyer.getConversionData();
            AppsFlyer.trackAppLaunch();
        }
        catch (Exception e)
        {
            Debug.Log("AppsFlyer failed: " + e);
        }
        
        waitingResult = true;
        try
        {
            FB.Init(() =>
            {
                if (FB.IsInitialized)
                {
                    try
                    {
                        FB.ActivateApp();
                    } catch (Exception e)
                    {
                        Debug.LogError("Facebook SDK ActivateApp exception");
                        waitingResult = false;
                    }
                }
                else
                {
                    Debug.LogError("Failed to Initialize the Facebook SDK");
                }

                waitingResult = false;
            });
        } catch (Exception e)
        {
            Debug.LogError("Facebook SDK init exception");
            waitingResult = false;
        }
        
        while (waitingResult)
            await Task.Delay(20);

        initialized = true;
#endif
    }

    static async Task<PlayFabResult<LoginResult>> LoginGameCenter()
    {
        waitingResult = true;
        bool loginResult = false;

        Social.localUser.Authenticate(result =>
        {
            waitingResult = false;
            loginResult = result;

            Debug.Log("Social.localUser.Authenticate " + loginResult);

        });
        
        while (waitingResult) await Task.Delay(50);

        if (loginResult)
        {
            waitingResult = true;

            Debug.Log("Trying to login GC with id: " + Social.localUser.id);
            
            var playfabResponse = await PlayFabClientAPI.LoginWithGameCenterAsync(new LoginWithGameCenterRequest
            {
                CreateAccount = false,
                PlayerId = Social.localUser.id,
                TitleId = "5626"
            });
            
            waitingResult = false;

            if (playfabResponse.failed())
                Debug.Log(playfabResponse.Error.ToString());
            else
                Debug.Log("GC session: " + playfabResponse.Result.SessionTicket + ", " + playfabResponse.Result.NewlyCreated);

            return playfabResponse;
        }

        return null;
    }

    public static async Task LinkGameCenter(Func<AuthType, ShortPlayerInfo, Task<PlayerModelSelection>> showSelection)
    {
        waitingResult = true;
        bool loginResult = false;

        Social.localUser.Authenticate(result =>
        {
            loginResult = result;
            waitingResult = false;
        });

        int timeout = 5000;
        while (waitingResult && timeout > 0)
        {
            await Task.Delay(100);
            timeout -= 100;
        }

        if (loginResult == false || string.IsNullOrEmpty(Social.localUser.id))
        {
            ConfirmationWindow.ShowSimpleAlert(Settings.failedToConnect(LocalizationUtils.GetLoc("settings_gamecenter")), "common_confirm");
            return;
        }

        AuthData newAuthData = currentAuth.value.MakeCopy();

        newAuthData.type = AuthType.GameCenter;
        newAuthData.gamecenterId = Social.localUser.id;

        waitingResult = true;
        
        var needsLinking = await CheckExistingPlayer(newAuthData, showSelection);

        if (needsLinking)
        {
            //proceed to linking
            waitingResult = true;

            var linkResult = await PlayFabClientAPI.LinkGameCenterAccountAsync(new LinkGameCenterAccountRequest
            {
                GameCenterId = Social.localUser.id,
                ForceLink = true
            });

            if (linkResult.success)
            {
                LocalSettings.Instance.authData.value = newAuthData;
                Debug.Log("Link successful!");
            }
            else
            {
                Debug.Log("Link failed " + linkResult.Error.ErrorMessage);
                ConfirmationWindow.ShowSimpleAlert(Settings.failedToConnect(LocalizationUtils.GetLoc("settings_gamecenter")), "common_confirm");
            }

            waitingResult = false;
        }
    }

    static async Task<PlayFabResult<LoginResult>> LoginFacebook()
    {
        AccessToken aToken = null;

        if (!FB.IsLoggedIn || PlayerSettings.Facebook.Unity.AccessToken.CurrentAccessToken == null)
        {
            waitingResult = true;
            
            FB.LogInWithReadPermissions(new List<string>() {"public_profile", "email"}, result =>
            {
                if (FB.IsLoggedIn)
                {
                    // AccessToken class will have session details
                    aToken = PlayerSettings.Facebook.Unity.AccessToken.CurrentAccessToken;
                    Debug.Log("Facebook Access Token: " + aToken.UserId);
                }
                else
                {
                    Debug.Log(result.Error);
                }

                waitingResult = false;
            });
        }
        else
        {
            aToken = PlayerSettings.Facebook.Unity.AccessToken.CurrentAccessToken;
        }

        int timeout = 5000;
        while (waitingResult && timeout > 0)
        {
            await Task.Delay(100);
            timeout -= 100;
        }

        if (aToken != null)
        {
            waitingResult = true;
            
            var playfabResponse = await PlayFabClientAPI.LoginWithFacebookAsync(new LoginWithFacebookRequest
            {
                AccessToken = aToken.TokenString,
                CreateAccount = false
            });
            
            waitingResult = false;

            if (playfabResponse.failed())
                Debug.Log("LoginFacebook failed " + playfabResponse.Error.ToString());

            return playfabResponse;
        }

        return null;
    }

    public static async Task LinkFacebook(Func<AuthType, ShortPlayerInfo, Task<PlayerModelSelection>> showSelection)
    {
        if (!FB.IsInitialized)
        {
            Debug.Log("FB is not Init!");
            return;
        }

        waitingResult = true;
        
        AccessToken aToken = null;
        var perms = new List<string>(){"public_profile", "email"};

        ILoginResult loginResult = null;
        FB.LogInWithReadPermissions(perms, result => {
            if (FB.IsLoggedIn) {
                // AccessToken class will have session details
                aToken = PlayerSettings.Facebook.Unity.AccessToken.CurrentAccessToken;
                loginResult = result;
                Debug.Log("Facebook Access Token: " + aToken.UserId);

            } else {
                Debug.Log("Login failed, " + result.Error);
            }

            waitingResult = false;
        });

        while (waitingResult) {
            await Task.Delay(50);
        }
        
        if(aToken == null || loginResult == null || loginResult.Cancelled)
        {
            if(loginResult != null && !loginResult.Cancelled)
                ConfirmationWindow.ShowSimpleAlert(Settings.failedToConnect(LocalizationUtils.GetLoc("settings_facebook")), LocalizationUtils.GetLoc("common_confirm"));
            return;
        }

        AuthData newAuthData = currentAuth.value.MakeCopy();

        newAuthData.type = AuthType.FaceBook;
        newAuthData.facebookId = aToken.UserId;

        waitingResult = true;
        
        var needsLinking = await CheckExistingPlayer(newAuthData, showSelection);

        if (needsLinking)
        {
            //proceed to linking
            waitingResult = true;

            var linkResult = await PlayFabClientAPI.LinkFacebookAccountAsync(new LinkFacebookAccountRequest
            {
                AccessToken = aToken.TokenString,
                ForceLink = true
            });

            if (linkResult.success)
            {
                LocalSettings.Instance.authData.value = newAuthData;
                Debug.Log("Link successful!");
            } else
                Debug.Log("Link failed " + linkResult.Error.ErrorMessage);

            waitingResult = false;
        }
    }

    public static async Task<bool> CheckExistingPlayer(AuthData authData, Func<AuthType, ShortPlayerInfo, Task<PlayerModelSelection>> showSelection)
    {
        var playfabId = await FindPlayfabIDByAuth(authData);
        
        Debug.Log("Checking if player exists: " + authData.type + ", " + authData.GetCurrentID() + ", playfabId: " + playfabId);
        
        var existingPlayer = await GameClientRoot.Instance.prodGameController.serverAPI
            .GetShortPlayerInfo(playfabId);
        
        waitingResult = false;

        if (existingPlayer.level != -1)
        {
            Debug.Log("Existing player!");
            
            var selected = await showSelection(authData.type, existingPlayer);

            if (selected == PlayerModelSelection.Cancel)
            {
                Debug.Log("Link cancelled");
                return false;
            }

            //Accept remote player and re-connect
            if (selected == PlayerModelSelection.SelectLinked)
            {
                Debug.Log("Take existing");
                
                LocalSettings.Instance.authData.value = authData;
 
                await GameClientRoot.Instance.Relogin();
                
                return false;
            }
            
            Debug.Log("Override existing");
        }

        return true;
    }

    public static async Task UnlinkGameCenter()
    {
        waitingResult = true;
        var result = await PlayFabClientAPI.UnlinkGameCenterAccountAsync(new UnlinkGameCenterAccountRequest { });

        if (result.success)
        {
            currentAuth.value = currentAuth.value.MakeCopy(AuthType.DeviceID);
            await GameClientRoot.Instance.Relogin();
        }
        else
        {
            Debug.Log("UnlinkFB failed, " + result.Error.ErrorMessage + ", " + result.Error.Error);

            if (result.Error.Error == PlayFabErrorCode.AccountNotLinked)
                currentAuth.value = currentAuth.value.MakeCopy(AuthType.DeviceID);
        }
        waitingResult = false;
    }

    public static async Task UnlinkFB()
    {
        waitingResult = true;

        var result = await PlayFabClientAPI.UnlinkFacebookAccountAsync(new UnlinkFacebookAccountRequest());
        
        if(result.success)
        {
            currentAuth.value = currentAuth.value.MakeCopy(AuthType.DeviceID);
            await GameClientRoot.Instance.Relogin();
        }
        else
        {
            Debug.Log("UnlinkFB failed, " + result.Error.ErrorMessage + ", " + result.Error.Error);

            if (result.Error.Error == PlayFabErrorCode.AccountNotLinked)
                currentAuth.value = currentAuth.value.MakeCopy(AuthType.DeviceID);
        };
        
        waitingResult = false;
    }
    
    static async Task<string> FindPlayfabIDByAuth(AuthData authData)
    {      
        switch (authData.type)
        {
            case AuthType.FaceBook:
                var fbResult = await PlayFabClientAPI.GetPlayFabIDsFromFacebookIDsAsync(
                    new GetPlayFabIDsFromFacebookIDsRequest
                    {
                        FacebookIDs = new List<string> { authData.facebookId },
                    });
                
                if(fbResult == null || fbResult.failed())
                    throw new GameException("FindPlayerByAuthType " + fbResult?.Error.ErrorMessage);

                if (fbResult.Result.Data == null || fbResult.Result.Data.Count == 0)
                    return "";
                
                Debug.Log("FaceBook existing id: " +  fbResult.Result.Data[0].PlayFabId);
                
                return fbResult.Result.Data[0].PlayFabId;
                
            case AuthType.GameCenter:
                var gcResult = await PlayFabClientAPI.GetPlayFabIDsFromGameCenterIDsAsync(
                    new GetPlayFabIDsFromGameCenterIDsRequest
                    {
                        GameCenterIDs = new List<string> { authData.gamecenterId },
                    });
                    
                if(gcResult == null || gcResult.failed())
                    throw new GameException("FindPlayerByAuthType " + gcResult?.Error.ErrorMessage);

                if (gcResult.Result.Data == null || gcResult.Result.Data.Count == 0)
                    return "";
                
                Debug.Log("GameCenter Matches: " + gcResult.Result.Data.Count);

                var candidates = gcResult.Result.Data.Where(v => !string.IsNullOrEmpty(v.PlayFabId))
                    .Select(v => v.PlayFabId).ToList();

                if (candidates.Any())
                {
                    Debug.Log("GameCenter existing id: " + gcResult.Result.Data[0].PlayFabId);
                    return gcResult.Result.Data[0].PlayFabId;
                }
                else
                {
                    Debug.Log("No valid matches!");
                    return "";
                }

            default:
                throw new GameException();
        }
    }
    #endif
}
