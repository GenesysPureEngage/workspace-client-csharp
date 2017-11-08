using System;
using Genesys.Workspace.Internal.Client;
using Genesys.Workspace.Internal.Model;

namespace Genesys.Workspace
{
    public class SessionApi
    {
        private Genesys.Workspace.Internal.Api.SessionApi sessionApi;

        public SessionApi()
        {
        }

        public void Initialize(ApiClient apiClient)
        {
            this.sessionApi = new Internal.Api.SessionApi(apiClient.Configuration);
        }

        public ApiResponse<ApiSuccessResponse> InitializeWorkspaceWithHttpInfo(string authCode, string redirectUri, string authorization)
        {
            return this.sessionApi.InitializeWorkspaceWithHttpInfo(authCode, redirectUri, authorization);
        }

        public ApiSuccessResponse ActivateChannels(ChannelsData channelsData)
        {
            return sessionApi.ActivateChannels(channelsData);
        }

        public ApiSuccessResponse Logout()
        {
            return sessionApi.Logout();            
        }
    }
}
