using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if ENABLE_PLAYFABSERVER_API && !DISABLE_PLAYFAB_STATIC_API
using PlayFab.MatchmakerModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static class PlayFabMatchmakerAPIAsync
    {
        #if ENABLE_PLAYFABSERVER_API && !DISABLE_PLAYFAB_STATIC_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<AuthUserResponse>> AuthUser(AuthUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AuthUserResponse> waiter;
            waiter = new PlayFabResult<AuthUserResponse>();
            PlayFabMatchmakerAPI.AuthUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PlayerJoinedResponse>> PlayerJoined(PlayerJoinedRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PlayerJoinedResponse> waiter;
            waiter = new PlayFabResult<PlayerJoinedResponse>();
            PlayFabMatchmakerAPI.PlayerJoined(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PlayerLeftResponse>> PlayerLeft(PlayerLeftRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PlayerLeftResponse> waiter;
            waiter = new PlayFabResult<PlayerLeftResponse>();
            PlayFabMatchmakerAPI.PlayerLeft(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<StartGameResponse>> StartGame(StartGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<StartGameResponse> waiter;
            waiter = new PlayFabResult<StartGameResponse>();
            PlayFabMatchmakerAPI.StartGame(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UserInfoResponse>> UserInfo(UserInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UserInfoResponse> waiter;
            waiter = new PlayFabResult<UserInfoResponse>();
            PlayFabMatchmakerAPI.UserInfo(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
