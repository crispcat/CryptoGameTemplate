using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if !DISABLE_PLAYFABCLIENT_API && !DISABLE_PLAYFAB_STATIC_API
using PlayFab.ClientModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static class PlayFabClientAPIAsync
    {
        #if !DISABLE_PLAYFABCLIENT_API && !DISABLE_PLAYFAB_STATIC_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<AcceptTradeResponse>> AcceptTrade(AcceptTradeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AcceptTradeResponse> waiter;
            waiter = new PlayFabResult<AcceptTradeResponse>();
            PlayFabClientAPI.AcceptTrade(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddFriendResult>> AddFriend(AddFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddFriendResult> waiter;
            waiter = new PlayFabResult<AddFriendResult>();
            PlayFabClientAPI.AddFriend(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddGenericIDResult>> AddGenericID(AddGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddGenericIDResult> waiter;
            waiter = new PlayFabResult<AddGenericIDResult>();
            PlayFabClientAPI.AddGenericID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddOrUpdateContactEmailResult>> AddOrUpdateContactEmail(AddOrUpdateContactEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddOrUpdateContactEmailResult> waiter;
            waiter = new PlayFabResult<AddOrUpdateContactEmailResult>();
            PlayFabClientAPI.AddOrUpdateContactEmail(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembers(AddSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<AddSharedGroupMembersResult>();
            PlayFabClientAPI.AddSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddUsernamePasswordResult>> AddUsernamePassword(AddUsernamePasswordRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddUsernamePasswordResult> waiter;
            waiter = new PlayFabResult<AddUsernamePasswordResult>();
            PlayFabClientAPI.AddUsernamePassword(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrency(AddUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            PlayFabClientAPI.AddUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AndroidDevicePushNotificationRegistrationResult>> AndroidDevicePushNotificationRegistration(AndroidDevicePushNotificationRegistrationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AndroidDevicePushNotificationRegistrationResult> waiter;
            waiter = new PlayFabResult<AndroidDevicePushNotificationRegistrationResult>();
            PlayFabClientAPI.AndroidDevicePushNotificationRegistration(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AttributeInstallResult>> AttributeInstall(AttributeInstallRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AttributeInstallResult> waiter;
            waiter = new PlayFabResult<AttributeInstallResult>();
            PlayFabClientAPI.AttributeInstall(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CancelTradeResponse>> CancelTrade(CancelTradeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CancelTradeResponse> waiter;
            waiter = new PlayFabResult<CancelTradeResponse>();
            PlayFabClientAPI.CancelTrade(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConfirmPurchaseResult>> ConfirmPurchase(ConfirmPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConfirmPurchaseResult> waiter;
            waiter = new PlayFabResult<ConfirmPurchaseResult>();
            PlayFabClientAPI.ConfirmPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeItemResult>> ConsumeItem(ConsumeItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeItemResult> waiter;
            waiter = new PlayFabResult<ConsumeItemResult>();
            PlayFabClientAPI.ConsumeItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse>> ConsumeMicrosoftStoreEntitlements(ConsumeMicrosoftStoreEntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse> waiter;
            waiter = new PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse>();
            PlayFabClientAPI.ConsumeMicrosoftStoreEntitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumePS5EntitlementsResult>> ConsumePS5Entitlements(ConsumePS5EntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumePS5EntitlementsResult> waiter;
            waiter = new PlayFabResult<ConsumePS5EntitlementsResult>();
            PlayFabClientAPI.ConsumePS5Entitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumePSNEntitlementsResult>> ConsumePSNEntitlements(ConsumePSNEntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumePSNEntitlementsResult> waiter;
            waiter = new PlayFabResult<ConsumePSNEntitlementsResult>();
            PlayFabClientAPI.ConsumePSNEntitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ConsumeXboxEntitlementsResult>> ConsumeXboxEntitlements(ConsumeXboxEntitlementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ConsumeXboxEntitlementsResult> waiter;
            waiter = new PlayFabResult<ConsumeXboxEntitlementsResult>();
            PlayFabClientAPI.ConsumeXboxEntitlements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroup(CreateSharedGroupRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateSharedGroupResult> waiter;
            waiter = new PlayFabResult<CreateSharedGroupResult>();
            PlayFabClientAPI.CreateSharedGroup(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScript(ExecuteCloudScriptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ExecuteCloudScriptResult> waiter;
            waiter = new PlayFabResult<ExecuteCloudScriptResult>();
            PlayFabClientAPI.ExecuteCloudScript(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAccountInfoResult>> GetAccountInfo(GetAccountInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAccountInfoResult> waiter;
            waiter = new PlayFabResult<GetAccountInfoResult>();
            PlayFabClientAPI.GetAccountInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAdPlacementsResult>> GetAdPlacements(GetAdPlacementsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAdPlacementsResult> waiter;
            waiter = new PlayFabResult<GetAdPlacementsResult>();
            PlayFabClientAPI.GetAdPlacements(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListUsersCharactersResult>> GetAllUsersCharacters(ListUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListUsersCharactersResult> waiter;
            waiter = new PlayFabResult<ListUsersCharactersResult>();
            PlayFabClientAPI.GetAllUsersCharacters(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItems(GetCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCatalogItemsResult> waiter;
            waiter = new PlayFabResult<GetCatalogItemsResult>();
            PlayFabClientAPI.GetCatalogItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterData(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            PlayFabClientAPI.GetCharacterData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterInventoryResult>> GetCharacterInventory(GetCharacterInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterInventoryResult> waiter;
            waiter = new PlayFabResult<GetCharacterInventoryResult>();
            PlayFabClientAPI.GetCharacterInventory(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboard(GetCharacterLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetCharacterLeaderboardResult>();
            PlayFabClientAPI.GetCharacterLeaderboard(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterReadOnlyData(GetCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterDataResult> waiter;
            waiter = new PlayFabResult<GetCharacterDataResult>();
            PlayFabClientAPI.GetCharacterReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCharacterStatisticsResult>> GetCharacterStatistics(GetCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<GetCharacterStatisticsResult>();
            PlayFabClientAPI.GetCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentDownloadUrlResult>> GetContentDownloadUrl(GetContentDownloadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentDownloadUrlResult> waiter;
            waiter = new PlayFabResult<GetContentDownloadUrlResult>();
            PlayFabClientAPI.GetContentDownloadUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CurrentGamesResult>> GetCurrentGames(CurrentGamesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CurrentGamesResult> waiter;
            waiter = new PlayFabResult<CurrentGamesResult>();
            PlayFabClientAPI.GetCurrentGames(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboard(GetFriendLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            PlayFabClientAPI.GetFriendLeaderboard(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetFriendLeaderboardAroundPlayerResult>> GetFriendLeaderboardAroundPlayer(GetFriendLeaderboardAroundPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetFriendLeaderboardAroundPlayerResult> waiter;
            waiter = new PlayFabResult<GetFriendLeaderboardAroundPlayerResult>();
            PlayFabClientAPI.GetFriendLeaderboardAroundPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetFriendsListResult>> GetFriendsList(GetFriendsListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetFriendsListResult> waiter;
            waiter = new PlayFabResult<GetFriendsListResult>();
            PlayFabClientAPI.GetFriendsList(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GameServerRegionsResult>> GetGameServerRegions(GameServerRegionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GameServerRegionsResult> waiter;
            waiter = new PlayFabResult<GameServerRegionsResult>();
            PlayFabClientAPI.GetGameServerRegions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboard(GetLeaderboardRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardResult>();
            PlayFabClientAPI.GetLeaderboard(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacter(GetLeaderboardAroundCharacterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundCharacterResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundCharacterResult>();
            PlayFabClientAPI.GetLeaderboardAroundCharacter(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardAroundPlayerResult>> GetLeaderboardAroundPlayer(GetLeaderboardAroundPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardAroundPlayerResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardAroundPlayerResult>();
            PlayFabClientAPI.GetLeaderboardAroundPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharacters(GetLeaderboardForUsersCharactersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetLeaderboardForUsersCharactersResult> waiter;
            waiter = new PlayFabResult<GetLeaderboardForUsersCharactersResult>();
            PlayFabClientAPI.GetLeaderboardForUserCharacters(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPaymentTokenResult>> GetPaymentToken(GetPaymentTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPaymentTokenResult> waiter;
            waiter = new PlayFabResult<GetPaymentTokenResult>();
            PlayFabClientAPI.GetPaymentToken(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPhotonAuthenticationTokenResult>> GetPhotonAuthenticationToken(GetPhotonAuthenticationTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPhotonAuthenticationTokenResult> waiter;
            waiter = new PlayFabResult<GetPhotonAuthenticationTokenResult>();
            PlayFabClientAPI.GetPhotonAuthenticationToken(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfo(GetPlayerCombinedInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerCombinedInfoResult> waiter;
            waiter = new PlayFabResult<GetPlayerCombinedInfoResult>();
            PlayFabClientAPI.GetPlayerCombinedInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfile(GetPlayerProfileRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerProfileResult> waiter;
            waiter = new PlayFabResult<GetPlayerProfileResult>();
            PlayFabClientAPI.GetPlayerProfile(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegments(GetPlayerSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSegmentsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSegmentsResult>();
            PlayFabClientAPI.GetPlayerSegments(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatistics(GetPlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticsResult>();
            PlayFabClientAPI.GetPlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersions(GetPlayerStatisticVersionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticVersionsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticVersionsResult>();
            PlayFabClientAPI.GetPlayerStatisticVersions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTags(GetPlayerTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerTagsResult> waiter;
            waiter = new PlayFabResult<GetPlayerTagsResult>();
            PlayFabClientAPI.GetPlayerTags(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerTradesResponse>> GetPlayerTrades(GetPlayerTradesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerTradesResponse> waiter;
            waiter = new PlayFabResult<GetPlayerTradesResponse>();
            PlayFabClientAPI.GetPlayerTrades(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDs(GetPlayFabIDsFromFacebookIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromFacebookIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> GetPlayFabIDsFromFacebookInstantGamesIds(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromFacebookInstantGamesIds(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult>> GetPlayFabIDsFromGameCenterIDs(GetPlayFabIDsFromGameCenterIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromGameCenterIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDs(GetPlayFabIDsFromGenericIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGenericIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGenericIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromGenericIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromGoogleIDsResult>> GetPlayFabIDsFromGoogleIDs(GetPlayFabIDsFromGoogleIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromGoogleIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromGoogleIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromGoogleIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromKongregateIDsResult>> GetPlayFabIDsFromKongregateIDs(GetPlayFabIDsFromKongregateIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromKongregateIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromKongregateIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromKongregateIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> GetPlayFabIDsFromNintendoSwitchDeviceIds(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromNintendoSwitchDeviceIds(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDs(GetPlayFabIDsFromPSNAccountIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromPSNAccountIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDs(GetPlayFabIDsFromSteamIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromSteamIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromSteamIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromSteamIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromTwitchIDsResult>> GetPlayFabIDsFromTwitchIDs(GetPlayFabIDsFromTwitchIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromTwitchIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromTwitchIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromTwitchIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDs(GetPlayFabIDsFromXboxLiveIDsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> waiter;
            waiter = new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>();
            PlayFabClientAPI.GetPlayFabIDsFromXboxLiveIDs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherData(GetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPublisherDataResult> waiter;
            waiter = new PlayFabResult<GetPublisherDataResult>();
            PlayFabClientAPI.GetPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPurchaseResult>> GetPurchase(GetPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPurchaseResult> waiter;
            waiter = new PlayFabResult<GetPurchaseResult>();
            PlayFabClientAPI.GetPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupData(GetSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<GetSharedGroupDataResult>();
            PlayFabClientAPI.GetSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItems(GetStoreItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetStoreItemsResult> waiter;
            waiter = new PlayFabResult<GetStoreItemsResult>();
            PlayFabClientAPI.GetStoreItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTimeResult>> GetTime(GetTimeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTimeResult> waiter;
            waiter = new PlayFabResult<GetTimeResult>();
            PlayFabClientAPI.GetTime(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleData(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            PlayFabClientAPI.GetTitleData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleNewsResult>> GetTitleNews(GetTitleNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleNewsResult> waiter;
            waiter = new PlayFabResult<GetTitleNewsResult>();
            PlayFabClientAPI.GetTitleNews(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitlePublicKeyResult>> GetTitlePublicKey(GetTitlePublicKeyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitlePublicKeyResult> waiter;
            waiter = new PlayFabResult<GetTitlePublicKeyResult>();
            PlayFabClientAPI.GetTitlePublicKey(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTradeStatusResponse>> GetTradeStatus(GetTradeStatusRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTradeStatusResponse> waiter;
            waiter = new PlayFabResult<GetTradeStatusResponse>();
            PlayFabClientAPI.GetTradeStatus(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabClientAPI.GetUserData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventory(GetUserInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserInventoryResult> waiter;
            waiter = new PlayFabResult<GetUserInventoryResult>();
            PlayFabClientAPI.GetUserInventory(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabClientAPI.GetUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabClientAPI.GetUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabClientAPI.GetUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantCharacterToUserResult>> GrantCharacterToUser(GrantCharacterToUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantCharacterToUserResult> waiter;
            waiter = new PlayFabResult<GrantCharacterToUserResult>();
            PlayFabClientAPI.GrantCharacterToUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkAndroidDeviceIDResult>> LinkAndroidDeviceID(LinkAndroidDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkAndroidDeviceIDResult> waiter;
            waiter = new PlayFabResult<LinkAndroidDeviceIDResult>();
            PlayFabClientAPI.LinkAndroidDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> LinkApple(LinkAppleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            PlayFabClientAPI.LinkApple(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkCustomIDResult>> LinkCustomID(LinkCustomIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkCustomIDResult> waiter;
            waiter = new PlayFabResult<LinkCustomIDResult>();
            PlayFabClientAPI.LinkCustomID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkFacebookAccountResult>> LinkFacebookAccount(LinkFacebookAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkFacebookAccountResult> waiter;
            waiter = new PlayFabResult<LinkFacebookAccountResult>();
            PlayFabClientAPI.LinkFacebookAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkFacebookInstantGamesIdResult>> LinkFacebookInstantGamesId(LinkFacebookInstantGamesIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkFacebookInstantGamesIdResult> waiter;
            waiter = new PlayFabResult<LinkFacebookInstantGamesIdResult>();
            PlayFabClientAPI.LinkFacebookInstantGamesId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkGameCenterAccountResult>> LinkGameCenterAccount(LinkGameCenterAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkGameCenterAccountResult> waiter;
            waiter = new PlayFabResult<LinkGameCenterAccountResult>();
            PlayFabClientAPI.LinkGameCenterAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkGoogleAccountResult>> LinkGoogleAccount(LinkGoogleAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkGoogleAccountResult> waiter;
            waiter = new PlayFabResult<LinkGoogleAccountResult>();
            PlayFabClientAPI.LinkGoogleAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkIOSDeviceIDResult>> LinkIOSDeviceID(LinkIOSDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkIOSDeviceIDResult> waiter;
            waiter = new PlayFabResult<LinkIOSDeviceIDResult>();
            PlayFabClientAPI.LinkIOSDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkKongregateAccountResult>> LinkKongregate(LinkKongregateAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkKongregateAccountResult> waiter;
            waiter = new PlayFabResult<LinkKongregateAccountResult>();
            PlayFabClientAPI.LinkKongregate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> LinkNintendoServiceAccount(LinkNintendoServiceAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            PlayFabClientAPI.LinkNintendoServiceAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkNintendoSwitchDeviceIdResult>> LinkNintendoSwitchDeviceId(LinkNintendoSwitchDeviceIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkNintendoSwitchDeviceIdResult> waiter;
            waiter = new PlayFabResult<LinkNintendoSwitchDeviceIdResult>();
            PlayFabClientAPI.LinkNintendoSwitchDeviceId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResult>> LinkOpenIdConnect(LinkOpenIdConnectRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResult> waiter;
            waiter = new PlayFabResult<EmptyResult>();
            PlayFabClientAPI.LinkOpenIdConnect(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkPSNAccountResult>> LinkPSNAccount(LinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<LinkPSNAccountResult>();
            PlayFabClientAPI.LinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkSteamAccountResult>> LinkSteamAccount(LinkSteamAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkSteamAccountResult> waiter;
            waiter = new PlayFabResult<LinkSteamAccountResult>();
            PlayFabClientAPI.LinkSteamAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkTwitchAccountResult>> LinkTwitch(LinkTwitchAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkTwitchAccountResult> waiter;
            waiter = new PlayFabResult<LinkTwitchAccountResult>();
            PlayFabClientAPI.LinkTwitch(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxAccount(LinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<LinkXboxAccountResult>();
            PlayFabClientAPI.LinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithAndroidDeviceID(LoginWithAndroidDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithAndroidDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithApple(LoginWithAppleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithApple(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithCustomID(LoginWithCustomIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithCustomID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithEmailAddress(LoginWithEmailAddressRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithEmailAddress(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithFacebook(LoginWithFacebookRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithFacebook(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithFacebookInstantGamesId(LoginWithFacebookInstantGamesIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithFacebookInstantGamesId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithGameCenter(LoginWithGameCenterRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithGameCenter(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithGoogleAccount(LoginWithGoogleAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithGoogleAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithIOSDeviceID(LoginWithIOSDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithIOSDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithKongregate(LoginWithKongregateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithKongregate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithNintendoServiceAccount(LoginWithNintendoServiceAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithNintendoServiceAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithNintendoSwitchDeviceId(LoginWithNintendoSwitchDeviceIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithNintendoSwitchDeviceId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithOpenIdConnect(LoginWithOpenIdConnectRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithOpenIdConnect(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithPlayFab(LoginWithPlayFabRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithPlayFab(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithPSN(LoginWithPSNRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithPSN(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithSteam(LoginWithSteamRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithSteam(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithTwitch(LoginWithTwitchRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithTwitch(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LoginResult>> LoginWithXbox(LoginWithXboxRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LoginResult> waiter;
            waiter = new PlayFabResult<LoginResult>();
            PlayFabClientAPI.LoginWithXbox(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<MatchmakeResult>> Matchmake(MatchmakeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<MatchmakeResult> waiter;
            waiter = new PlayFabResult<MatchmakeResult>();
            PlayFabClientAPI.Matchmake(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<OpenTradeResponse>> OpenTrade(OpenTradeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<OpenTradeResponse> waiter;
            waiter = new PlayFabResult<OpenTradeResponse>();
            PlayFabClientAPI.OpenTrade(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PayForPurchaseResult>> PayForPurchase(PayForPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PayForPurchaseResult> waiter;
            waiter = new PlayFabResult<PayForPurchaseResult>();
            PlayFabClientAPI.PayForPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<PurchaseItemResult>> PurchaseItem(PurchaseItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<PurchaseItemResult> waiter;
            waiter = new PlayFabResult<PurchaseItemResult>();
            PlayFabClientAPI.PurchaseItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RedeemCouponResult>> RedeemCoupon(RedeemCouponRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RedeemCouponResult> waiter;
            waiter = new PlayFabResult<RedeemCouponResult>();
            PlayFabClientAPI.RedeemCoupon(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> RefreshPSNAuthToken(RefreshPSNAuthTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabClientAPI.RefreshPSNAuthToken(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RegisterForIOSPushNotificationResult>> RegisterForIOSPushNotification(RegisterForIOSPushNotificationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RegisterForIOSPushNotificationResult> waiter;
            waiter = new PlayFabResult<RegisterForIOSPushNotificationResult>();
            PlayFabClientAPI.RegisterForIOSPushNotification(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RegisterPlayFabUserResult>> RegisterPlayFabUser(RegisterPlayFabUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RegisterPlayFabUserResult> waiter;
            waiter = new PlayFabResult<RegisterPlayFabUserResult>();
            PlayFabClientAPI.RegisterPlayFabUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveContactEmailResult>> RemoveContactEmail(RemoveContactEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveContactEmailResult> waiter;
            waiter = new PlayFabResult<RemoveContactEmailResult>();
            PlayFabClientAPI.RemoveContactEmail(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveFriendResult>> RemoveFriend(RemoveFriendRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveFriendResult> waiter;
            waiter = new PlayFabResult<RemoveFriendResult>();
            PlayFabClientAPI.RemoveFriend(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveGenericIDResult>> RemoveGenericID(RemoveGenericIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveGenericIDResult> waiter;
            waiter = new PlayFabResult<RemoveGenericIDResult>();
            PlayFabClientAPI.RemoveGenericID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembers(RemoveSharedGroupMembersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveSharedGroupMembersResult> waiter;
            waiter = new PlayFabResult<RemoveSharedGroupMembersResult>();
            PlayFabClientAPI.RemoveSharedGroupMembers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ReportAdActivityResult>> ReportAdActivity(ReportAdActivityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ReportAdActivityResult> waiter;
            waiter = new PlayFabResult<ReportAdActivityResult>();
            PlayFabClientAPI.ReportAdActivity(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> ReportDeviceInfo(DeviceInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabClientAPI.ReportDeviceInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ReportPlayerClientResult>> ReportPlayer(ReportPlayerClientRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ReportPlayerClientResult> waiter;
            waiter = new PlayFabResult<ReportPlayerClientResult>();
            PlayFabClientAPI.ReportPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RestoreIOSPurchasesResult>> RestoreIOSPurchases(RestoreIOSPurchasesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RestoreIOSPurchasesResult> waiter;
            waiter = new PlayFabResult<RestoreIOSPurchasesResult>();
            PlayFabClientAPI.RestoreIOSPurchases(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RewardAdActivityResult>> RewardAdActivity(RewardAdActivityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RewardAdActivityResult> waiter;
            waiter = new PlayFabResult<RewardAdActivityResult>();
            PlayFabClientAPI.RewardAdActivity(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmail(SendAccountRecoveryEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendAccountRecoveryEmailResult> waiter;
            waiter = new PlayFabResult<SendAccountRecoveryEmailResult>();
            PlayFabClientAPI.SendAccountRecoveryEmail(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetFriendTagsResult>> SetFriendTags(SetFriendTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetFriendTagsResult> waiter;
            waiter = new PlayFabResult<SetFriendTagsResult>();
            PlayFabClientAPI.SetFriendTags(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecret(SetPlayerSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPlayerSecretResult> waiter;
            waiter = new PlayFabResult<SetPlayerSecretResult>();
            PlayFabClientAPI.SetPlayerSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<StartGameResult>> StartGame(StartGameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<StartGameResult> waiter;
            waiter = new PlayFabResult<StartGameResult>();
            PlayFabClientAPI.StartGame(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<StartPurchaseResult>> StartPurchase(StartPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<StartPurchaseResult> waiter;
            waiter = new PlayFabResult<StartPurchaseResult>();
            PlayFabClientAPI.StartPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            PlayFabClientAPI.SubtractUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkAndroidDeviceIDResult>> UnlinkAndroidDeviceID(UnlinkAndroidDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkAndroidDeviceIDResult> waiter;
            waiter = new PlayFabResult<UnlinkAndroidDeviceIDResult>();
            PlayFabClientAPI.UnlinkAndroidDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UnlinkApple(UnlinkAppleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabClientAPI.UnlinkApple(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkCustomIDResult>> UnlinkCustomID(UnlinkCustomIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkCustomIDResult> waiter;
            waiter = new PlayFabResult<UnlinkCustomIDResult>();
            PlayFabClientAPI.UnlinkCustomID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkFacebookAccountResult>> UnlinkFacebookAccount(UnlinkFacebookAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkFacebookAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkFacebookAccountResult>();
            PlayFabClientAPI.UnlinkFacebookAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkFacebookInstantGamesIdResult>> UnlinkFacebookInstantGamesId(UnlinkFacebookInstantGamesIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkFacebookInstantGamesIdResult> waiter;
            waiter = new PlayFabResult<UnlinkFacebookInstantGamesIdResult>();
            PlayFabClientAPI.UnlinkFacebookInstantGamesId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkGameCenterAccountResult>> UnlinkGameCenterAccount(UnlinkGameCenterAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkGameCenterAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkGameCenterAccountResult>();
            PlayFabClientAPI.UnlinkGameCenterAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkGoogleAccountResult>> UnlinkGoogleAccount(UnlinkGoogleAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkGoogleAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkGoogleAccountResult>();
            PlayFabClientAPI.UnlinkGoogleAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkIOSDeviceIDResult>> UnlinkIOSDeviceID(UnlinkIOSDeviceIDRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkIOSDeviceIDResult> waiter;
            waiter = new PlayFabResult<UnlinkIOSDeviceIDResult>();
            PlayFabClientAPI.UnlinkIOSDeviceID(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkKongregateAccountResult>> UnlinkKongregate(UnlinkKongregateAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkKongregateAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkKongregateAccountResult>();
            PlayFabClientAPI.UnlinkKongregate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UnlinkNintendoServiceAccount(UnlinkNintendoServiceAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabClientAPI.UnlinkNintendoServiceAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkNintendoSwitchDeviceIdResult>> UnlinkNintendoSwitchDeviceId(UnlinkNintendoSwitchDeviceIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkNintendoSwitchDeviceIdResult> waiter;
            waiter = new PlayFabResult<UnlinkNintendoSwitchDeviceIdResult>();
            PlayFabClientAPI.UnlinkNintendoSwitchDeviceId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UnlinkOpenIdConnect(UnlinkOpenIdConnectRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabClientAPI.UnlinkOpenIdConnect(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkPSNAccountResult>> UnlinkPSNAccount(UnlinkPSNAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkPSNAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkPSNAccountResult>();
            PlayFabClientAPI.UnlinkPSNAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkSteamAccountResult>> UnlinkSteamAccount(UnlinkSteamAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkSteamAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkSteamAccountResult>();
            PlayFabClientAPI.UnlinkSteamAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkTwitchAccountResult>> UnlinkTwitch(UnlinkTwitchAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkTwitchAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkTwitchAccountResult>();
            PlayFabClientAPI.UnlinkTwitch(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlinkXboxAccountResult>> UnlinkXboxAccount(UnlinkXboxAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlinkXboxAccountResult> waiter;
            waiter = new PlayFabResult<UnlinkXboxAccountResult>();
            PlayFabClientAPI.UnlinkXboxAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerInstance(UnlockContainerInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            PlayFabClientAPI.UnlockContainerInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItem(UnlockContainerItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UnlockContainerItemResult> waiter;
            waiter = new PlayFabResult<UnlockContainerItemResult>();
            PlayFabClientAPI.UnlockContainerItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateAvatarUrl(UpdateAvatarUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabClientAPI.UpdateAvatarUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterData(UpdateCharacterDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterDataResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterDataResult>();
            PlayFabClientAPI.UpdateCharacterData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatistics(UpdateCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdateCharacterStatisticsResult>();
            PlayFabClientAPI.UpdateCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatistics(UpdatePlayerStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerStatisticsResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerStatisticsResult>();
            PlayFabClientAPI.UpdatePlayerStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupData(UpdateSharedGroupDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateSharedGroupDataResult> waiter;
            waiter = new PlayFabResult<UpdateSharedGroupDataResult>();
            PlayFabClientAPI.UpdateSharedGroupData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabClientAPI.UpdateUserData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabClientAPI.UpdateUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayName(UpdateUserTitleDisplayNameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserTitleDisplayNameResult> waiter;
            waiter = new PlayFabResult<UpdateUserTitleDisplayNameResult>();
            PlayFabClientAPI.UpdateUserTitleDisplayName(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateAmazonReceiptResult>> ValidateAmazonIAPReceipt(ValidateAmazonReceiptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateAmazonReceiptResult> waiter;
            waiter = new PlayFabResult<ValidateAmazonReceiptResult>();
            PlayFabClientAPI.ValidateAmazonIAPReceipt(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateGooglePlayPurchaseResult>> ValidateGooglePlayPurchase(ValidateGooglePlayPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateGooglePlayPurchaseResult> waiter;
            waiter = new PlayFabResult<ValidateGooglePlayPurchaseResult>();
            PlayFabClientAPI.ValidateGooglePlayPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateIOSReceiptResult>> ValidateIOSReceipt(ValidateIOSReceiptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateIOSReceiptResult> waiter;
            waiter = new PlayFabResult<ValidateIOSReceiptResult>();
            PlayFabClientAPI.ValidateIOSReceipt(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ValidateWindowsReceiptResult>> ValidateWindowsStoreReceipt(ValidateWindowsReceiptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ValidateWindowsReceiptResult> waiter;
            waiter = new PlayFabResult<ValidateWindowsReceiptResult>();
            PlayFabClientAPI.ValidateWindowsStoreReceipt(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteCharacterEvent(WriteClientCharacterEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            PlayFabClientAPI.WriteCharacterEvent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WritePlayerEvent(WriteClientPlayerEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            PlayFabClientAPI.WritePlayerEvent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<WriteEventResponse>> WriteTitleEvent(WriteTitleEventRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<WriteEventResponse> waiter;
            waiter = new PlayFabResult<WriteEventResponse>();
            PlayFabClientAPI.WriteTitleEvent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
