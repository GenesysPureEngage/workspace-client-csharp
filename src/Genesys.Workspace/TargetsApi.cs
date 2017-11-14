using System;
using System.Collections.Generic;
using Genesys.Workspace.Common;
using Genesys.Workspace.Internal.Client;
using Genesys.Workspace.Internal.Model;
using Genesys.Workspace.Model;

namespace Genesys.Workspace
{
    public class TargetsApi
    {
        private Genesys.Workspace.Internal.Api.TargetsApi targetsApi;

        public TargetsApi()
        {
        }

        public void Initialize(ApiClient apiClient)
        {
            this.targetsApi = new Internal.Api.TargetsApi(apiClient.RestClient.BaseUrl.ToString());
            targetsApi.Configuration.ApiClient = apiClient;        
        }

        public TargetSearchResult search(String searchTerm)
        {
            return search(searchTerm, new TargetsSearchOptions());
        }

        public TargetSearchResult search(String searchTerm, TargetsSearchOptions options)
        {
            try 
            {
                TargetsResponse response = this.targetsApi.Get(searchTerm);

                TargetsResponseData data = response.Data;

                List<Genesys.Workspace.Model.Target> targets = new List<Genesys.Workspace.Model.Target>();
                if (data.Targets != null)
                {
                    foreach (Genesys.Workspace.Internal.Model.Target t in data.Targets)
                    {
                        targets.Add(new Genesys.Workspace.Model.Target(t));
                    }
                }
                return new TargetSearchResult((long)data.TotalMatches, targets);

            } 
            catch (ApiException e) 
            {
                throw new WorkspaceApiException("searchTargets failed.", e);
            }
        }
    }
}
