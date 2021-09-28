using System;
using System.Threading.Tasks;
using GameTools;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

namespace Game
{
    public class PlayfabSessionInfo
    {
        public string ticket;
        public string playerId;
    }
    
    public static class PlayfabAuth
    {
        public static async Task EnsureCanMakeRequests()
        {
//             if (!PlayFabClientAPI.IsClientLoggedIn())
//             {
// #if PLAYFABLESS
//                 await PlayFablessClientAPI.EnsureCanMakeRequestsOnTruePlayfab();
// #else
//                 await AuthToMakePlayfabRequestsPossible();
// #endif
//             }
        }
        private static async Task AuthToMakePlayfabRequestsPossible()
        {
            string playerAuthId = LocalSettings.Instance.authData.authId;
            Debug.Log($"try login with auth id = {playerAuthId}");
             var res = await PlayFabClientAPIAsync.LoginWithCustomID(new LoginWithCustomIDRequest { CustomId = playerAuthId, CreateAccount = true });
             if (res.fail)
                 throw new GameException($"AuthToMakePlayfabRequestsPossible failed.\n{res.Error}");
            Debug.Log($"Login success");
        }

        public static async Task<PlayfabSessionInfo> AuthenticateAsClient(AuthData authData)
        {
            PlayFabResult<LoginResult> playfabResponse = await SocialUtils.ExistingSocialLogin(authData);
            
            if (playfabResponse == null || playfabResponse.failed())
            {
                playfabResponse = await PlayFabClientAPIAsync.LoginWithCustomID(new LoginWithCustomIDRequest
                    { CustomId = authData.authId, CreateAccount = true });
            }
            
            if (playfabResponse.failed())
                throw new GameException(playfabResponse.Error.ToString());
            if (LocalSettings.Instance.logRemoteGameMetaCommands)
            {
                Debug.Log(PlayFabClientAPIAsync.lastCallTiming);
                Debug.Log(
                    $"authed on playfab with playerid = {playfabResponse.Result.PlayFabId}, ticket = {playfabResponse.Result.SessionTicket}, authId = {authData.authId}");
            }
            return new PlayfabSessionInfo
                { playerId = playfabResponse.Result.PlayFabId, ticket = playfabResponse.Result.SessionTicket };
        }

        // public static async Task<MatchmakeRequest> GetMatchmakeRequest(GameServerMode mode)
        //     => new MatchmakeRequest
        //     {
        //         BuildVersion = Versioning.VersionManager.GetServerBuildIdToConnectTo(mode),
        //         GameMode = mode.ToString(),
        //         Region = await LocalSettings.Instance.regionSettings.GetRegion()
        //     };
    }
}