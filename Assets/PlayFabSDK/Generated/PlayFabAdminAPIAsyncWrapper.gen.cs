using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if ENABLE_PLAYFABADMIN_API
using PlayFab.AdminModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static partial class PlayFabAdminAPI
    {
        #if ENABLE_PLAYFABADMIN_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<EmptyResponse>> AbortTaskInstanceAsync(AbortTaskInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            AbortTaskInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddLocalizedNewsResult>> AddLocalizedNewsAsync(AddLocalizedNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddLocalizedNewsResult> waiter;
            waiter = new PlayFabResult<AddLocalizedNewsResult>();
            AddLocalizedNews(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddNewsResult>> AddNewsAsync(AddNewsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddNewsResult> waiter;
            waiter = new PlayFabResult<AddNewsResult>();
            AddNews(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTagAsync(AddPlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddPlayerTagResult> waiter;
            waiter = new PlayFabResult<AddPlayerTagResult>();
            AddPlayerTag(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<AddServerBuildResult>> AddServerBuildAsync(AddServerBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<AddServerBuildResult> waiter;
            waiter = new PlayFabResult<AddServerBuildResult>();
            AddServerBuild(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<BlankResult>> AddVirtualCurrencyTypesAsync(AddVirtualCurrencyTypesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BlankResult> waiter;
            waiter = new PlayFabResult<BlankResult>();
            AddVirtualCurrencyTypes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BanUsersResult>> BanUsersAsync(BanUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BanUsersResult> waiter;
            waiter = new PlayFabResult<BanUsersResult>();
            BanUsers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CheckLimitedEditionItemAvailabilityResult>> CheckLimitedEditionItemAvailabilityAsync(CheckLimitedEditionItemAvailabilityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CheckLimitedEditionItemAvailabilityResult> waiter;
            waiter = new PlayFabResult<CheckLimitedEditionItemAvailabilityResult>();
            CheckLimitedEditionItemAvailability(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateTaskResult>> CreateActionsOnPlayersInSegmentTaskAsync(CreateActionsOnPlayerSegmentTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateTaskResult> waiter;
            waiter = new PlayFabResult<CreateTaskResult>();
            CreateActionsOnPlayersInSegmentTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateTaskResult>> CreateCloudScriptTaskAsync(CreateCloudScriptTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateTaskResult> waiter;
            waiter = new PlayFabResult<CreateTaskResult>();
            CreateCloudScriptTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateTaskResult>> CreateInsightsScheduledScalingTaskAsync(CreateInsightsScheduledScalingTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateTaskResult> waiter;
            waiter = new PlayFabResult<CreateTaskResult>();
            CreateInsightsScheduledScalingTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> CreateOpenIdConnectionAsync(CreateOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            CreateOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreatePlayerSharedSecretResult>> CreatePlayerSharedSecretAsync(CreatePlayerSharedSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreatePlayerSharedSecretResult> waiter;
            waiter = new PlayFabResult<CreatePlayerSharedSecretResult>();
            CreatePlayerSharedSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreatePlayerStatisticDefinitionResult>> CreatePlayerStatisticDefinitionAsync(CreatePlayerStatisticDefinitionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreatePlayerStatisticDefinitionResult> waiter;
            waiter = new PlayFabResult<CreatePlayerStatisticDefinitionResult>();
            CreatePlayerStatisticDefinition(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateSegmentResponse>> CreateSegmentAsync(CreateSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateSegmentResponse> waiter;
            waiter = new PlayFabResult<CreateSegmentResponse>();
            CreateSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BlankResult>> DeleteContentAsync(DeleteContentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BlankResult> waiter;
            waiter = new PlayFabResult<BlankResult>();
            DeleteContent(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteMasterPlayerAccountResult>> DeleteMasterPlayerAccountAsync(DeleteMasterPlayerAccountRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteMasterPlayerAccountResult> waiter;
            waiter = new PlayFabResult<DeleteMasterPlayerAccountResult>();
            DeleteMasterPlayerAccount(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteOpenIdConnectionAsync(DeleteOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            DeleteOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePlayerResult>> DeletePlayerAsync(DeletePlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePlayerResult> waiter;
            waiter = new PlayFabResult<DeletePlayerResult>();
            DeletePlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeletePlayerSharedSecretResult>> DeletePlayerSharedSecretAsync(DeletePlayerSharedSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeletePlayerSharedSecretResult> waiter;
            waiter = new PlayFabResult<DeletePlayerSharedSecretResult>();
            DeletePlayerSharedSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteSegmentsResponse>> DeleteSegmentAsync(DeleteSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteSegmentsResponse> waiter;
            waiter = new PlayFabResult<DeleteSegmentsResponse>();
            DeleteSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteStoreResult>> DeleteStoreAsync(DeleteStoreRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteStoreResult> waiter;
            waiter = new PlayFabResult<DeleteStoreResult>();
            DeleteStore(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteTaskAsync(DeleteTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            DeleteTask(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteTitleResult>> DeleteTitleAsync(DeleteTitleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteTitleResult> waiter;
            waiter = new PlayFabResult<DeleteTitleResult>();
            DeleteTitle(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<DeleteTitleDataOverrideResult>> DeleteTitleDataOverrideAsync(DeleteTitleDataOverrideRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<DeleteTitleDataOverrideResult> waiter;
            waiter = new PlayFabResult<DeleteTitleDataOverrideResult>();
            DeleteTitleDataOverride(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ExportMasterPlayerDataResult>> ExportMasterPlayerDataAsync(ExportMasterPlayerDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ExportMasterPlayerDataResult> waiter;
            waiter = new PlayFabResult<ExportMasterPlayerDataResult>();
            ExportMasterPlayerData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult>> GetActionsOnPlayersInSegmentTaskInstanceAsync(GetTaskInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult> waiter;
            waiter = new PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult>();
            GetActionsOnPlayersInSegmentTaskInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegmentsAsync(GetAllSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAllSegmentsResult> waiter;
            waiter = new PlayFabResult<GetAllSegmentsResult>();
            GetAllSegments(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetCloudScriptRevisionResult>> GetCloudScriptRevisionAsync(GetCloudScriptRevisionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCloudScriptRevisionResult> waiter;
            waiter = new PlayFabResult<GetCloudScriptRevisionResult>();
            GetCloudScriptRevision(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCloudScriptTaskInstanceResult>> GetCloudScriptTaskInstanceAsync(GetTaskInstanceRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCloudScriptTaskInstanceResult> waiter;
            waiter = new PlayFabResult<GetCloudScriptTaskInstanceResult>();
            GetCloudScriptTaskInstance(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetCloudScriptVersionsResult>> GetCloudScriptVersionsAsync(GetCloudScriptVersionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetCloudScriptVersionsResult> waiter;
            waiter = new PlayFabResult<GetCloudScriptVersionsResult>();
            GetCloudScriptVersions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentListResult>> GetContentListAsync(GetContentListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentListResult> waiter;
            waiter = new PlayFabResult<GetContentListResult>();
            GetContentList(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContentUploadUrlResult>> GetContentUploadUrlAsync(GetContentUploadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContentUploadUrlResult> waiter;
            waiter = new PlayFabResult<GetContentUploadUrlResult>();
            GetContentUploadUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetDataReportResult>> GetDataReportAsync(GetDataReportRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetDataReportResult> waiter;
            waiter = new PlayFabResult<GetDataReportResult>();
            GetDataReport(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMatchmakerGameInfoResult>> GetMatchmakerGameInfoAsync(GetMatchmakerGameInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMatchmakerGameInfoResult> waiter;
            waiter = new PlayFabResult<GetMatchmakerGameInfoResult>();
            GetMatchmakerGameInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMatchmakerGameModesResult>> GetMatchmakerGameModesAsync(GetMatchmakerGameModesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMatchmakerGameModesResult> waiter;
            waiter = new PlayFabResult<GetMatchmakerGameModesResult>();
            GetMatchmakerGameModes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayedTitleListResult>> GetPlayedTitleListAsync(GetPlayedTitleListRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayedTitleListResult> waiter;
            waiter = new PlayFabResult<GetPlayedTitleListResult>();
            GetPlayedTitleList(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerIdFromAuthTokenResult>> GetPlayerIdFromAuthTokenAsync(GetPlayerIdFromAuthTokenRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerIdFromAuthTokenResult> waiter;
            waiter = new PlayFabResult<GetPlayerIdFromAuthTokenResult>();
            GetPlayerIdFromAuthToken(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSegmentsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSegmentsResult>();
            GetPlayerSegments(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerSharedSecretsResult>> GetPlayerSharedSecretsAsync(GetPlayerSharedSecretsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerSharedSecretsResult> waiter;
            waiter = new PlayFabResult<GetPlayerSharedSecretsResult>();
            GetPlayerSharedSecrets(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayersInSegmentResult> waiter;
            waiter = new PlayFabResult<GetPlayersInSegmentResult>();
            GetPlayersInSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetPlayerStatisticDefinitionsResult>> GetPlayerStatisticDefinitionsAsync(GetPlayerStatisticDefinitionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPlayerStatisticDefinitionsResult> waiter;
            waiter = new PlayFabResult<GetPlayerStatisticDefinitionsResult>();
            GetPlayerStatisticDefinitions(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetPolicyResponse>> GetPolicyAsync(GetPolicyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetPolicyResponse> waiter;
            waiter = new PlayFabResult<GetPolicyResponse>();
            GetPolicy(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTablesAsync(GetRandomResultTablesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetRandomResultTablesResult> waiter;
            waiter = new PlayFabResult<GetRandomResultTablesResult>();
            GetRandomResultTables(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetSegmentsResponse>> GetSegmentsAsync(GetSegmentsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetSegmentsResponse> waiter;
            waiter = new PlayFabResult<GetSegmentsResponse>();
            GetSegments(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetServerBuildInfoResult>> GetServerBuildInfoAsync(GetServerBuildInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetServerBuildInfoResult> waiter;
            waiter = new PlayFabResult<GetServerBuildInfoResult>();
            GetServerBuildInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetServerBuildUploadURLResult>> GetServerBuildUploadUrlAsync(GetServerBuildUploadURLRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetServerBuildUploadURLResult> waiter;
            waiter = new PlayFabResult<GetServerBuildUploadURLResult>();
            GetServerBuildUploadUrl(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetTaskInstancesResult>> GetTaskInstancesAsync(GetTaskInstancesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTaskInstancesResult> waiter;
            waiter = new PlayFabResult<GetTaskInstancesResult>();
            GetTaskInstances(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTasksResult>> GetTasksAsync(GetTasksRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTasksResult> waiter;
            waiter = new PlayFabResult<GetTasksResult>();
            GetTasks(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalDataAsync(GetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleDataResult> waiter;
            waiter = new PlayFabResult<GetTitleDataResult>();
            GetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<LookupUserAccountInfoResult>> GetUserAccountInfoAsync(LookupUserAccountInfoRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<LookupUserAccountInfoResult> waiter;
            waiter = new PlayFabResult<LookupUserAccountInfoResult>();
            GetUserAccountInfo(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetUserBansResult>> GetUserBansAsync(GetUserBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserBansResult> waiter;
            waiter = new PlayFabResult<GetUserBansResult>();
            GetUserBans(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserInternalData(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalDataAsync(GetUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetUserDataResult> waiter;
            waiter = new PlayFabResult<GetUserDataResult>();
            GetUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsersAsync(GrantItemsToUsersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GrantItemsToUsersResult> waiter;
            waiter = new PlayFabResult<GrantItemsToUsersResult>();
            GrantItemsToUsers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<IncrementLimitedEditionItemAvailabilityResult>> IncrementLimitedEditionItemAvailabilityAsync(IncrementLimitedEditionItemAvailabilityRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<IncrementLimitedEditionItemAvailabilityResult> waiter;
            waiter = new PlayFabResult<IncrementLimitedEditionItemAvailabilityResult>();
            IncrementLimitedEditionItemAvailability(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<IncrementPlayerStatisticVersionResult>> IncrementPlayerStatisticVersionAsync(IncrementPlayerStatisticVersionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<IncrementPlayerStatisticVersionResult> waiter;
            waiter = new PlayFabResult<IncrementPlayerStatisticVersionResult>();
            IncrementPlayerStatisticVersion(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListOpenIdConnectionResponse>> ListOpenIdConnectionAsync(ListOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListOpenIdConnectionResponse> waiter;
            waiter = new PlayFabResult<ListOpenIdConnectionResponse>();
            ListOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListBuildsResult>> ListServerBuildsAsync(ListBuildsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListBuildsResult> waiter;
            waiter = new PlayFabResult<ListBuildsResult>();
            ListServerBuilds(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListVirtualCurrencyTypesResult>> ListVirtualCurrencyTypesAsync(ListVirtualCurrencyTypesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListVirtualCurrencyTypesResult> waiter;
            waiter = new PlayFabResult<ListVirtualCurrencyTypesResult>();
            ListVirtualCurrencyTypes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyMatchmakerGameModesResult>> ModifyMatchmakerGameModesAsync(ModifyMatchmakerGameModesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyMatchmakerGameModesResult> waiter;
            waiter = new PlayFabResult<ModifyMatchmakerGameModesResult>();
            ModifyMatchmakerGameModes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ModifyServerBuildResult>> ModifyServerBuildAsync(ModifyServerBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ModifyServerBuildResult> waiter;
            waiter = new PlayFabResult<ModifyServerBuildResult>();
            ModifyServerBuild(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RefundPurchaseResponse>> RefundPurchaseAsync(RefundPurchaseRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RefundPurchaseResponse> waiter;
            waiter = new PlayFabResult<RefundPurchaseResponse>();
            RefundPurchase(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTagAsync(RemovePlayerTagRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemovePlayerTagResult> waiter;
            waiter = new PlayFabResult<RemovePlayerTagResult>();
            RemovePlayerTag(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveServerBuildResult>> RemoveServerBuildAsync(RemoveServerBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveServerBuildResult> waiter;
            waiter = new PlayFabResult<RemoveServerBuildResult>();
            RemoveServerBuild(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BlankResult>> RemoveVirtualCurrencyTypesAsync(RemoveVirtualCurrencyTypesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BlankResult> waiter;
            waiter = new PlayFabResult<BlankResult>();
            RemoveVirtualCurrencyTypes(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResetCharacterStatisticsResult>> ResetCharacterStatisticsAsync(ResetCharacterStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResetCharacterStatisticsResult> waiter;
            waiter = new PlayFabResult<ResetCharacterStatisticsResult>();
            ResetCharacterStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResetPasswordResult>> ResetPasswordAsync(ResetPasswordRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResetPasswordResult> waiter;
            waiter = new PlayFabResult<ResetPasswordResult>();
            ResetPassword(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResetUserStatisticsResult>> ResetUserStatisticsAsync(ResetUserStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResetUserStatisticsResult> waiter;
            waiter = new PlayFabResult<ResetUserStatisticsResult>();
            ResetUserStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ResolvePurchaseDisputeResponse>> ResolvePurchaseDisputeAsync(ResolvePurchaseDisputeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ResolvePurchaseDisputeResponse> waiter;
            waiter = new PlayFabResult<ResolvePurchaseDisputeResponse>();
            ResolvePurchaseDispute(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeAllBansForUserResult> waiter;
            waiter = new PlayFabResult<RevokeAllBansForUserResult>();
            RevokeAllBansForUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeBansResult>> RevokeBansAsync(RevokeBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeBansResult> waiter;
            waiter = new PlayFabResult<RevokeBansResult>();
            RevokeBans(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItemAsync(RevokeInventoryItemRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryResult>();
            RevokeInventoryItem(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RevokeInventoryItemsResult> waiter;
            waiter = new PlayFabResult<RevokeInventoryItemsResult>();
            RevokeInventoryItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RunTaskResult>> RunTaskAsync(RunTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RunTaskResult> waiter;
            waiter = new PlayFabResult<RunTaskResult>();
            RunTask(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<UpdateCatalogItemsResult>> SetCatalogItemsAsync(UpdateCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCatalogItemsResult> waiter;
            waiter = new PlayFabResult<UpdateCatalogItemsResult>();
            SetCatalogItems(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<SetPublishedRevisionResult>> SetPublishedRevisionAsync(SetPublishedRevisionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPublishedRevisionResult> waiter;
            waiter = new PlayFabResult<SetPublishedRevisionResult>();
            SetPublishedRevision(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetPublisherDataResult>> SetPublisherDataAsync(SetPublisherDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetPublisherDataResult> waiter;
            waiter = new PlayFabResult<SetPublisherDataResult>();
            SetPublisherData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateStoreItemsResult>> SetStoreItemsAsync(UpdateStoreItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateStoreItemsResult> waiter;
            waiter = new PlayFabResult<UpdateStoreItemsResult>();
            SetStoreItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleDataAsync(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            SetTitleData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataAndOverridesResult>> SetTitleDataAndOverridesAsync(SetTitleDataAndOverridesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataAndOverridesResult> waiter;
            waiter = new PlayFabResult<SetTitleDataAndOverridesResult>();
            SetTitleDataAndOverrides(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalDataAsync(SetTitleDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetTitleDataResult> waiter;
            waiter = new PlayFabResult<SetTitleDataResult>();
            SetTitleInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetupPushNotificationResult>> SetupPushNotificationAsync(SetupPushNotificationRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetupPushNotificationResult> waiter;
            waiter = new PlayFabResult<SetupPushNotificationResult>();
            SetupPushNotification(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<UpdateBansResult>> UpdateBansAsync(UpdateBansRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateBansResult> waiter;
            waiter = new PlayFabResult<UpdateBansResult>();
            UpdateBans(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCatalogItemsResult>> UpdateCatalogItemsAsync(UpdateCatalogItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCatalogItemsResult> waiter;
            waiter = new PlayFabResult<UpdateCatalogItemsResult>();
            UpdateCatalogItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateCloudScriptResult>> UpdateCloudScriptAsync(UpdateCloudScriptRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateCloudScriptResult> waiter;
            waiter = new PlayFabResult<UpdateCloudScriptResult>();
            UpdateCloudScript(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateOpenIdConnectionAsync(UpdateOpenIdConnectionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UpdateOpenIdConnection(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerSharedSecretResult>> UpdatePlayerSharedSecretAsync(UpdatePlayerSharedSecretRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerSharedSecretResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerSharedSecretResult>();
            UpdatePlayerSharedSecret(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePlayerStatisticDefinitionResult>> UpdatePlayerStatisticDefinitionAsync(UpdatePlayerStatisticDefinitionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePlayerStatisticDefinitionResult> waiter;
            waiter = new PlayFabResult<UpdatePlayerStatisticDefinitionResult>();
            UpdatePlayerStatisticDefinition(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdatePolicyResponse>> UpdatePolicyAsync(UpdatePolicyRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdatePolicyResponse> waiter;
            waiter = new PlayFabResult<UpdatePolicyResponse>();
            UpdatePolicy(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateRandomResultTablesResult>> UpdateRandomResultTablesAsync(UpdateRandomResultTablesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateRandomResultTablesResult> waiter;
            waiter = new PlayFabResult<UpdateRandomResultTablesResult>();
            UpdateRandomResultTables(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateSegmentResponse>> UpdateSegmentAsync(UpdateSegmentRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateSegmentResponse> waiter;
            waiter = new PlayFabResult<UpdateSegmentResponse>();
            UpdateSegment(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateStoreItemsResult>> UpdateStoreItemsAsync(UpdateStoreItemsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateStoreItemsResult> waiter;
            waiter = new PlayFabResult<UpdateStoreItemsResult>();
            UpdateStoreItems(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateTaskAsync(UpdateTaskRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            UpdateTask(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserInternalData(request, waiter.processSuccess, waiter.processFail);
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
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserPublisherInternalData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserPublisherReadOnlyData(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<UpdateUserDataResult> waiter;
            waiter = new PlayFabResult<UpdateUserDataResult>();
            UpdateUserReadOnlyData(request, waiter.processSuccess, waiter.processFail);
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
        #endif
    }
}
#endif
