using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if ENABLE_PLAYFABSERVER_API
using PlayFab.ServerModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static partial class PlayFabServerAPIAsync
    {
        #if ENABLE_PLAYFABSERVER_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> AddCharacterVirtualCurrency(AddCharacterVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyCharacterVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyCharacterVirtualCurrencyResult>();
            PlayFabServerAPI.AddCharacterVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> AddFriend(AddFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabServerAPI.AddFriend(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> AddGenericID(AddGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            PlayFabServerAPI.AddGenericID(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTag(AddPlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddPlayerTagResult> waiter;
            waiter = new PlayFabResult<AddPlayerTagResult>();
            PlayFabServerAPI.AddPlayerTag(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembers(AddSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<AddSharedGroupMembersResult>();
            PlayFabServerAPI.AddSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrency(AddUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            PlayFabServerAPI.AddUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AuthenticateSessionTicketResult>> AuthenticateSessionTicket(AuthenticateSessionTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AuthenticateSessionTicketResult> waiter;
            waiter = new PlayFabResult<AuthenticateSessionTicketResult>();
            PlayFabServerAPI.AuthenticateSessionTicket(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AwardSteamAchievementResult>> AwardSteamAchievement(AwardSteamAchievementRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AwardSteamAchievementResult> waiter;
            waiter = new PlayFabResult<AwardSteamAchievementResult>();
            PlayFabServerAPI.AwardSteamAchievement(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BanUsersResult>> BanUsers(BanUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BanUsersResult> waiter;
            waiter = new PlayFabResult<BanUsersResult>();
            PlayFabServerAPI.BanUsers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeItemResult>> ConsumeItem(ConsumeItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeItemResult> waiter;
            waiter = new PlayFabResult<ConsumeItemResult>();
            PlayFabServerAPI.ConsumeItem(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroup(CreateSharedGroupRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateSharedGroupResult> waiter;
            waiter = new PlayFabResult<CreateSharedGroupResult>();
            PlayFabServerAPI.CreateSharedGroup(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteCharacterFromUserResult>> DeleteCharacterFromUser(DeleteCharacterFromUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteCharacterFromUserResult> waiter;
            waiter = new PlayFabResult<DeleteCharacterFromUserResult>();
            PlayFabServerAPI.DeleteCharacterFromUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePlayerResult>> DeletePlayer(DeletePlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePlayerResult> waiter;
            waiter = new PlayFabResult<DeletePlayerResult>();
            PlayFabServerAPI.DeletePlayer(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePushNotificationTemplateResult>> DeletePushNotificationTemplate(DeletePushNotificationTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePushNotificationTemplateResult> waiter;
            waiter = new PlayFabResult<DeletePushNotificationTemplateResult>();
            PlayFabServerAPI.DeletePushNotificationTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteSharedGroup(DeleteSharedGroupRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabServerAPI.DeleteSharedGroup(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeregisterGameResponse>> DeregisterGame(DeregisterGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeregisterGameResponse> waiter;
            waiter = new PlayFabResult<DeregisterGameResponse>();
            PlayFabServerAPI.DeregisterGame(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EvaluateRandomResultTableResult>> EvaluateRandomResultTable(EvaluateRandomResultTableRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EvaluateRandomResultTableResult> waiter;
            waiter = new PlayFabResult<EvaluateRandomResultTableResult>();
            PlayFabServerAPI.EvaluateRandomResultTable(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScript(ExecuteCloudScriptServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ExecuteCloudScriptResult> waiter;
            waiter = new PlayFabResult<ExecuteCloudScriptResult>();
            PlayFabServerAPI.ExecuteCloudScript(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegments(GetAllSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAllSegmentsResult> waiter;
            waiter = new PlayFabResult<GetAllSegmentsResult>();
            PlayFabServerAPI.GetAllSegments(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListUsersCharactersResult>> GetAllUsersCharacters(ListUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListUsersCharactersResult> waiter;
            waiter = new PlayFabResult<ListUsersCharactersResult>();
            PlayFabServerAPI.GetAllUsersCharacters(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItems(GetCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCatalogItemsResult> waiter;
            waiter = new PlayFabResult<GetCatalogItemsResult>();
            PlayFabServerAPI.GetCatalogItems(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterData(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            PlayFabServerAPI.GetCharacterData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterInternalData(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            PlayFabServerAPI.GetCharacterInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterInventoryResult>> GetCharacterInventory(GetCharacterInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterInventoryResult> waiter;
            waiter = new PlayFabResult<GetCharacterInventoryResult>();
            PlayFabServerAPI.GetCharacterInventory(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboard(GetCharacterLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetCharacterLeaderboardResult>();
            PlayFabServerAPI.GetCharacterLeaderboard(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterReadOnlyData(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            PlayFabServerAPI.GetCharacterReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterStatisticsResult>> GetCharacterStatistics(GetCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<GetCharacterStatisticsResult>();
            PlayFabServerAPI.GetCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentDownloadUrlResult>> GetContentDownloadUrl(GetContentDownloadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentDownloadUrlResult> waiter;
            waiter = new PlayFabResult<GetContentDownloadUrlResult>();
            PlayFabServerAPI.GetContentDownloadUrl(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboard(GetFriendLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            PlayFabServerAPI.GetFriendLeaderboard(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetFriendsListResult>> GetFriendsList(GetFriendsListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetFriendsListResult> waiter;
            waiter = new PlayFabResult<GetFriendsListResult>();
            PlayFabServerAPI.GetFriendsList(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboard(GetLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            PlayFabServerAPI.GetLeaderboard(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacter(GetLeaderboardAroundCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundCharacterResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundCharacterResult>();
            PlayFabServerAPI.GetLeaderboardAroundCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundUserResult>> GetLeaderboardAroundUser(GetLeaderboardAroundUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundUserResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundUserResult>();
            PlayFabServerAPI.GetLeaderboardAroundUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharacters(GetLeaderboardForUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardForUsersCharactersResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardForUsersCharactersResult>();
            PlayFabServerAPI.GetLeaderboardForUserCharacters(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfo(GetPlayerCombinedInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerCombinedInfoResult> waiter;
            waiter = new PlayFabResult<GetPlayerCombinedInfoResult>();
            PlayFabServerAPI.GetPlayerCombinedInfo(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfile(GetPlayerProfileRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerProfileResult> waiter;
            waiter = new PlayFabResult<GetPlayerProfileResult>();
            PlayFabServerAPI.GetPlayerProfile(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegments(GetPlayersSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSegmentsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSegmentsResult>();
            PlayFabServerAPI.GetPlayerSegments(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegment(GetPlayersInSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayersInSegmentResult> waiter;
            waiter = new PlayFabResult<GetPlayersInSegmentResult>();
            PlayFabServerAPI.GetPlayersInSegment(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatistics(GetPlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticsResult>();
            PlayFabServerAPI.GetPlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersions(GetPlayerStatisticVersionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticVersionsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticVersionsResult>();
            PlayFabServerAPI.GetPlayerStatisticVersions(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTags(GetPlayerTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerTagsResult> waiter;
            waiter = new PlayFabResult<GetPlayerTagsResult>();
            PlayFabServerAPI.GetPlayerTags(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDs(GetPlayFabIDsFromFacebookIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>();
            PlayFabServerAPI.GetPlayFabIDsFromFacebookIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> GetPlayFabIDsFromFacebookInstantGamesIds(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>();
            PlayFabServerAPI.GetPlayFabIDsFromFacebookInstantGamesIds(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDs(GetPlayFabIDsFromGenericIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGenericIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGenericIDsResult>();
            PlayFabServerAPI.GetPlayFabIDsFromGenericIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> GetPlayFabIDsFromNintendoSwitchDeviceIds(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>();
            PlayFabServerAPI.GetPlayFabIDsFromNintendoSwitchDeviceIds(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDs(GetPlayFabIDsFromPSNAccountIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>();
            PlayFabServerAPI.GetPlayFabIDsFromPSNAccountIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDs(GetPlayFabIDsFromSteamIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromSteamIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromSteamIDsResult>();
            PlayFabServerAPI.GetPlayFabIDsFromSteamIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDs(GetPlayFabIDsFromXboxLiveIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>();
            PlayFabServerAPI.GetPlayFabIDsFromXboxLiveIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherData(GetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPublisherDataResult> waiter;
            waiter = new PlayFabResult<GetPublisherDataResult>();
            PlayFabServerAPI.GetPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTables(GetRandomResultTablesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetRandomResultTablesResult> waiter;
            waiter = new PlayFabResult<GetRandomResultTablesResult>();
            PlayFabServerAPI.GetRandomResultTables(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult>> GetServerCustomIDsFromPlayFabIDs(GetServerCustomIDsFromPlayFabIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult> waiter;
            waiter = new PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult>();
            PlayFabServerAPI.GetServerCustomIDsFromPlayFabIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupData(GetSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<GetSharedGroupDataResult>();
            PlayFabServerAPI.GetSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItems(GetStoreItemsServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetStoreItemsResult> waiter;
            waiter = new PlayFabResult<GetStoreItemsResult>();
            PlayFabServerAPI.GetStoreItems(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTimeResult>> GetTime(GetTimeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTimeResult> waiter;
            waiter = new PlayFabResult<GetTimeResult>();
            PlayFabServerAPI.GetTime(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleData(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            PlayFabServerAPI.GetTitleData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalData(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            PlayFabServerAPI.GetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleNewsResult>> GetTitleNews(GetTitleNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleNewsResult> waiter;
            waiter = new PlayFabResult<GetTitleNewsResult>();
            PlayFabServerAPI.GetTitleNews(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserAccountInfoResult>> GetUserAccountInfo(GetUserAccountInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserAccountInfoResult> waiter;
            waiter = new PlayFabResult<GetUserAccountInfoResult>();
            PlayFabServerAPI.GetUserAccountInfo(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserBansResult>> GetUserBans(GetUserBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserBansResult> waiter;
            waiter = new PlayFabResult<GetUserBansResult>();
            PlayFabServerAPI.GetUserBans(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabServerAPI.GetUserData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserInternalData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabServerAPI.GetUserInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventory(GetUserInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserInventoryResult> waiter;
            waiter = new PlayFabResult<GetUserInventoryResult>();
            PlayFabServerAPI.GetUserInventory(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabServerAPI.GetUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabServerAPI.GetUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabServerAPI.GetUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabServerAPI.GetUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantCharacterToUserResult>> GrantCharacterToUser(GrantCharacterToUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantCharacterToUserResult> waiter;
            waiter = new PlayFabResult<GrantCharacterToUserResult>();
            PlayFabServerAPI.GrantCharacterToUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantItemsToCharacterResult>> GrantItemsToCharacter(GrantItemsToCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToCharacterResult> waiter;
            waiter = new PlayFabResult<GrantItemsToCharacterResult>();
            PlayFabServerAPI.GrantItemsToCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantItemsToUserResult>> GrantItemsToUser(GrantItemsToUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToUserResult> waiter;
            waiter = new PlayFabResult<GrantItemsToUserResult>();
            PlayFabServerAPI.GrantItemsToUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsers(GrantItemsToUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToUsersResult> waiter;
            waiter = new PlayFabResult<GrantItemsToUsersResult>();
            PlayFabServerAPI.GrantItemsToUsers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkPSNAccountResult>> LinkPSNAccount(LinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<LinkPSNAccountResult>();
            PlayFabServerAPI.LinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkServerCustomIdResult>> LinkServerCustomId(LinkServerCustomIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkServerCustomIdResult> waiter;
            waiter = new PlayFabResult<LinkServerCustomIdResult>();
            PlayFabServerAPI.LinkServerCustomId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxAccount(LinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<LinkXboxAccountResult>();
            PlayFabServerAPI.LinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithServerCustomId(LoginWithServerCustomIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            PlayFabServerAPI.LoginWithServerCustomId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithSteamId(LoginWithSteamIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            PlayFabServerAPI.LoginWithSteamId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithXbox(LoginWithXboxRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            PlayFabServerAPI.LoginWithXbox(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithXboxId(LoginWithXboxIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            PlayFabServerAPI.LoginWithXboxId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyItemUsesResult>> ModifyItemUses(ModifyItemUsesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyItemUsesResult> waiter;
            waiter = new PlayFabResult<ModifyItemUsesResult>();
            PlayFabServerAPI.ModifyItemUses(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MoveItemToCharacterFromCharacterResult>> MoveItemToCharacterFromCharacter(MoveItemToCharacterFromCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MoveItemToCharacterFromCharacterResult> waiter;
            waiter = new PlayFabResult<MoveItemToCharacterFromCharacterResult>();
            PlayFabServerAPI.MoveItemToCharacterFromCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MoveItemToCharacterFromUserResult>> MoveItemToCharacterFromUser(MoveItemToCharacterFromUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MoveItemToCharacterFromUserResult> waiter;
            waiter = new PlayFabResult<MoveItemToCharacterFromUserResult>();
            PlayFabServerAPI.MoveItemToCharacterFromUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MoveItemToUserFromCharacterResult>> MoveItemToUserFromCharacter(MoveItemToUserFromCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MoveItemToUserFromCharacterResult> waiter;
            waiter = new PlayFabResult<MoveItemToUserFromCharacterResult>();
            PlayFabServerAPI.MoveItemToUserFromCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<NotifyMatchmakerPlayerLeftResult>> NotifyMatchmakerPlayerLeft(NotifyMatchmakerPlayerLeftRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<NotifyMatchmakerPlayerLeftResult> waiter;
            waiter = new PlayFabResult<NotifyMatchmakerPlayerLeftResult>();
            PlayFabServerAPI.NotifyMatchmakerPlayerLeft(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RedeemCouponResult>> RedeemCoupon(RedeemCouponRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RedeemCouponResult> waiter;
            waiter = new PlayFabResult<RedeemCouponResult>();
            PlayFabServerAPI.RedeemCoupon(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RedeemMatchmakerTicketResult>> RedeemMatchmakerTicket(RedeemMatchmakerTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RedeemMatchmakerTicketResult> waiter;
            waiter = new PlayFabResult<RedeemMatchmakerTicketResult>();
            PlayFabServerAPI.RedeemMatchmakerTicket(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RefreshGameServerInstanceHeartbeatResult>> RefreshGameServerInstanceHeartbeat(RefreshGameServerInstanceHeartbeatRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RefreshGameServerInstanceHeartbeatResult> waiter;
            waiter = new PlayFabResult<RefreshGameServerInstanceHeartbeatResult>();
            PlayFabServerAPI.RefreshGameServerInstanceHeartbeat(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RegisterGameResponse>> RegisterGame(RegisterGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RegisterGameResponse> waiter;
            waiter = new PlayFabResult<RegisterGameResponse>();
            PlayFabServerAPI.RegisterGame(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> RemoveFriend(RemoveFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabServerAPI.RemoveFriend(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> RemoveGenericID(RemoveGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            PlayFabServerAPI.RemoveGenericID(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTag(RemovePlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemovePlayerTagResult> waiter;
            waiter = new PlayFabResult<RemovePlayerTagResult>();
            PlayFabServerAPI.RemovePlayerTag(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembers(RemoveSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<RemoveSharedGroupMembersResult>();
            PlayFabServerAPI.RemoveSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ReportPlayerServerResult>> ReportPlayer(ReportPlayerServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ReportPlayerServerResult> waiter;
            waiter = new PlayFabResult<ReportPlayerServerResult>();
            PlayFabServerAPI.ReportPlayer(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUser(RevokeAllBansForUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeAllBansForUserResult> waiter;
            waiter = new PlayFabResult<RevokeAllBansForUserResult>();
            PlayFabServerAPI.RevokeAllBansForUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeBansResult>> RevokeBans(RevokeBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeBansResult> waiter;
            waiter = new PlayFabResult<RevokeBansResult>();
            PlayFabServerAPI.RevokeBans(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItem(RevokeInventoryItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryResult>();
            PlayFabServerAPI.RevokeInventoryItem(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItems(RevokeInventoryItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryItemsResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryItemsResult>();
            PlayFabServerAPI.RevokeInventoryItems(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SavePushNotificationTemplateResult>> SavePushNotificationTemplate(SavePushNotificationTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SavePushNotificationTemplateResult> waiter;
            waiter = new PlayFabResult<SavePushNotificationTemplateResult>();
            PlayFabServerAPI.SavePushNotificationTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendCustomAccountRecoveryEmailResult>> SendCustomAccountRecoveryEmail(SendCustomAccountRecoveryEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendCustomAccountRecoveryEmailResult> waiter;
            waiter = new PlayFabResult<SendCustomAccountRecoveryEmailResult>();
            PlayFabServerAPI.SendCustomAccountRecoveryEmail(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendEmailFromTemplateResult>> SendEmailFromTemplate(SendEmailFromTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendEmailFromTemplateResult> waiter;
            waiter = new PlayFabResult<SendEmailFromTemplateResult>();
            PlayFabServerAPI.SendEmailFromTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendPushNotificationResult>> SendPushNotification(SendPushNotificationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendPushNotificationResult> waiter;
            waiter = new PlayFabResult<SendPushNotificationResult>();
            PlayFabServerAPI.SendPushNotification(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendPushNotificationResult>> SendPushNotificationFromTemplate(SendPushNotificationFromTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendPushNotificationResult> waiter;
            waiter = new PlayFabResult<SendPushNotificationResult>();
            PlayFabServerAPI.SendPushNotificationFromTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> SetFriendTags(SetFriendTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabServerAPI.SetFriendTags(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetGameServerInstanceDataResult>> SetGameServerInstanceData(SetGameServerInstanceDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetGameServerInstanceDataResult> waiter;
            waiter = new PlayFabResult<SetGameServerInstanceDataResult>();
            PlayFabServerAPI.SetGameServerInstanceData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetGameServerInstanceStateResult>> SetGameServerInstanceState(SetGameServerInstanceStateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetGameServerInstanceStateResult> waiter;
            waiter = new PlayFabResult<SetGameServerInstanceStateResult>();
            PlayFabServerAPI.SetGameServerInstanceState(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetGameServerInstanceTagsResult>> SetGameServerInstanceTags(SetGameServerInstanceTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetGameServerInstanceTagsResult> waiter;
            waiter = new PlayFabResult<SetGameServerInstanceTagsResult>();
            PlayFabServerAPI.SetGameServerInstanceTags(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecret(SetPlayerSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPlayerSecretResult> waiter;
            waiter = new PlayFabResult<SetPlayerSecretResult>();
            PlayFabServerAPI.SetPlayerSecret(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPublisherDataResult>> SetPublisherData(SetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPublisherDataResult> waiter;
            waiter = new PlayFabResult<SetPublisherDataResult>();
            PlayFabServerAPI.SetPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleData(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            PlayFabServerAPI.SetTitleData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalData(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            PlayFabServerAPI.SetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> SubtractCharacterVirtualCurrency(SubtractCharacterVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyCharacterVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyCharacterVirtualCurrencyResult>();
            PlayFabServerAPI.SubtractCharacterVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            PlayFabServerAPI.SubtractUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkPSNAccountResult>> UnlinkPSNAccount(UnlinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkPSNAccountResult>();
            PlayFabServerAPI.UnlinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkServerCustomIdResult>> UnlinkServerCustomId(UnlinkServerCustomIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkServerCustomIdResult> waiter;
            waiter = new PlayFabResult<UnlinkServerCustomIdResult>();
            PlayFabServerAPI.UnlinkServerCustomId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkXboxAccountResult>> UnlinkXboxAccount(UnlinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkXboxAccountResult>();
            PlayFabServerAPI.UnlinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerInstance(UnlockContainerInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            PlayFabServerAPI.UnlockContainerInstance(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItem(UnlockContainerItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            PlayFabServerAPI.UnlockContainerItem(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateAvatarUrl(UpdateAvatarUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabServerAPI.UpdateAvatarUrl(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateBansResult>> UpdateBans(UpdateBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateBansResult> waiter;
            waiter = new PlayFabResult<UpdateBansResult>();
            PlayFabServerAPI.UpdateBans(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterData(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            PlayFabServerAPI.UpdateCharacterData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterInternalData(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            PlayFabServerAPI.UpdateCharacterInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterReadOnlyData(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            PlayFabServerAPI.UpdateCharacterReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatistics(UpdateCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterStatisticsResult>();
            PlayFabServerAPI.UpdateCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatistics(UpdatePlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerStatisticsResult>();
            PlayFabServerAPI.UpdatePlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupData(UpdateSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<UpdateSharedGroupDataResult>();
            PlayFabServerAPI.UpdateSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabServerAPI.UpdateUserData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalData(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabServerAPI.UpdateUserInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateUserInventoryItemCustomData(UpdateUserInventoryItemDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabServerAPI.UpdateUserInventoryItemCustomData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabServerAPI.UpdateUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalData(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabServerAPI.UpdateUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabServerAPI.UpdateUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabServerAPI.UpdateUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteCharacterEvent(WriteServerCharacterEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            PlayFabServerAPI.WriteCharacterEvent(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WritePlayerEvent(WriteServerPlayerEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            PlayFabServerAPI.WritePlayerEvent(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteTitleEvent(WriteTitleEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            PlayFabServerAPI.WriteTitleEvent(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
