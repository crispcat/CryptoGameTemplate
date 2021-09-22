using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if ENABLE_PLAYFABSERVER_API
using PlayFab.MatchmakerModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static partial class PlayFabMatchmakerAPI
    {
        #if ENABLE_PLAYFABSERVER_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<AuthUserResponse>> AuthUserAsync(AuthUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AuthUserResponse> waiter;
            waiter = new PlayFabResult<AuthUserResponse>();
            AuthUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PlayerJoinedResponse>> PlayerJoinedAsync(PlayerJoinedRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PlayerJoinedResponse> waiter;
            waiter = new PlayFabResult<PlayerJoinedResponse>();
            PlayerJoined(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PlayerLeftResponse>> PlayerLeftAsync(PlayerLeftRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PlayerLeftResponse> waiter;
            waiter = new PlayFabResult<PlayerLeftResponse>();
            PlayerLeft(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<StartGameResponse>> StartGameAsync(StartGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<StartGameResponse> waiter;
            waiter = new PlayFabResult<StartGameResponse>();
            StartGame(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UserInfoResponse>> UserInfoAsync(UserInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UserInfoResponse> waiter;
            waiter = new PlayFabResult<UserInfoResponse>();
            UserInfo(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
