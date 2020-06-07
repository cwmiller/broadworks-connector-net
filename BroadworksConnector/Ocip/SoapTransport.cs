using BroadWorksConnector.Ocip.Soap;
using System;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// Transport for handling OCIP calls over SOAP
    /// </summary>
    internal class SoapTransport : ITransport
    {
        private Uri _uri;

        private BWProvisioningServiceClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uri"></param>
        public SoapTransport(Uri uri)
        {
            _uri = uri;
            _client = new BWProvisioningServiceClient(BWProvisioningServiceClient.EndpointConfiguration.ProvisioningService, uri.ToString());
        }

        public void Dispose()
        {
            // Nothing to dispose of
        }

        /// <summary>
        /// Handle request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Obsolete("This method is deprecated. Use SendAsync instead.")]
        public Task<string> Send(string request) => SendAsync(request);

        public async Task<string> SendAsync(string request, CancellationToken cancellationToken = default)
        {
            processOCIMessageResponse response = null;

            if (!cancellationToken.IsCancellationRequested)
            {
                using (var ctr = cancellationToken.Register(() =>
                {
                    _client.Abort();

                    cancellationToken.ThrowIfCancellationRequested();
                }))
                {
                    response = await _client.processOCIMessageAsync(request);

                    if (response.Body?.processOCIMessageReturn == null)
                    {
                        throw new BadResponseException("No processOCIMessageReturn in response");
                    }

                }
            }
            else
            {
                cancellationToken.ThrowIfCancellationRequested();
            }

            return response?.Body?.processOCIMessageReturn;
        }
    }
}
