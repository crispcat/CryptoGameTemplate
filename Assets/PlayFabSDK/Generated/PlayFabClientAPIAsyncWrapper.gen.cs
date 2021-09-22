using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if !DISABLE_PLAYFABCLIENT_API
using PlayFab.ClientModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static partial class PlayFabClientAPI
    {
        #if !DISABLE_PLAYFABCLIENT_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<AcceptTradeResponse>> AcceptTradeAsync(AcceptTradeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AcceptTradeResponse> waiter;
            waiter = new PlayFabResult<AcceptTradeResponse>();
            AcceptTrade(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddFriendResult>> AddFriendAsync(AddFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddFriendResult> waiter;
            waiter = new PlayFabResult<AddFriendResult>();
            AddFriend(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddGenericIDResult>> AddGenericIDAsync(AddGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddGenericIDResult> waiter;
            waiter = new PlayFabResult<AddGenericIDResult>();
            AddGenericID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddOrUpdateContactEmailResult>> AddOrUpdateContactEmailAsync(AddOrUpdateContactEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddOrUpdateContactEmailResult> waiter;
            waiter = new PlayFabResult<AddOrUpdateContactEmailResult>();
            AddOrUpdateContactEmail(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<AddSharedGroupMembersResult>();
            AddSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddUsernamePasswordResult>> AddUsernamePasswordAsync(AddUsernamePasswordRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddUsernamePasswordResult> waiter;
            waiter = new PlayFabResult<AddUsernamePasswordResult>();
            AddUsernamePassword(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            AddUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AndroidDevicePushNotificationRegistrationResult>> AndroidDevicePushNotificationRegistrationAsync(AndroidDevicePushNotificationRegistrationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AndroidDevicePushNotificationRegistrationResult> waiter;
            waiter = new PlayFabResult<AndroidDevicePushNotificationRegistrationResult>();
            AndroidDevicePushNotificationRegistration(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AttributeInstallResult>> AttributeInstallAsync(AttributeInstallRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AttributeInstallResult> waiter;
            waiter = new PlayFabResult<AttributeInstallResult>();
            AttributeInstall(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CancelTradeResponse>> CancelTradeAsync(CancelTradeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CancelTradeResponse> waiter;
            waiter = new PlayFabResult<CancelTradeResponse>();
            CancelTrade(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConfirmPurchaseResult>> ConfirmPurchaseAsync(ConfirmPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConfirmPurchaseResult> waiter;
            waiter = new PlayFabResult<ConfirmPurchaseResult>();
            ConfirmPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeItemResult> waiter;
            waiter = new PlayFabResult<ConsumeItemResult>();
            ConsumeItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse>> ConsumeMicrosoftStoreEntitlementsAsync(ConsumeMicrosoftStoreEntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse> waiter;
            waiter = new PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse>();
            ConsumeMicrosoftStoreEntitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumePS5EntitlementsResult>> ConsumePS5EntitlementsAsync(ConsumePS5EntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumePS5EntitlementsResult> waiter;
            waiter = new PlayFabResult<ConsumePS5EntitlementsResult>();
            ConsumePS5Entitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumePSNEntitlementsResult>> ConsumePSNEntitlementsAsync(ConsumePSNEntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumePSNEntitlementsResult> waiter;
            waiter = new PlayFabResult<ConsumePSNEntitlementsResult>();
            ConsumePSNEntitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeXboxEntitlementsResult>> ConsumeXboxEntitlementsAsync(ConsumeXboxEntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeXboxEntitlementsResult> waiter;
            waiter = new PlayFabResult<ConsumeXboxEntitlementsResult>();
            ConsumeXboxEntitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroupAsync(CreateSharedGroupRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateSharedGroupResult> waiter;
            waiter = new PlayFabResult<CreateSharedGroupResult>();
            CreateSharedGroup(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScriptAsync(ExecuteCloudScriptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ExecuteCloudScriptResult> waiter;
            waiter = new PlayFabResult<ExecuteCloudScriptResult>();
            ExecuteCloudScript(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAccountInfoResult>> GetAccountInfoAsync(GetAccountInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAccountInfoResult> waiter;
            waiter = new PlayFabResult<GetAccountInfoResult>();
            GetAccountInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAdPlacementsResult>> GetAdPlacementsAsync(GetAdPlacementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAdPlacementsResult> waiter;
            waiter = new PlayFabResult<GetAdPlacementsResult>();
            GetAdPlacements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListUsersCharactersResult>> GetAllUsersCharactersAsync(ListUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListUsersCharactersResult> waiter;
            waiter = new PlayFabResult<ListUsersCharactersResult>();
            GetAllUsersCharacters(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCatalogItemsResult> waiter;
            waiter = new PlayFabResult<GetCatalogItemsResult>();
            GetCatalogItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterDataAsync(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            GetCharacterData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterInventoryResult>> GetCharacterInventoryAsync(GetCharacterInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterInventoryResult> waiter;
            waiter = new PlayFabResult<GetCharacterInventoryResult>();
            GetCharacterInventory(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetCharacterLeaderboardResult>();
            GetCharacterLeaderboard(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            GetCharacterReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterStatisticsResult>> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<GetCharacterStatisticsResult>();
            GetCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentDownloadUrlResult>> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentDownloadUrlResult> waiter;
            waiter = new PlayFabResult<GetContentDownloadUrlResult>();
            GetContentDownloadUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CurrentGamesResult>> GetCurrentGamesAsync(CurrentGamesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CurrentGamesResult> waiter;
            waiter = new PlayFabResult<CurrentGamesResult>();
            GetCurrentGames(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            GetFriendLeaderboard(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetFriendLeaderboardAroundPlayerResult>> GetFriendLeaderboardAroundPlayerAsync(GetFriendLeaderboardAroundPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetFriendLeaderboardAroundPlayerResult> waiter;
            waiter = new PlayFabResult<GetFriendLeaderboardAroundPlayerResult>();
            GetFriendLeaderboardAroundPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(GetFriendsListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetFriendsListResult> waiter;
            waiter = new PlayFabResult<GetFriendsListResult>();
            GetFriendsList(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GameServerRegionsResult>> GetGameServerRegionsAsync(GameServerRegionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GameServerRegionsResult> waiter;
            waiter = new PlayFabResult<GameServerRegionsResult>();
            GetGameServerRegions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            GetLeaderboard(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundCharacterResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundCharacterResult>();
            GetLeaderboardAroundCharacter(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundPlayerResult>> GetLeaderboardAroundPlayerAsync(GetLeaderboardAroundPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundPlayerResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundPlayerResult>();
            GetLeaderboardAroundPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardForUsersCharactersResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardForUsersCharactersResult>();
            GetLeaderboardForUserCharacters(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPaymentTokenResult>> GetPaymentTokenAsync(GetPaymentTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPaymentTokenResult> waiter;
            waiter = new PlayFabResult<GetPaymentTokenResult>();
            GetPaymentToken(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPhotonAuthenticationTokenResult>> GetPhotonAuthenticationTokenAsync(GetPhotonAuthenticationTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPhotonAuthenticationTokenResult> waiter;
            waiter = new PlayFabResult<GetPhotonAuthenticationTokenResult>();
            GetPhotonAuthenticationToken(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerCombinedInfoResult> waiter;
            waiter = new PlayFabResult<GetPlayerCombinedInfoResult>();
            GetPlayerCombinedInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerProfileResult> waiter;
            waiter = new PlayFabResult<GetPlayerProfileResult>();
            GetPlayerProfile(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayerSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSegmentsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSegmentsResult>();
            GetPlayerSegments(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticsResult>();
            GetPlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticVersionsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticVersionsResult>();
            GetPlayerStatisticVersions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerTagsResult> waiter;
            waiter = new PlayFabResult<GetPlayerTagsResult>();
            GetPlayerTags(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerTradesResponse>> GetPlayerTradesAsync(GetPlayerTradesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerTradesResponse> waiter;
            waiter = new PlayFabResult<GetPlayerTradesResponse>();
            GetPlayerTrades(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>();
            GetPlayFabIDsFromFacebookIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>();
            GetPlayFabIDsFromFacebookInstantGamesIds(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult>> GetPlayFabIDsFromGameCenterIDsAsync(GetPlayFabIDsFromGameCenterIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult>();
            GetPlayFabIDsFromGameCenterIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGenericIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGenericIDsResult>();
            GetPlayFabIDsFromGenericIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGoogleIDsResult>> GetPlayFabIDsFromGoogleIDsAsync(GetPlayFabIDsFromGoogleIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGoogleIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGoogleIDsResult>();
            GetPlayFabIDsFromGoogleIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromKongregateIDsResult>> GetPlayFabIDsFromKongregateIDsAsync(GetPlayFabIDsFromKongregateIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromKongregateIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromKongregateIDsResult>();
            GetPlayFabIDsFromKongregateIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>();
            GetPlayFabIDsFromNintendoSwitchDeviceIds(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>();
            GetPlayFabIDsFromPSNAccountIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromSteamIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromSteamIDsResult>();
            GetPlayFabIDsFromSteamIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromTwitchIDsResult>> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromTwitchIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromTwitchIDsResult>();
            GetPlayFabIDsFromTwitchIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>();
            GetPlayFabIDsFromXboxLiveIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPublisherDataResult> waiter;
            waiter = new PlayFabResult<GetPublisherDataResult>();
            GetPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPurchaseResult>> GetPurchaseAsync(GetPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPurchaseResult> waiter;
            waiter = new PlayFabResult<GetPurchaseResult>();
            GetPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupDataAsync(GetSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<GetSharedGroupDataResult>();
            GetSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetStoreItemsResult> waiter;
            waiter = new PlayFabResult<GetStoreItemsResult>();
            GetStoreItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTimeResult>> GetTimeAsync(GetTimeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTimeResult> waiter;
            waiter = new PlayFabResult<GetTimeResult>();
            GetTime(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            GetTitleData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleNewsResult>> GetTitleNewsAsync(GetTitleNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleNewsResult> waiter;
            waiter = new PlayFabResult<GetTitleNewsResult>();
            GetTitleNews(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitlePublicKeyResult>> GetTitlePublicKeyAsync(GetTitlePublicKeyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitlePublicKeyResult> waiter;
            waiter = new PlayFabResult<GetTitlePublicKeyResult>();
            GetTitlePublicKey(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTradeStatusResponse>> GetTradeStatusAsync(GetTradeStatusRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTradeStatusResponse> waiter;
            waiter = new PlayFabResult<GetTradeStatusResponse>();
            GetTradeStatus(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserInventoryResult> waiter;
            waiter = new PlayFabResult<GetUserInventoryResult>();
            GetUserInventory(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantCharacterToUserResult>> GrantCharacterToUserAsync(GrantCharacterToUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantCharacterToUserResult> waiter;
            waiter = new PlayFabResult<GrantCharacterToUserResult>();
            GrantCharacterToUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkAndroidDeviceIDResult>> LinkAndroidDeviceIDAsync(LinkAndroidDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkAndroidDeviceIDResult> waiter;
            waiter = new PlayFabResult<LinkAndroidDeviceIDResult>();
            LinkAndroidDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> LinkAppleAsync(LinkAppleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            LinkApple(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkCustomIDResult>> LinkCustomIDAsync(LinkCustomIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkCustomIDResult> waiter;
            waiter = new PlayFabResult<LinkCustomIDResult>();
            LinkCustomID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkFacebookAccountResult>> LinkFacebookAccountAsync(LinkFacebookAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkFacebookAccountResult> waiter;
            waiter = new PlayFabResult<LinkFacebookAccountResult>();
            LinkFacebookAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkFacebookInstantGamesIdResult>> LinkFacebookInstantGamesIdAsync(LinkFacebookInstantGamesIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkFacebookInstantGamesIdResult> waiter;
            waiter = new PlayFabResult<LinkFacebookInstantGamesIdResult>();
            LinkFacebookInstantGamesId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkGameCenterAccountResult>> LinkGameCenterAccountAsync(LinkGameCenterAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkGameCenterAccountResult> waiter;
            waiter = new PlayFabResult<LinkGameCenterAccountResult>();
            LinkGameCenterAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkGoogleAccountResult>> LinkGoogleAccountAsync(LinkGoogleAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkGoogleAccountResult> waiter;
            waiter = new PlayFabResult<LinkGoogleAccountResult>();
            LinkGoogleAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkIOSDeviceIDResult>> LinkIOSDeviceIDAsync(LinkIOSDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkIOSDeviceIDResult> waiter;
            waiter = new PlayFabResult<LinkIOSDeviceIDResult>();
            LinkIOSDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkKongregateAccountResult>> LinkKongregateAsync(LinkKongregateAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkKongregateAccountResult> waiter;
            waiter = new PlayFabResult<LinkKongregateAccountResult>();
            LinkKongregate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            LinkNintendoServiceAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkNintendoSwitchDeviceIdResult>> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkNintendoSwitchDeviceIdResult> waiter;
            waiter = new PlayFabResult<LinkNintendoSwitchDeviceIdResult>();
            LinkNintendoSwitchDeviceId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> LinkOpenIdConnectAsync(LinkOpenIdConnectRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            LinkOpenIdConnect(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkPSNAccountResult>> LinkPSNAccountAsync(LinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<LinkPSNAccountResult>();
            LinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkSteamAccountResult>> LinkSteamAccountAsync(LinkSteamAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkSteamAccountResult> waiter;
            waiter = new PlayFabResult<LinkSteamAccountResult>();
            LinkSteamAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkTwitchAccountResult>> LinkTwitchAsync(LinkTwitchAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkTwitchAccountResult> waiter;
            waiter = new PlayFabResult<LinkTwitchAccountResult>();
            LinkTwitch(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxAccountAsync(LinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<LinkXboxAccountResult>();
            LinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithAndroidDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithAppleAsync(LoginWithAppleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithApple(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithCustomIDAsync(LoginWithCustomIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithCustomID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithEmailAddressAsync(LoginWithEmailAddressRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithEmailAddress(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithFacebookAsync(LoginWithFacebookRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithFacebook(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithFacebookInstantGamesIdAsync(LoginWithFacebookInstantGamesIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithFacebookInstantGamesId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithGameCenterAsync(LoginWithGameCenterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithGameCenter(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithGoogleAccountAsync(LoginWithGoogleAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithGoogleAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithIOSDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithKongregateAsync(LoginWithKongregateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithKongregate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithNintendoServiceAccountAsync(LoginWithNintendoServiceAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithNintendoServiceAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithNintendoSwitchDeviceIdAsync(LoginWithNintendoSwitchDeviceIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithNintendoSwitchDeviceId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithOpenIdConnectAsync(LoginWithOpenIdConnectRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithOpenIdConnect(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithPlayFabAsync(LoginWithPlayFabRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithPlayFab(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithPSNAsync(LoginWithPSNRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithPSN(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithSteamAsync(LoginWithSteamRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithSteam(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithTwitchAsync(LoginWithTwitchRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithTwitch(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithXboxAsync(LoginWithXboxRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            LoginWithXbox(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MatchmakeResult>> MatchmakeAsync(MatchmakeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MatchmakeResult> waiter;
            waiter = new PlayFabResult<MatchmakeResult>();
            Matchmake(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<OpenTradeResponse>> OpenTradeAsync(OpenTradeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<OpenTradeResponse> waiter;
            waiter = new PlayFabResult<OpenTradeResponse>();
            OpenTrade(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PayForPurchaseResult>> PayForPurchaseAsync(PayForPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PayForPurchaseResult> waiter;
            waiter = new PlayFabResult<PayForPurchaseResult>();
            PayForPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PurchaseItemResult>> PurchaseItemAsync(PurchaseItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PurchaseItemResult> waiter;
            waiter = new PlayFabResult<PurchaseItemResult>();
            PurchaseItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RedeemCouponResult>> RedeemCouponAsync(RedeemCouponRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RedeemCouponResult> waiter;
            waiter = new PlayFabResult<RedeemCouponResult>();
            RedeemCoupon(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> RefreshPSNAuthTokenAsync(RefreshPSNAuthTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            RefreshPSNAuthToken(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RegisterForIOSPushNotificationResult>> RegisterForIOSPushNotificationAsync(RegisterForIOSPushNotificationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RegisterForIOSPushNotificationResult> waiter;
            waiter = new PlayFabResult<RegisterForIOSPushNotificationResult>();
            RegisterForIOSPushNotification(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RegisterPlayFabUserResult>> RegisterPlayFabUserAsync(RegisterPlayFabUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RegisterPlayFabUserResult> waiter;
            waiter = new PlayFabResult<RegisterPlayFabUserResult>();
            RegisterPlayFabUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveContactEmailResult>> RemoveContactEmailAsync(RemoveContactEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveContactEmailResult> waiter;
            waiter = new PlayFabResult<RemoveContactEmailResult>();
            RemoveContactEmail(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveFriendResult>> RemoveFriendAsync(RemoveFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveFriendResult> waiter;
            waiter = new PlayFabResult<RemoveFriendResult>();
            RemoveFriend(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveGenericIDResult>> RemoveGenericIDAsync(RemoveGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveGenericIDResult> waiter;
            waiter = new PlayFabResult<RemoveGenericIDResult>();
            RemoveGenericID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<RemoveSharedGroupMembersResult>();
            RemoveSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ReportAdActivityResult>> ReportAdActivityAsync(ReportAdActivityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ReportAdActivityResult> waiter;
            waiter = new PlayFabResult<ReportAdActivityResult>();
            ReportAdActivity(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> ReportDeviceInfoAsync(DeviceInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            ReportDeviceInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ReportPlayerClientResult>> ReportPlayerAsync(ReportPlayerClientRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ReportPlayerClientResult> waiter;
            waiter = new PlayFabResult<ReportPlayerClientResult>();
            ReportPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RestoreIOSPurchasesResult>> RestoreIOSPurchasesAsync(RestoreIOSPurchasesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RestoreIOSPurchasesResult> waiter;
            waiter = new PlayFabResult<RestoreIOSPurchasesResult>();
            RestoreIOSPurchases(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RewardAdActivityResult>> RewardAdActivityAsync(RewardAdActivityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RewardAdActivityResult> waiter;
            waiter = new PlayFabResult<RewardAdActivityResult>();
            RewardAdActivity(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendAccountRecoveryEmailResult> waiter;
            waiter = new PlayFabResult<SendAccountRecoveryEmailResult>();
            SendAccountRecoveryEmail(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetFriendTagsResult>> SetFriendTagsAsync(SetFriendTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetFriendTagsResult> waiter;
            waiter = new PlayFabResult<SetFriendTagsResult>();
            SetFriendTags(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPlayerSecretResult> waiter;
            waiter = new PlayFabResult<SetPlayerSecretResult>();
            SetPlayerSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<StartGameResult>> StartGameAsync(StartGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<StartGameResult> waiter;
            waiter = new PlayFabResult<StartGameResult>();
            StartGame(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<StartPurchaseResult>> StartPurchaseAsync(StartPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<StartPurchaseResult> waiter;
            waiter = new PlayFabResult<StartPurchaseResult>();
            StartPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            SubtractUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkAndroidDeviceIDResult>> UnlinkAndroidDeviceIDAsync(UnlinkAndroidDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkAndroidDeviceIDResult> waiter;
            waiter = new PlayFabResult<UnlinkAndroidDeviceIDResult>();
            UnlinkAndroidDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UnlinkAppleAsync(UnlinkAppleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UnlinkApple(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkCustomIDResult>> UnlinkCustomIDAsync(UnlinkCustomIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkCustomIDResult> waiter;
            waiter = new PlayFabResult<UnlinkCustomIDResult>();
            UnlinkCustomID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkFacebookAccountResult>> UnlinkFacebookAccountAsync(UnlinkFacebookAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkFacebookAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkFacebookAccountResult>();
            UnlinkFacebookAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkFacebookInstantGamesIdResult>> UnlinkFacebookInstantGamesIdAsync(UnlinkFacebookInstantGamesIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkFacebookInstantGamesIdResult> waiter;
            waiter = new PlayFabResult<UnlinkFacebookInstantGamesIdResult>();
            UnlinkFacebookInstantGamesId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkGameCenterAccountResult>> UnlinkGameCenterAccountAsync(UnlinkGameCenterAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkGameCenterAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkGameCenterAccountResult>();
            UnlinkGameCenterAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkGoogleAccountResult>> UnlinkGoogleAccountAsync(UnlinkGoogleAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkGoogleAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkGoogleAccountResult>();
            UnlinkGoogleAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkIOSDeviceIDResult>> UnlinkIOSDeviceIDAsync(UnlinkIOSDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkIOSDeviceIDResult> waiter;
            waiter = new PlayFabResult<UnlinkIOSDeviceIDResult>();
            UnlinkIOSDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkKongregateAccountResult>> UnlinkKongregateAsync(UnlinkKongregateAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkKongregateAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkKongregateAccountResult>();
            UnlinkKongregate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UnlinkNintendoServiceAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkNintendoSwitchDeviceIdResult>> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkNintendoSwitchDeviceIdResult> waiter;
            waiter = new PlayFabResult<UnlinkNintendoSwitchDeviceIdResult>();
            UnlinkNintendoSwitchDeviceId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UnlinkOpenIdConnectAsync(UnlinkOpenIdConnectRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UnlinkOpenIdConnect(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkPSNAccountResult>> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkPSNAccountResult>();
            UnlinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkSteamAccountResult>> UnlinkSteamAccountAsync(UnlinkSteamAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkSteamAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkSteamAccountResult>();
            UnlinkSteamAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkTwitchAccountResult>> UnlinkTwitchAsync(UnlinkTwitchAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkTwitchAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkTwitchAccountResult>();
            UnlinkTwitch(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkXboxAccountResult>> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkXboxAccountResult>();
            UnlinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            UnlockContainerInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItemAsync(UnlockContainerItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            UnlockContainerItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UpdateAvatarUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterDataAsync(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            UpdateCharacterData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterStatisticsResult>();
            UpdateCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerStatisticsResult>();
            UpdatePlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<UpdateSharedGroupDataResult>();
            UpdateSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserTitleDisplayNameResult> waiter;
            waiter = new PlayFabResult<UpdateUserTitleDisplayNameResult>();
            UpdateUserTitleDisplayName(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateAmazonReceiptResult>> ValidateAmazonIAPReceiptAsync(ValidateAmazonReceiptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateAmazonReceiptResult> waiter;
            waiter = new PlayFabResult<ValidateAmazonReceiptResult>();
            ValidateAmazonIAPReceipt(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateGooglePlayPurchaseResult>> ValidateGooglePlayPurchaseAsync(ValidateGooglePlayPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateGooglePlayPurchaseResult> waiter;
            waiter = new PlayFabResult<ValidateGooglePlayPurchaseResult>();
            ValidateGooglePlayPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateIOSReceiptResult>> ValidateIOSReceiptAsync(ValidateIOSReceiptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateIOSReceiptResult> waiter;
            waiter = new PlayFabResult<ValidateIOSReceiptResult>();
            ValidateIOSReceipt(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateWindowsReceiptResult>> ValidateWindowsStoreReceiptAsync(ValidateWindowsReceiptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateWindowsReceiptResult> waiter;
            waiter = new PlayFabResult<ValidateWindowsReceiptResult>();
            ValidateWindowsStoreReceipt(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteCharacterEventAsync(WriteClientCharacterEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            WriteCharacterEvent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WritePlayerEventAsync(WriteClientPlayerEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            WritePlayerEvent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteTitleEventAsync(WriteTitleEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            WriteTitleEvent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
