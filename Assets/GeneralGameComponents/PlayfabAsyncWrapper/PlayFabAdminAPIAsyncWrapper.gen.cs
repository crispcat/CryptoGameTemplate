using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if ENABLE_PLAYFABADMIN_API && !DISABLE_PLAYFAB_STATIC_API
using PlayFab.AdminModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static class PlayFabAdminAPIAsync
    {
        #if ENABLE_PLAYFABADMIN_API && !DISABLE_PLAYFAB_STATIC_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<EmptyResponse>> AbortTaskInstance(AbortTaskInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabAdminAPI.AbortTaskInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddLocalizedNewsResult>> AddLocalizedNews(AddLocalizedNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddLocalizedNewsResult> waiter;
            waiter = new PlayFabResult<AddLocalizedNewsResult>();
            PlayFabAdminAPI.AddLocalizedNews(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddNewsResult>> AddNews(AddNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddNewsResult> waiter;
            waiter = new PlayFabResult<AddNewsResult>();
            PlayFabAdminAPI.AddNews(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTag(AddPlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddPlayerTagResult> waiter;
            waiter = new PlayFabResult<AddPlayerTagResult>();
            PlayFabAdminAPI.AddPlayerTag(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddServerBuildResult>> AddServerBuild(AddServerBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddServerBuildResult> waiter;
            waiter = new PlayFabResult<AddServerBuildResult>();
            PlayFabAdminAPI.AddServerBuild(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrency(AddUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            PlayFabAdminAPI.AddUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BlankResult>> AddVirtualCurrencyTypes(AddVirtualCurrencyTypesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BlankResult> waiter;
            waiter = new PlayFabResult<BlankResult>();
            PlayFabAdminAPI.AddVirtualCurrencyTypes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BanUsersResult>> BanUsers(BanUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BanUsersResult> waiter;
            waiter = new PlayFabResult<BanUsersResult>();
            PlayFabAdminAPI.BanUsers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CheckLimitedEditionItemAvailabilityResult>> CheckLimitedEditionItemAvailability(CheckLimitedEditionItemAvailabilityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CheckLimitedEditionItemAvailabilityResult> waiter;
            waiter = new PlayFabResult<CheckLimitedEditionItemAvailabilityResult>();
            PlayFabAdminAPI.CheckLimitedEditionItemAvailability(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateTaskResult>> CreateActionsOnPlayersInSegmentTask(CreateActionsOnPlayerSegmentTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateTaskResult> waiter;
            waiter = new PlayFabResult<CreateTaskResult>();
            PlayFabAdminAPI.CreateActionsOnPlayersInSegmentTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateTaskResult>> CreateCloudScriptTask(CreateCloudScriptTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateTaskResult> waiter;
            waiter = new PlayFabResult<CreateTaskResult>();
            PlayFabAdminAPI.CreateCloudScriptTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateTaskResult>> CreateInsightsScheduledScalingTask(CreateInsightsScheduledScalingTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateTaskResult> waiter;
            waiter = new PlayFabResult<CreateTaskResult>();
            PlayFabAdminAPI.CreateInsightsScheduledScalingTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> CreateOpenIdConnection(CreateOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabAdminAPI.CreateOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreatePlayerSharedSecretResult>> CreatePlayerSharedSecret(CreatePlayerSharedSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreatePlayerSharedSecretResult> waiter;
            waiter = new PlayFabResult<CreatePlayerSharedSecretResult>();
            PlayFabAdminAPI.CreatePlayerSharedSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreatePlayerStatisticDefinitionResult>> CreatePlayerStatisticDefinition(CreatePlayerStatisticDefinitionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreatePlayerStatisticDefinitionResult> waiter;
            waiter = new PlayFabResult<CreatePlayerStatisticDefinitionResult>();
            PlayFabAdminAPI.CreatePlayerStatisticDefinition(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateSegmentResponse>> CreateSegment(CreateSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateSegmentResponse> waiter;
            waiter = new PlayFabResult<CreateSegmentResponse>();
            PlayFabAdminAPI.CreateSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BlankResult>> DeleteContent(DeleteContentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BlankResult> waiter;
            waiter = new PlayFabResult<BlankResult>();
            PlayFabAdminAPI.DeleteContent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteMasterPlayerAccountResult>> DeleteMasterPlayerAccount(DeleteMasterPlayerAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteMasterPlayerAccountResult> waiter;
            waiter = new PlayFabResult<DeleteMasterPlayerAccountResult>();
            PlayFabAdminAPI.DeleteMasterPlayerAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteOpenIdConnection(DeleteOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabAdminAPI.DeleteOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePlayerResult>> DeletePlayer(DeletePlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePlayerResult> waiter;
            waiter = new PlayFabResult<DeletePlayerResult>();
            PlayFabAdminAPI.DeletePlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePlayerSharedSecretResult>> DeletePlayerSharedSecret(DeletePlayerSharedSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePlayerSharedSecretResult> waiter;
            waiter = new PlayFabResult<DeletePlayerSharedSecretResult>();
            PlayFabAdminAPI.DeletePlayerSharedSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteSegmentsResponse>> DeleteSegment(DeleteSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteSegmentsResponse> waiter;
            waiter = new PlayFabResult<DeleteSegmentsResponse>();
            PlayFabAdminAPI.DeleteSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteStoreResult>> DeleteStore(DeleteStoreRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteStoreResult> waiter;
            waiter = new PlayFabResult<DeleteStoreResult>();
            PlayFabAdminAPI.DeleteStore(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteTask(DeleteTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabAdminAPI.DeleteTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteTitleResult>> DeleteTitle(DeleteTitleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteTitleResult> waiter;
            waiter = new PlayFabResult<DeleteTitleResult>();
            PlayFabAdminAPI.DeleteTitle(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteTitleDataOverrideResult>> DeleteTitleDataOverride(DeleteTitleDataOverrideRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteTitleDataOverrideResult> waiter;
            waiter = new PlayFabResult<DeleteTitleDataOverrideResult>();
            PlayFabAdminAPI.DeleteTitleDataOverride(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ExportMasterPlayerDataResult>> ExportMasterPlayerData(ExportMasterPlayerDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ExportMasterPlayerDataResult> waiter;
            waiter = new PlayFabResult<ExportMasterPlayerDataResult>();
            PlayFabAdminAPI.ExportMasterPlayerData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult>> GetActionsOnPlayersInSegmentTaskInstance(GetTaskInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult> waiter;
            waiter = new PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult>();
            PlayFabAdminAPI.GetActionsOnPlayersInSegmentTaskInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegments(GetAllSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAllSegmentsResult> waiter;
            waiter = new PlayFabResult<GetAllSegmentsResult>();
            PlayFabAdminAPI.GetAllSegments(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItems(GetCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCatalogItemsResult> waiter;
            waiter = new PlayFabResult<GetCatalogItemsResult>();
            PlayFabAdminAPI.GetCatalogItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCloudScriptRevisionResult>> GetCloudScriptRevision(GetCloudScriptRevisionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCloudScriptRevisionResult> waiter;
            waiter = new PlayFabResult<GetCloudScriptRevisionResult>();
            PlayFabAdminAPI.GetCloudScriptRevision(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCloudScriptTaskInstanceResult>> GetCloudScriptTaskInstance(GetTaskInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCloudScriptTaskInstanceResult> waiter;
            waiter = new PlayFabResult<GetCloudScriptTaskInstanceResult>();
            PlayFabAdminAPI.GetCloudScriptTaskInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCloudScriptVersionsResult>> GetCloudScriptVersions(GetCloudScriptVersionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCloudScriptVersionsResult> waiter;
            waiter = new PlayFabResult<GetCloudScriptVersionsResult>();
            PlayFabAdminAPI.GetCloudScriptVersions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentListResult>> GetContentList(GetContentListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentListResult> waiter;
            waiter = new PlayFabResult<GetContentListResult>();
            PlayFabAdminAPI.GetContentList(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentUploadUrlResult>> GetContentUploadUrl(GetContentUploadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentUploadUrlResult> waiter;
            waiter = new PlayFabResult<GetContentUploadUrlResult>();
            PlayFabAdminAPI.GetContentUploadUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetDataReportResult>> GetDataReport(GetDataReportRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetDataReportResult> waiter;
            waiter = new PlayFabResult<GetDataReportResult>();
            PlayFabAdminAPI.GetDataReport(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMatchmakerGameInfoResult>> GetMatchmakerGameInfo(GetMatchmakerGameInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMatchmakerGameInfoResult> waiter;
            waiter = new PlayFabResult<GetMatchmakerGameInfoResult>();
            PlayFabAdminAPI.GetMatchmakerGameInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMatchmakerGameModesResult>> GetMatchmakerGameModes(GetMatchmakerGameModesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMatchmakerGameModesResult> waiter;
            waiter = new PlayFabResult<GetMatchmakerGameModesResult>();
            PlayFabAdminAPI.GetMatchmakerGameModes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayedTitleListResult>> GetPlayedTitleList(GetPlayedTitleListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayedTitleListResult> waiter;
            waiter = new PlayFabResult<GetPlayedTitleListResult>();
            PlayFabAdminAPI.GetPlayedTitleList(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerIdFromAuthTokenResult>> GetPlayerIdFromAuthToken(GetPlayerIdFromAuthTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerIdFromAuthTokenResult> waiter;
            waiter = new PlayFabResult<GetPlayerIdFromAuthTokenResult>();
            PlayFabAdminAPI.GetPlayerIdFromAuthToken(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfile(GetPlayerProfileRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerProfileResult> waiter;
            waiter = new PlayFabResult<GetPlayerProfileResult>();
            PlayFabAdminAPI.GetPlayerProfile(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegments(GetPlayersSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSegmentsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSegmentsResult>();
            PlayFabAdminAPI.GetPlayerSegments(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerSharedSecretsResult>> GetPlayerSharedSecrets(GetPlayerSharedSecretsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSharedSecretsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSharedSecretsResult>();
            PlayFabAdminAPI.GetPlayerSharedSecrets(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegment(GetPlayersInSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayersInSegmentResult> waiter;
            waiter = new PlayFabResult<GetPlayersInSegmentResult>();
            PlayFabAdminAPI.GetPlayersInSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticDefinitionsResult>> GetPlayerStatisticDefinitions(GetPlayerStatisticDefinitionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticDefinitionsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticDefinitionsResult>();
            PlayFabAdminAPI.GetPlayerStatisticDefinitions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersions(GetPlayerStatisticVersionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticVersionsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticVersionsResult>();
            PlayFabAdminAPI.GetPlayerStatisticVersions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTags(GetPlayerTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerTagsResult> waiter;
            waiter = new PlayFabResult<GetPlayerTagsResult>();
            PlayFabAdminAPI.GetPlayerTags(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPolicyResponse>> GetPolicy(GetPolicyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPolicyResponse> waiter;
            waiter = new PlayFabResult<GetPolicyResponse>();
            PlayFabAdminAPI.GetPolicy(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherData(GetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPublisherDataResult> waiter;
            waiter = new PlayFabResult<GetPublisherDataResult>();
            PlayFabAdminAPI.GetPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTables(GetRandomResultTablesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetRandomResultTablesResult> waiter;
            waiter = new PlayFabResult<GetRandomResultTablesResult>();
            PlayFabAdminAPI.GetRandomResultTables(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetSegmentsResponse>> GetSegments(GetSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetSegmentsResponse> waiter;
            waiter = new PlayFabResult<GetSegmentsResponse>();
            PlayFabAdminAPI.GetSegments(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetServerBuildInfoResult>> GetServerBuildInfo(GetServerBuildInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetServerBuildInfoResult> waiter;
            waiter = new PlayFabResult<GetServerBuildInfoResult>();
            PlayFabAdminAPI.GetServerBuildInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetServerBuildUploadURLResult>> GetServerBuildUploadUrl(GetServerBuildUploadURLRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetServerBuildUploadURLResult> waiter;
            waiter = new PlayFabResult<GetServerBuildUploadURLResult>();
            PlayFabAdminAPI.GetServerBuildUploadUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItems(GetStoreItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetStoreItemsResult> waiter;
            waiter = new PlayFabResult<GetStoreItemsResult>();
            PlayFabAdminAPI.GetStoreItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTaskInstancesResult>> GetTaskInstances(GetTaskInstancesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTaskInstancesResult> waiter;
            waiter = new PlayFabResult<GetTaskInstancesResult>();
            PlayFabAdminAPI.GetTaskInstances(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTasksResult>> GetTasks(GetTasksRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTasksResult> waiter;
            waiter = new PlayFabResult<GetTasksResult>();
            PlayFabAdminAPI.GetTasks(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleData(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            PlayFabAdminAPI.GetTitleData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalData(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            PlayFabAdminAPI.GetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LookupUserAccountInfoResult>> GetUserAccountInfo(LookupUserAccountInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LookupUserAccountInfoResult> waiter;
            waiter = new PlayFabResult<LookupUserAccountInfoResult>();
            PlayFabAdminAPI.GetUserAccountInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserBansResult>> GetUserBans(GetUserBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserBansResult> waiter;
            waiter = new PlayFabResult<GetUserBansResult>();
            PlayFabAdminAPI.GetUserBans(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabAdminAPI.GetUserData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserInternalData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabAdminAPI.GetUserInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventory(GetUserInventoryRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserInventoryResult> waiter;
            waiter = new PlayFabResult<GetUserInventoryResult>();
            PlayFabAdminAPI.GetUserInventory(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabAdminAPI.GetUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabAdminAPI.GetUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabAdminAPI.GetUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyData(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            PlayFabAdminAPI.GetUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsers(GrantItemsToUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToUsersResult> waiter;
            waiter = new PlayFabResult<GrantItemsToUsersResult>();
            PlayFabAdminAPI.GrantItemsToUsers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<IncrementLimitedEditionItemAvailabilityResult>> IncrementLimitedEditionItemAvailability(IncrementLimitedEditionItemAvailabilityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<IncrementLimitedEditionItemAvailabilityResult> waiter;
            waiter = new PlayFabResult<IncrementLimitedEditionItemAvailabilityResult>();
            PlayFabAdminAPI.IncrementLimitedEditionItemAvailability(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<IncrementPlayerStatisticVersionResult>> IncrementPlayerStatisticVersion(IncrementPlayerStatisticVersionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<IncrementPlayerStatisticVersionResult> waiter;
            waiter = new PlayFabResult<IncrementPlayerStatisticVersionResult>();
            PlayFabAdminAPI.IncrementPlayerStatisticVersion(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListOpenIdConnectionResponse>> ListOpenIdConnection(ListOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListOpenIdConnectionResponse> waiter;
            waiter = new PlayFabResult<ListOpenIdConnectionResponse>();
            PlayFabAdminAPI.ListOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListBuildsResult>> ListServerBuilds(ListBuildsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListBuildsResult> waiter;
            waiter = new PlayFabResult<ListBuildsResult>();
            PlayFabAdminAPI.ListServerBuilds(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListVirtualCurrencyTypesResult>> ListVirtualCurrencyTypes(ListVirtualCurrencyTypesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListVirtualCurrencyTypesResult> waiter;
            waiter = new PlayFabResult<ListVirtualCurrencyTypesResult>();
            PlayFabAdminAPI.ListVirtualCurrencyTypes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyMatchmakerGameModesResult>> ModifyMatchmakerGameModes(ModifyMatchmakerGameModesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyMatchmakerGameModesResult> waiter;
            waiter = new PlayFabResult<ModifyMatchmakerGameModesResult>();
            PlayFabAdminAPI.ModifyMatchmakerGameModes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyServerBuildResult>> ModifyServerBuild(ModifyServerBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyServerBuildResult> waiter;
            waiter = new PlayFabResult<ModifyServerBuildResult>();
            PlayFabAdminAPI.ModifyServerBuild(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RefundPurchaseResponse>> RefundPurchase(RefundPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RefundPurchaseResponse> waiter;
            waiter = new PlayFabResult<RefundPurchaseResponse>();
            PlayFabAdminAPI.RefundPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTag(RemovePlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemovePlayerTagResult> waiter;
            waiter = new PlayFabResult<RemovePlayerTagResult>();
            PlayFabAdminAPI.RemovePlayerTag(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveServerBuildResult>> RemoveServerBuild(RemoveServerBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveServerBuildResult> waiter;
            waiter = new PlayFabResult<RemoveServerBuildResult>();
            PlayFabAdminAPI.RemoveServerBuild(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BlankResult>> RemoveVirtualCurrencyTypes(RemoveVirtualCurrencyTypesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BlankResult> waiter;
            waiter = new PlayFabResult<BlankResult>();
            PlayFabAdminAPI.RemoveVirtualCurrencyTypes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResetCharacterStatisticsResult>> ResetCharacterStatistics(ResetCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResetCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<ResetCharacterStatisticsResult>();
            PlayFabAdminAPI.ResetCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResetPasswordResult>> ResetPassword(ResetPasswordRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResetPasswordResult> waiter;
            waiter = new PlayFabResult<ResetPasswordResult>();
            PlayFabAdminAPI.ResetPassword(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResetUserStatisticsResult>> ResetUserStatistics(ResetUserStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResetUserStatisticsResult> waiter;
            waiter = new PlayFabResult<ResetUserStatisticsResult>();
            PlayFabAdminAPI.ResetUserStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResolvePurchaseDisputeResponse>> ResolvePurchaseDispute(ResolvePurchaseDisputeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResolvePurchaseDisputeResponse> waiter;
            waiter = new PlayFabResult<ResolvePurchaseDisputeResponse>();
            PlayFabAdminAPI.ResolvePurchaseDispute(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUser(RevokeAllBansForUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeAllBansForUserResult> waiter;
            waiter = new PlayFabResult<RevokeAllBansForUserResult>();
            PlayFabAdminAPI.RevokeAllBansForUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeBansResult>> RevokeBans(RevokeBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeBansResult> waiter;
            waiter = new PlayFabResult<RevokeBansResult>();
            PlayFabAdminAPI.RevokeBans(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItem(RevokeInventoryItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryResult>();
            PlayFabAdminAPI.RevokeInventoryItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItems(RevokeInventoryItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryItemsResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryItemsResult>();
            PlayFabAdminAPI.RevokeInventoryItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RunTaskResult>> RunTask(RunTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RunTaskResult> waiter;
            waiter = new PlayFabResult<RunTaskResult>();
            PlayFabAdminAPI.RunTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmail(SendAccountRecoveryEmailRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SendAccountRecoveryEmailResult> waiter;
            waiter = new PlayFabResult<SendAccountRecoveryEmailResult>();
            PlayFabAdminAPI.SendAccountRecoveryEmail(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCatalogItemsResult>> SetCatalogItems(UpdateCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCatalogItemsResult> waiter;
            waiter = new PlayFabResult<UpdateCatalogItemsResult>();
            PlayFabAdminAPI.SetCatalogItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecret(SetPlayerSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPlayerSecretResult> waiter;
            waiter = new PlayFabResult<SetPlayerSecretResult>();
            PlayFabAdminAPI.SetPlayerSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPublishedRevisionResult>> SetPublishedRevision(SetPublishedRevisionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPublishedRevisionResult> waiter;
            waiter = new PlayFabResult<SetPublishedRevisionResult>();
            PlayFabAdminAPI.SetPublishedRevision(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPublisherDataResult>> SetPublisherData(SetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPublisherDataResult> waiter;
            waiter = new PlayFabResult<SetPublisherDataResult>();
            PlayFabAdminAPI.SetPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateStoreItemsResult>> SetStoreItems(UpdateStoreItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateStoreItemsResult> waiter;
            waiter = new PlayFabResult<UpdateStoreItemsResult>();
            PlayFabAdminAPI.SetStoreItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleData(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            PlayFabAdminAPI.SetTitleData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataAndOverridesResult>> SetTitleDataAndOverrides(SetTitleDataAndOverridesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataAndOverridesResult> waiter;
            waiter = new PlayFabResult<SetTitleDataAndOverridesResult>();
            PlayFabAdminAPI.SetTitleDataAndOverrides(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalData(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            PlayFabAdminAPI.SetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetupPushNotificationResult>> SetupPushNotification(SetupPushNotificationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetupPushNotificationResult> waiter;
            waiter = new PlayFabResult<SetupPushNotificationResult>();
            PlayFabAdminAPI.SetupPushNotification(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyUserVirtualCurrencyResult> waiter;
            waiter = new PlayFabResult<ModifyUserVirtualCurrencyResult>();
            PlayFabAdminAPI.SubtractUserVirtualCurrency(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateBansResult>> UpdateBans(UpdateBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateBansResult> waiter;
            waiter = new PlayFabResult<UpdateBansResult>();
            PlayFabAdminAPI.UpdateBans(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCatalogItemsResult>> UpdateCatalogItems(UpdateCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCatalogItemsResult> waiter;
            waiter = new PlayFabResult<UpdateCatalogItemsResult>();
            PlayFabAdminAPI.UpdateCatalogItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCloudScriptResult>> UpdateCloudScript(UpdateCloudScriptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCloudScriptResult> waiter;
            waiter = new PlayFabResult<UpdateCloudScriptResult>();
            PlayFabAdminAPI.UpdateCloudScript(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateOpenIdConnection(UpdateOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabAdminAPI.UpdateOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerSharedSecretResult>> UpdatePlayerSharedSecret(UpdatePlayerSharedSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerSharedSecretResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerSharedSecretResult>();
            PlayFabAdminAPI.UpdatePlayerSharedSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerStatisticDefinitionResult>> UpdatePlayerStatisticDefinition(UpdatePlayerStatisticDefinitionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerStatisticDefinitionResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerStatisticDefinitionResult>();
            PlayFabAdminAPI.UpdatePlayerStatisticDefinition(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePolicyResponse>> UpdatePolicy(UpdatePolicyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePolicyResponse> waiter;
            waiter = new PlayFabResult<UpdatePolicyResponse>();
            PlayFabAdminAPI.UpdatePolicy(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateRandomResultTablesResult>> UpdateRandomResultTables(UpdateRandomResultTablesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateRandomResultTablesResult> waiter;
            waiter = new PlayFabResult<UpdateRandomResultTablesResult>();
            PlayFabAdminAPI.UpdateRandomResultTables(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateSegmentResponse>> UpdateSegment(UpdateSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateSegmentResponse> waiter;
            waiter = new PlayFabResult<UpdateSegmentResponse>();
            PlayFabAdminAPI.UpdateSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateStoreItemsResult>> UpdateStoreItems(UpdateStoreItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateStoreItemsResult> waiter;
            waiter = new PlayFabResult<UpdateStoreItemsResult>();
            PlayFabAdminAPI.UpdateStoreItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateTask(UpdateTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabAdminAPI.UpdateTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabAdminAPI.UpdateUserData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalData(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabAdminAPI.UpdateUserInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabAdminAPI.UpdateUserPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalData(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabAdminAPI.UpdateUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabAdminAPI.UpdateUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyData(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            PlayFabAdminAPI.UpdateUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayName(UpdateUserTitleDisplayNameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserTitleDisplayNameResult> waiter;
            waiter = new PlayFabResult<UpdateUserTitleDisplayNameResult>();
            PlayFabAdminAPI.UpdateUserTitleDisplayName(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
