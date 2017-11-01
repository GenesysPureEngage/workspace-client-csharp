using System;
using System.Collections.Generic;
using Genesys.Workspace.Internal.Client;
using RestSharp;

namespace Genesys.Workspace.Common
{
    public class WorkspaceApiClient : ApiClient
    {
        public WorkspaceApiClient(string basePath) : base( basePath)
        {
        }

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        protected void InterceptRequest(IRestRequest request)
        {
            bool bodyFound = false;

            foreach(Parameter p in request.Parameters)
            {
                if ( p.Type == ParameterType.RequestBody )
                {
                    bodyFound = true;
                }
            }

            if ( !bodyFound )
            {
                request.AddParameter("application/json", "", ParameterType.RequestBody);
            }
        }

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        protected void InterceptResponse(IRestRequest request, IRestResponse response)
        {
            
        }
    }
}
