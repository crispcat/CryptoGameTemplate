using System;
using System.Threading.Tasks;
using GameTools;
using UnityEngine;

namespace Game
{
    public class GameSession
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
            //Debug.Log($"try login with auth id = {playerAuthId}");
            // var res = await PlayFabClientAPI.LoginWithCustomIDAsync(new LoginWithCustomIDRequest { CustomId = playerAuthId, CreateAccount = true });
            // if (res.failed())
            //     throw new RiftersException($"AuthToMakePlayfabRequestsPossible failed.\n{res.Error}");
            //Debug.Log($"Login success");
        }

        public static async Task<GameSession> AuthenticateAsClient(AuthData authData)
        {
            throw new NotImplementedException();
            // PlayFabResult<LoginResult> playfabResponse = await SocialUtils.ExistingSocialLogin(authData);
            //
            // if (playfabResponse == null || playfabResponse.failed())
            // {
            //     playfabResponse = await PlayFabClientAPI.LoginWithCustomIDAsync(new LoginWithCustomIDRequest
            //         { CustomId = authData.authId, CreateAccount = true });
            // }
            //
            // if (playfabResponse.failed())
            //     throw new RiftersException(playfabResponse.Error.ToString());
            // if (LocalGameSettings.instance.logRemoteGameMetaCommands)
            // {
            //     Debug.Log(PlayFabClientAPI.lastCallTiming);
            //     Debug.Log(
            //         $"authed on playfab with playerid = {playfabResponse.Result.PlayFabId}, ticket = {playfabResponse.Result.SessionTicket}, authId = {authData.authId}");
            // }
            // return new GameSession
            //     { playerId = playfabResponse.Result.PlayFabId, ticket = playfabResponse.Result.SessionTicket };
        }

        // public static async Task<MatchmakeRequest> GetMatchmakeRequest(GameServerMode mode)
        //     => new MatchmakeRequest
        //     {
        //         BuildVersion = Versioning.VersionManager.GetServerBuildIdToConnectTo(mode),
        //         GameMode = mode.ToString(),
        //         Region = await LocalGameSettings.instance.regionSettings.GetRegion()
        //     };
    }
}