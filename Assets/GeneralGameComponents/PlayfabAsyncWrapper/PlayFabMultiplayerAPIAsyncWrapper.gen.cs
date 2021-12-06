using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
#if ENABLE_PLAYFABSERVER_API && !DISABLE_PLAYFAB_STATIC_API
using PlayFab.MultiplayerModels;
#endif
#if !INCLUDE_ONLY_CODE_GENERATION
namespace PlayFab {

    public static class PlayFabMultiplayerAPIAsync
    {
        #if ENABLE_PLAYFABSERVER_API && !DISABLE_PLAYFAB_STATIC_API
        public static Timing lastCallTiming { get; private set; }
        public static async Task<PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult>> CancelAllMatchmakingTicketsForPlayer(CancelAllMatchmakingTicketsForPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult> waiter;
            waiter = new PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult>();
            PlayFabMultiplayerAPI.CancelAllMatchmakingTicketsForPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult>> CancelAllServerBackfillTicketsForPlayer(CancelAllServerBackfillTicketsForPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult> waiter;
            waiter = new PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult>();
            PlayFabMultiplayerAPI.CancelAllServerBackfillTicketsForPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CancelMatchmakingTicketResult>> CancelMatchmakingTicket(CancelMatchmakingTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CancelMatchmakingTicketResult> waiter;
            waiter = new PlayFabResult<CancelMatchmakingTicketResult>();
            PlayFabMultiplayerAPI.CancelMatchmakingTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CancelServerBackfillTicketResult>> CancelServerBackfillTicket(CancelServerBackfillTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CancelServerBackfillTicketResult> waiter;
            waiter = new PlayFabResult<CancelServerBackfillTicketResult>();
            PlayFabMultiplayerAPI.CancelServerBackfillTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BuildAliasDetailsResponse>> CreateBuildAlias(CreateBuildAliasRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BuildAliasDetailsResponse> waiter;
            waiter = new PlayFabResult<BuildAliasDetailsResponse>();
            PlayFabMultiplayerAPI.CreateBuildAlias(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateBuildWithCustomContainerResponse>> CreateBuildWithCustomContainer(CreateBuildWithCustomContainerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateBuildWithCustomContainerResponse> waiter;
            waiter = new PlayFabResult<CreateBuildWithCustomContainerResponse>();
            PlayFabMultiplayerAPI.CreateBuildWithCustomContainer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateBuildWithManagedContainerResponse>> CreateBuildWithManagedContainer(CreateBuildWithManagedContainerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateBuildWithManagedContainerResponse> waiter;
            waiter = new PlayFabResult<CreateBuildWithManagedContainerResponse>();
            PlayFabMultiplayerAPI.CreateBuildWithManagedContainer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateBuildWithProcessBasedServerResponse>> CreateBuildWithProcessBasedServer(CreateBuildWithProcessBasedServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateBuildWithProcessBasedServerResponse> waiter;
            waiter = new PlayFabResult<CreateBuildWithProcessBasedServerResponse>();
            PlayFabMultiplayerAPI.CreateBuildWithProcessBasedServer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateMatchmakingTicket(CreateMatchmakingTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateMatchmakingTicketResult> waiter;
            waiter = new PlayFabResult<CreateMatchmakingTicketResult>();
            PlayFabMultiplayerAPI.CreateMatchmakingTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateRemoteUserResponse>> CreateRemoteUser(CreateRemoteUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateRemoteUserResponse> waiter;
            waiter = new PlayFabResult<CreateRemoteUserResponse>();
            PlayFabMultiplayerAPI.CreateRemoteUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateServerBackfillTicketResult>> CreateServerBackfillTicket(CreateServerBackfillTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateServerBackfillTicketResult> waiter;
            waiter = new PlayFabResult<CreateServerBackfillTicketResult>();
            PlayFabMultiplayerAPI.CreateServerBackfillTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateServerMatchmakingTicket(CreateServerMatchmakingTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateMatchmakingTicketResult> waiter;
            waiter = new PlayFabResult<CreateMatchmakingTicketResult>();
            PlayFabMultiplayerAPI.CreateServerMatchmakingTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse>> CreateTitleMultiplayerServersQuotaChange(CreateTitleMultiplayerServersQuotaChangeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse> waiter;
            waiter = new PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse>();
            PlayFabMultiplayerAPI.CreateTitleMultiplayerServersQuotaChange(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteAsset(DeleteAssetRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.DeleteAsset(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteBuild(DeleteBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.DeleteBuild(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteBuildAlias(DeleteBuildAliasRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.DeleteBuildAlias(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteBuildRegion(DeleteBuildRegionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.DeleteBuildRegion(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteCertificate(DeleteCertificateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.DeleteCertificate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteContainerImageRepository(DeleteContainerImageRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.DeleteContainerImageRepository(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> DeleteRemoteUser(DeleteRemoteUserRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.DeleteRemoteUser(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EnableMultiplayerServersForTitleResponse>> EnableMultiplayerServersForTitle(EnableMultiplayerServersForTitleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EnableMultiplayerServersForTitleResponse> waiter;
            waiter = new PlayFabResult<EnableMultiplayerServersForTitleResponse>();
            PlayFabMultiplayerAPI.EnableMultiplayerServersForTitle(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAssetDownloadUrlResponse>> GetAssetDownloadUrl(GetAssetDownloadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAssetDownloadUrlResponse> waiter;
            waiter = new PlayFabResult<GetAssetDownloadUrlResponse>();
            PlayFabMultiplayerAPI.GetAssetDownloadUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetAssetUploadUrlResponse>> GetAssetUploadUrl(GetAssetUploadUrlRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetAssetUploadUrlResponse> waiter;
            waiter = new PlayFabResult<GetAssetUploadUrlResponse>();
            PlayFabMultiplayerAPI.GetAssetUploadUrl(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetBuildResponse>> GetBuild(GetBuildRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetBuildResponse> waiter;
            waiter = new PlayFabResult<GetBuildResponse>();
            PlayFabMultiplayerAPI.GetBuild(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BuildAliasDetailsResponse>> GetBuildAlias(GetBuildAliasRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BuildAliasDetailsResponse> waiter;
            waiter = new PlayFabResult<BuildAliasDetailsResponse>();
            PlayFabMultiplayerAPI.GetBuildAlias(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetContainerRegistryCredentialsResponse>> GetContainerRegistryCredentials(GetContainerRegistryCredentialsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetContainerRegistryCredentialsResponse> waiter;
            waiter = new PlayFabResult<GetContainerRegistryCredentialsResponse>();
            PlayFabMultiplayerAPI.GetContainerRegistryCredentials(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMatchResult>> GetMatch(GetMatchRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMatchResult> waiter;
            waiter = new PlayFabResult<GetMatchResult>();
            PlayFabMultiplayerAPI.GetMatch(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMatchmakingQueueResult>> GetMatchmakingQueue(GetMatchmakingQueueRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMatchmakingQueueResult> waiter;
            waiter = new PlayFabResult<GetMatchmakingQueueResult>();
            PlayFabMultiplayerAPI.GetMatchmakingQueue(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMatchmakingTicketResult>> GetMatchmakingTicket(GetMatchmakingTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMatchmakingTicketResult> waiter;
            waiter = new PlayFabResult<GetMatchmakingTicketResult>();
            PlayFabMultiplayerAPI.GetMatchmakingTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMultiplayerServerDetailsResponse>> GetMultiplayerServerDetails(GetMultiplayerServerDetailsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMultiplayerServerDetailsResponse> waiter;
            waiter = new PlayFabResult<GetMultiplayerServerDetailsResponse>();
            PlayFabMultiplayerAPI.GetMultiplayerServerDetails(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerServerLogs(GetMultiplayerServerLogsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMultiplayerServerLogsResponse> waiter;
            waiter = new PlayFabResult<GetMultiplayerServerLogsResponse>();
            PlayFabMultiplayerAPI.GetMultiplayerServerLogs(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerSessionLogsBySessionId(GetMultiplayerSessionLogsBySessionIdRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetMultiplayerServerLogsResponse> waiter;
            waiter = new PlayFabResult<GetMultiplayerServerLogsResponse>();
            PlayFabMultiplayerAPI.GetMultiplayerSessionLogsBySessionId(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetQueueStatisticsResult>> GetQueueStatistics(GetQueueStatisticsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetQueueStatisticsResult> waiter;
            waiter = new PlayFabResult<GetQueueStatisticsResult>();
            PlayFabMultiplayerAPI.GetQueueStatistics(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetRemoteLoginEndpointResponse>> GetRemoteLoginEndpoint(GetRemoteLoginEndpointRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetRemoteLoginEndpointResponse> waiter;
            waiter = new PlayFabResult<GetRemoteLoginEndpointResponse>();
            PlayFabMultiplayerAPI.GetRemoteLoginEndpoint(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetServerBackfillTicketResult>> GetServerBackfillTicket(GetServerBackfillTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetServerBackfillTicketResult> waiter;
            waiter = new PlayFabResult<GetServerBackfillTicketResult>();
            PlayFabMultiplayerAPI.GetServerBackfillTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse>> GetTitleEnabledForMultiplayerServersStatus(GetTitleEnabledForMultiplayerServersStatusRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse> waiter;
            waiter = new PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse>();
            PlayFabMultiplayerAPI.GetTitleEnabledForMultiplayerServersStatus(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse>> GetTitleMultiplayerServersQuotaChange(GetTitleMultiplayerServersQuotaChangeRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse> waiter;
            waiter = new PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse>();
            PlayFabMultiplayerAPI.GetTitleMultiplayerServersQuotaChange(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<GetTitleMultiplayerServersQuotasResponse>> GetTitleMultiplayerServersQuotas(GetTitleMultiplayerServersQuotasRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<GetTitleMultiplayerServersQuotasResponse> waiter;
            waiter = new PlayFabResult<GetTitleMultiplayerServersQuotasResponse>();
            PlayFabMultiplayerAPI.GetTitleMultiplayerServersQuotas(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<JoinMatchmakingTicketResult>> JoinMatchmakingTicket(JoinMatchmakingTicketRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<JoinMatchmakingTicketResult> waiter;
            waiter = new PlayFabResult<JoinMatchmakingTicketResult>();
            PlayFabMultiplayerAPI.JoinMatchmakingTicket(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListMultiplayerServersResponse>> ListArchivedMultiplayerServers(ListMultiplayerServersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListMultiplayerServersResponse> waiter;
            waiter = new PlayFabResult<ListMultiplayerServersResponse>();
            PlayFabMultiplayerAPI.ListArchivedMultiplayerServers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListAssetSummariesResponse>> ListAssetSummaries(ListAssetSummariesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListAssetSummariesResponse> waiter;
            waiter = new PlayFabResult<ListAssetSummariesResponse>();
            PlayFabMultiplayerAPI.ListAssetSummaries(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListBuildAliasesResponse>> ListBuildAliases(ListBuildAliasesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListBuildAliasesResponse> waiter;
            waiter = new PlayFabResult<ListBuildAliasesResponse>();
            PlayFabMultiplayerAPI.ListBuildAliases(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListBuildSummariesResponse>> ListBuildSummariesV2(ListBuildSummariesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListBuildSummariesResponse> waiter;
            waiter = new PlayFabResult<ListBuildSummariesResponse>();
            PlayFabMultiplayerAPI.ListBuildSummariesV2(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListCertificateSummariesResponse>> ListCertificateSummaries(ListCertificateSummariesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListCertificateSummariesResponse> waiter;
            waiter = new PlayFabResult<ListCertificateSummariesResponse>();
            PlayFabMultiplayerAPI.ListCertificateSummaries(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListContainerImagesResponse>> ListContainerImages(ListContainerImagesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListContainerImagesResponse> waiter;
            waiter = new PlayFabResult<ListContainerImagesResponse>();
            PlayFabMultiplayerAPI.ListContainerImages(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListContainerImageTagsResponse>> ListContainerImageTags(ListContainerImageTagsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListContainerImageTagsResponse> waiter;
            waiter = new PlayFabResult<ListContainerImageTagsResponse>();
            PlayFabMultiplayerAPI.ListContainerImageTags(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListMatchmakingQueuesResult>> ListMatchmakingQueues(ListMatchmakingQueuesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListMatchmakingQueuesResult> waiter;
            waiter = new PlayFabResult<ListMatchmakingQueuesResult>();
            PlayFabMultiplayerAPI.ListMatchmakingQueues(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListMatchmakingTicketsForPlayerResult>> ListMatchmakingTicketsForPlayer(ListMatchmakingTicketsForPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListMatchmakingTicketsForPlayerResult> waiter;
            waiter = new PlayFabResult<ListMatchmakingTicketsForPlayerResult>();
            PlayFabMultiplayerAPI.ListMatchmakingTicketsForPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListMultiplayerServersResponse>> ListMultiplayerServers(ListMultiplayerServersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListMultiplayerServersResponse> waiter;
            waiter = new PlayFabResult<ListMultiplayerServersResponse>();
            PlayFabMultiplayerAPI.ListMultiplayerServers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListPartyQosServersResponse>> ListPartyQosServers(ListPartyQosServersRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListPartyQosServersResponse> waiter;
            waiter = new PlayFabResult<ListPartyQosServersResponse>();
            PlayFabMultiplayerAPI.ListPartyQosServers(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListQosServersForTitleResponse>> ListQosServersForTitle(ListQosServersForTitleRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListQosServersForTitleResponse> waiter;
            waiter = new PlayFabResult<ListQosServersForTitleResponse>();
            PlayFabMultiplayerAPI.ListQosServersForTitle(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListServerBackfillTicketsForPlayerResult>> ListServerBackfillTicketsForPlayer(ListServerBackfillTicketsForPlayerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListServerBackfillTicketsForPlayerResult> waiter;
            waiter = new PlayFabResult<ListServerBackfillTicketsForPlayerResult>();
            PlayFabMultiplayerAPI.ListServerBackfillTicketsForPlayer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse>> ListTitleMultiplayerServersQuotaChanges(ListTitleMultiplayerServersQuotaChangesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse> waiter;
            waiter = new PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse>();
            PlayFabMultiplayerAPI.ListTitleMultiplayerServersQuotaChanges(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<ListVirtualMachineSummariesResponse>> ListVirtualMachineSummaries(ListVirtualMachineSummariesRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<ListVirtualMachineSummariesResponse> waiter;
            waiter = new PlayFabResult<ListVirtualMachineSummariesResponse>();
            PlayFabMultiplayerAPI.ListVirtualMachineSummaries(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RemoveMatchmakingQueueResult>> RemoveMatchmakingQueue(RemoveMatchmakingQueueRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RemoveMatchmakingQueueResult> waiter;
            waiter = new PlayFabResult<RemoveMatchmakingQueueResult>();
            PlayFabMultiplayerAPI.RemoveMatchmakingQueue(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RequestMultiplayerServerResponse>> RequestMultiplayerServer(RequestMultiplayerServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RequestMultiplayerServerResponse> waiter;
            waiter = new PlayFabResult<RequestMultiplayerServerResponse>();
            PlayFabMultiplayerAPI.RequestMultiplayerServer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<RolloverContainerRegistryCredentialsResponse>> RolloverContainerRegistryCredentials(RolloverContainerRegistryCredentialsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<RolloverContainerRegistryCredentialsResponse> waiter;
            waiter = new PlayFabResult<RolloverContainerRegistryCredentialsResponse>();
            PlayFabMultiplayerAPI.RolloverContainerRegistryCredentials(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<SetMatchmakingQueueResult>> SetMatchmakingQueue(SetMatchmakingQueueRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<SetMatchmakingQueueResult> waiter;
            waiter = new PlayFabResult<SetMatchmakingQueueResult>();
            PlayFabMultiplayerAPI.SetMatchmakingQueue(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> ShutdownMultiplayerServer(ShutdownMultiplayerServerRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.ShutdownMultiplayerServer(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UntagContainerImage(UntagContainerImageRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.UntagContainerImage(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<BuildAliasDetailsResponse>> UpdateBuildAlias(UpdateBuildAliasRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<BuildAliasDetailsResponse> waiter;
            waiter = new PlayFabResult<BuildAliasDetailsResponse>();
            PlayFabMultiplayerAPI.UpdateBuildAlias(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateBuildName(UpdateBuildNameRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.UpdateBuildName(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateBuildRegion(UpdateBuildRegionRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.UpdateBuildRegion(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UpdateBuildRegions(UpdateBuildRegionsRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.UpdateBuildRegions(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        public static async Task<PlayFabResult<EmptyResponse>> UploadCertificate(UploadCertificateRequest request)
        {
            var timingLogger = DelaysLoggerPlayfab.OnBeforeSend(request);
            PlayFabResult<EmptyResponse> waiter;
            waiter = new PlayFabResult<EmptyResponse>();
            PlayFabMultiplayerAPI.UploadCertificate(request, waiter.processSuccess, waiter.processFail);
            while (waiter.keepWaiting) await Task.Delay(10);
            lastCallTiming = DelaysLoggerPlayfab.OnAfterReceived(timingLogger);
            return waiter;
        }
        #endif
    }
}
#endif
