using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if ENABLE_PLAYFABSERVER_API
using PlayFab.ServerModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static partial class PlayFabServerAPI
    {
        #if ENABLE_PLAYFABSERVER_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> AddCharacterVirtualCurrencyAsync(AddCharacterVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyCharacterVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyCharacterVirtualCurrencyResult>();
            AddCharacterVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> AddFriendAsync(AddFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            AddFriend(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> AddGenericIDAsync(AddGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            AddGenericID(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTagAsync(AddPlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddPlayerTagResult> waiter;
            waiter = new PlayFabResult<AddPlayerTagResult>();
            AddPlayerTag(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<AddSharedGroupMembersResult>();
            AddSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            AddUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AuthenticateSessionTicketResult>> AuthenticateSessionTicketAsync(AuthenticateSessionTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AuthenticateSessionTicketResult> waiter;
            waiter = new PlayFabResult<AuthenticateSessionTicketResult>();
            AuthenticateSessionTicket(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AwardSteamAchievementResult>> AwardSteamAchievementAsync(AwardSteamAchievementRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AwardSteamAchievementResult> waiter;
            waiter = new PlayFabResult<AwardSteamAchievementResult>();
            AwardSteamAchievement(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BanUsersResult>> BanUsersAsync(BanUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BanUsersResult> waiter;
            waiter = new PlayFabResult<BanUsersResult>();
            BanUsers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeItemResult> waiter;
            waiter = new PlayFabResult<ConsumeItemResult>();
            ConsumeItem(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroupAsync(CreateSharedGroupRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateSharedGroupResult> waiter;
            waiter = new PlayFabResult<CreateSharedGroupResult>();
            CreateSharedGroup(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteCharacterFromUserResult>> DeleteCharacterFromUserAsync(DeleteCharacterFromUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteCharacterFromUserResult> waiter;
            waiter = new PlayFabResult<DeleteCharacterFromUserResult>();
            DeleteCharacterFromUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePlayerResult>> DeletePlayerAsync(DeletePlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePlayerResult> waiter;
            waiter = new PlayFabResult<DeletePlayerResult>();
            DeletePlayer(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePushNotificationTemplateResult>> DeletePushNotificationTemplateAsync(DeletePushNotificationTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePushNotificationTemplateResult> waiter;
            waiter = new PlayFabResult<DeletePushNotificationTemplateResult>();
            DeletePushNotificationTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteSharedGroupAsync(DeleteSharedGroupRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            DeleteSharedGroup(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeregisterGameResponse>> DeregisterGameAsync(DeregisterGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeregisterGameResponse> waiter;
            waiter = new PlayFabResult<DeregisterGameResponse>();
            DeregisterGame(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EvaluateRandomResultTableResult>> EvaluateRandomResultTableAsync(EvaluateRandomResultTableRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EvaluateRandomResultTableResult> waiter;
            waiter = new PlayFabResult<EvaluateRandomResultTableResult>();
            EvaluateRandomResultTable(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScriptAsync(ExecuteCloudScriptServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ExecuteCloudScriptResult> waiter;
            waiter = new PlayFabResult<ExecuteCloudScriptResult>();
            ExecuteCloudScript(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegmentsAsync(GetAllSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAllSegmentsResult> waiter;
            waiter = new PlayFabResult<GetAllSegmentsResult>();
            GetAllSegments(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListUsersCharactersResult>> GetAllUsersCharactersAsync(ListUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListUsersCharactersResult> waiter;
            waiter = new PlayFabResult<ListUsersCharactersResult>();
            GetAllUsersCharacters(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCatalogItemsResult> waiter;
            waiter = new PlayFabResult<GetCatalogItemsResult>();
            GetCatalogItems(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterDataAsync(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            GetCharacterData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterInternalDataAsync(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            GetCharacterInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterInventoryResult>> GetCharacterInventoryAsync(GetCharacterInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterInventoryResult> waiter;
            waiter = new PlayFabResult<GetCharacterInventoryResult>();
            GetCharacterInventory(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetCharacterLeaderboardResult>();
            GetCharacterLeaderboard(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            GetCharacterReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterStatisticsResult>> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<GetCharacterStatisticsResult>();
            GetCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentDownloadUrlResult>> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentDownloadUrlResult> waiter;
            waiter = new PlayFabResult<GetContentDownloadUrlResult>();
            GetContentDownloadUrl(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            GetFriendLeaderboard(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(GetFriendsListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetFriendsListResult> waiter;
            waiter = new PlayFabResult<GetFriendsListResult>();
            GetFriendsList(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            GetLeaderboard(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundCharacterResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundCharacterResult>();
            GetLeaderboardAroundCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundUserResult>> GetLeaderboardAroundUserAsync(GetLeaderboardAroundUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundUserResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundUserResult>();
            GetLeaderboardAroundUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardForUsersCharactersResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardForUsersCharactersResult>();
            GetLeaderboardForUserCharacters(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerCombinedInfoResult> waiter;
            waiter = new PlayFabResult<GetPlayerCombinedInfoResult>();
            GetPlayerCombinedInfo(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerProfileResult> waiter;
            waiter = new PlayFabResult<GetPlayerProfileResult>();
            GetPlayerProfile(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSegmentsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSegmentsResult>();
            GetPlayerSegments(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayersInSegmentResult> waiter;
            waiter = new PlayFabResult<GetPlayersInSegmentResult>();
            GetPlayersInSegment(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticsResult>();
            GetPlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticVersionsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticVersionsResult>();
            GetPlayerStatisticVersions(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerTagsResult> waiter;
            waiter = new PlayFabResult<GetPlayerTagsResult>();
            GetPlayerTags(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>();
            GetPlayFabIDsFromFacebookIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>();
            GetPlayFabIDsFromFacebookInstantGamesIds(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGenericIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGenericIDsResult>();
            GetPlayFabIDsFromGenericIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>();
            GetPlayFabIDsFromNintendoSwitchDeviceIds(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>();
            GetPlayFabIDsFromPSNAccountIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromSteamIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromSteamIDsResult>();
            GetPlayFabIDsFromSteamIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>();
            GetPlayFabIDsFromXboxLiveIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPublisherDataResult> waiter;
            waiter = new PlayFabResult<GetPublisherDataResult>();
            GetPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTablesAsync(GetRandomResultTablesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetRandomResultTablesResult> waiter;
            waiter = new PlayFabResult<GetRandomResultTablesResult>();
            GetRandomResultTables(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult>> GetServerCustomIDsFromPlayFabIDsAsync(GetServerCustomIDsFromPlayFabIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult> waiter;
            waiter = new PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult>();
            GetServerCustomIDsFromPlayFabIDs(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupDataAsync(GetSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<GetSharedGroupDataResult>();
            GetSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetStoreItemsResult> waiter;
            waiter = new PlayFabResult<GetStoreItemsResult>();
            GetStoreItems(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTimeResult>> GetTimeAsync(GetTimeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTimeResult> waiter;
            waiter = new PlayFabResult<GetTimeResult>();
            GetTime(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            GetTitleData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalDataAsync(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            GetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleNewsResult>> GetTitleNewsAsync(GetTitleNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleNewsResult> waiter;
            waiter = new PlayFabResult<GetTitleNewsResult>();
            GetTitleNews(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserAccountInfoResult>> GetUserAccountInfoAsync(GetUserAccountInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserAccountInfoResult> waiter;
            waiter = new PlayFabResult<GetUserAccountInfoResult>();
            GetUserAccountInfo(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserBansResult>> GetUserBansAsync(GetUserBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserBansResult> waiter;
            waiter = new PlayFabResult<GetUserBansResult>();
            GetUserBans(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserInventoryResult> waiter;
            waiter = new PlayFabResult<GetUserInventoryResult>();
            GetUserInventory(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantCharacterToUserResult>> GrantCharacterToUserAsync(GrantCharacterToUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantCharacterToUserResult> waiter;
            waiter = new PlayFabResult<GrantCharacterToUserResult>();
            GrantCharacterToUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantItemsToCharacterResult>> GrantItemsToCharacterAsync(GrantItemsToCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToCharacterResult> waiter;
            waiter = new PlayFabResult<GrantItemsToCharacterResult>();
            GrantItemsToCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantItemsToUserResult>> GrantItemsToUserAsync(GrantItemsToUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToUserResult> waiter;
            waiter = new PlayFabResult<GrantItemsToUserResult>();
            GrantItemsToUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsersAsync(GrantItemsToUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToUsersResult> waiter;
            waiter = new PlayFabResult<GrantItemsToUsersResult>();
            GrantItemsToUsers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkPSNAccountResult>> LinkPSNAccountAsync(LinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<LinkPSNAccountResult>();
            LinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkServerCustomIdResult>> LinkServerCustomIdAsync(LinkServerCustomIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkServerCustomIdResult> waiter;
            waiter = new PlayFabResult<LinkServerCustomIdResult>();
            LinkServerCustomId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxAccountAsync(LinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<LinkXboxAccountResult>();
            LinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithServerCustomIdAsync(LoginWithServerCustomIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            LoginWithServerCustomId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithSteamIdAsync(LoginWithSteamIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            LoginWithSteamId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithXboxAsync(LoginWithXboxRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            LoginWithXbox(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ServerLoginResult>> LoginWithXboxIdAsync(LoginWithXboxIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ServerLoginResult> waiter;
            waiter = new PlayFabResult<ServerLoginResult>();
            LoginWithXboxId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyItemUsesResult>> ModifyItemUsesAsync(ModifyItemUsesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyItemUsesResult> waiter;
            waiter = new PlayFabResult<ModifyItemUsesResult>();
            ModifyItemUses(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MoveItemToCharacterFromCharacterResult>> MoveItemToCharacterFromCharacterAsync(MoveItemToCharacterFromCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MoveItemToCharacterFromCharacterResult> waiter;
            waiter = new PlayFabResult<MoveItemToCharacterFromCharacterResult>();
            MoveItemToCharacterFromCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MoveItemToCharacterFromUserResult>> MoveItemToCharacterFromUserAsync(MoveItemToCharacterFromUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MoveItemToCharacterFromUserResult> waiter;
            waiter = new PlayFabResult<MoveItemToCharacterFromUserResult>();
            MoveItemToCharacterFromUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MoveItemToUserFromCharacterResult>> MoveItemToUserFromCharacterAsync(MoveItemToUserFromCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MoveItemToUserFromCharacterResult> waiter;
            waiter = new PlayFabResult<MoveItemToUserFromCharacterResult>();
            MoveItemToUserFromCharacter(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<NotifyMatchmakerPlayerLeftResult>> NotifyMatchmakerPlayerLeftAsync(NotifyMatchmakerPlayerLeftRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<NotifyMatchmakerPlayerLeftResult> waiter;
            waiter = new PlayFabResult<NotifyMatchmakerPlayerLeftResult>();
            NotifyMatchmakerPlayerLeft(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RedeemCouponResult>> RedeemCouponAsync(RedeemCouponRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RedeemCouponResult> waiter;
            waiter = new PlayFabResult<RedeemCouponResult>();
            RedeemCoupon(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RedeemMatchmakerTicketResult>> RedeemMatchmakerTicketAsync(RedeemMatchmakerTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RedeemMatchmakerTicketResult> waiter;
            waiter = new PlayFabResult<RedeemMatchmakerTicketResult>();
            RedeemMatchmakerTicket(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RefreshGameServerInstanceHeartbeatResult>> RefreshGameServerInstanceHeartbeatAsync(RefreshGameServerInstanceHeartbeatRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RefreshGameServerInstanceHeartbeatResult> waiter;
            waiter = new PlayFabResult<RefreshGameServerInstanceHeartbeatResult>();
            RefreshGameServerInstanceHeartbeat(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RegisterGameResponse>> RegisterGameAsync(RegisterGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RegisterGameResponse> waiter;
            waiter = new PlayFabResult<RegisterGameResponse>();
            RegisterGame(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> RemoveFriendAsync(RemoveFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            RemoveFriend(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> RemoveGenericIDAsync(RemoveGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            RemoveGenericID(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTagAsync(RemovePlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemovePlayerTagResult> waiter;
            waiter = new PlayFabResult<RemovePlayerTagResult>();
            RemovePlayerTag(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<RemoveSharedGroupMembersResult>();
            RemoveSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ReportPlayerServerResult>> ReportPlayerAsync(ReportPlayerServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ReportPlayerServerResult> waiter;
            waiter = new PlayFabResult<ReportPlayerServerResult>();
            ReportPlayer(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeAllBansForUserResult> waiter;
            waiter = new PlayFabResult<RevokeAllBansForUserResult>();
            RevokeAllBansForUser(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeBansResult>> RevokeBansAsync(RevokeBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeBansResult> waiter;
            waiter = new PlayFabResult<RevokeBansResult>();
            RevokeBans(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItemAsync(RevokeInventoryItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryResult>();
            RevokeInventoryItem(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryItemsResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryItemsResult>();
            RevokeInventoryItems(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SavePushNotificationTemplateResult>> SavePushNotificationTemplateAsync(SavePushNotificationTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SavePushNotificationTemplateResult> waiter;
            waiter = new PlayFabResult<SavePushNotificationTemplateResult>();
            SavePushNotificationTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendCustomAccountRecoveryEmailResult>> SendCustomAccountRecoveryEmailAsync(SendCustomAccountRecoveryEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendCustomAccountRecoveryEmailResult> waiter;
            waiter = new PlayFabResult<SendCustomAccountRecoveryEmailResult>();
            SendCustomAccountRecoveryEmail(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendEmailFromTemplateResult>> SendEmailFromTemplateAsync(SendEmailFromTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendEmailFromTemplateResult> waiter;
            waiter = new PlayFabResult<SendEmailFromTemplateResult>();
            SendEmailFromTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendPushNotificationResult>> SendPushNotificationAsync(SendPushNotificationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendPushNotificationResult> waiter;
            waiter = new PlayFabResult<SendPushNotificationResult>();
            SendPushNotification(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendPushNotificationResult>> SendPushNotificationFromTemplateAsync(SendPushNotificationFromTemplateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendPushNotificationResult> waiter;
            waiter = new PlayFabResult<SendPushNotificationResult>();
            SendPushNotificationFromTemplate(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> SetFriendTagsAsync(SetFriendTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            SetFriendTags(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetGameServerInstanceDataResult>> SetGameServerInstanceDataAsync(SetGameServerInstanceDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetGameServerInstanceDataResult> waiter;
            waiter = new PlayFabResult<SetGameServerInstanceDataResult>();
            SetGameServerInstanceData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetGameServerInstanceStateResult>> SetGameServerInstanceStateAsync(SetGameServerInstanceStateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetGameServerInstanceStateResult> waiter;
            waiter = new PlayFabResult<SetGameServerInstanceStateResult>();
            SetGameServerInstanceState(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetGameServerInstanceTagsResult>> SetGameServerInstanceTagsAsync(SetGameServerInstanceTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetGameServerInstanceTagsResult> waiter;
            waiter = new PlayFabResult<SetGameServerInstanceTagsResult>();
            SetGameServerInstanceTags(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPlayerSecretResult> waiter;
            waiter = new PlayFabResult<SetPlayerSecretResult>();
            SetPlayerSecret(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPublisherDataResult>> SetPublisherDataAsync(SetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPublisherDataResult> waiter;
            waiter = new PlayFabResult<SetPublisherDataResult>();
            SetPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleDataAsync(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            SetTitleData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalDataAsync(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            SetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> SubtractCharacterVirtualCurrencyAsync(SubtractCharacterVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyCharacterVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyCharacterVirtualCurrencyResult>();
            SubtractCharacterVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            SubtractUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkPSNAccountResult>> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkPSNAccountResult>();
            UnlinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkServerCustomIdResult>> UnlinkServerCustomIdAsync(UnlinkServerCustomIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkServerCustomIdResult> waiter;
            waiter = new PlayFabResult<UnlinkServerCustomIdResult>();
            UnlinkServerCustomId(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkXboxAccountResult>> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkXboxAccountResult>();
            UnlinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            UnlockContainerInstance(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItemAsync(UnlockContainerItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            UnlockContainerItem(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UpdateAvatarUrl(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateBansResult>> UpdateBansAsync(UpdateBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateBansResult> waiter;
            waiter = new PlayFabResult<UpdateBansResult>();
            UpdateBans(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterDataAsync(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            UpdateCharacterData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterInternalDataAsync(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            UpdateCharacterInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterReadOnlyDataAsync(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            UpdateCharacterReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterStatisticsResult>();
            UpdateCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerStatisticsResult>();
            UpdatePlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<UpdateSharedGroupDataResult>();
            UpdateSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateUserInventoryItemCustomDataAsync(UpdateUserInventoryItemDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UpdateUserInventoryItemCustomData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteCharacterEventAsync(WriteServerCharacterEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            WriteCharacterEvent(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WritePlayerEventAsync(WriteServerPlayerEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            WritePlayerEvent(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteTitleEventAsync(WriteTitleEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            WriteTitleEvent(request, waiter.processSuccess, waiter.processFail);
            await waiter;
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
