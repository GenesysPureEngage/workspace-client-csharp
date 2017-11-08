using System;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace Genesys.Workspace.Internal.Client
{
    public partial class ApiClient
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(IRestRequest request)
        {
            string contentType = null;

            foreach(Parameter p in request.Parameters)
            {
                if ( p.Type == ParameterType.RequestBody)
                {
                    contentType = p.Name;
                }
            }

            if (contentType == null)
            {
                request.AddHeader("Content-type", "application/json");
            }
        }

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(IRestRequest request, IRestResponse response)
        {
            var requestToLog = new
            {
                // ToString() here to have the method as a nice string otherwise it will just show the enum value
                method = request.Method.ToString(),
                resource = request.Resource,
                // Parameters are custom anonymous objects in order to have the parameter type as a nice string
                // otherwise it will just show the enum value
                parameters = request.Parameters.Select(parameter => new
                {
                    name = parameter.Name,
                    value = parameter.Value,
                    type = parameter.Type.ToString()
                }),
            };

            var responseToLog = new
            {
                statusCode = response.StatusCode,
                content = response.Content,
                headers = response.Headers,
                // The Uri that actually responded (could be different from the requestUri if a redirection occurred)
                responseUri = response.ResponseUri,
                errorMessage = response.ErrorMessage,
            };

            log.Debug(string.Format("\nRequest: {0}\nResponse: {1}",
                    JsonConvert.SerializeObject(requestToLog),
                    JsonConvert.SerializeObject(responseToLog)));
        }
    }
}
