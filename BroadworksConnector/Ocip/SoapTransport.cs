using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// Transport for handling OCIP calls over SOAP
    /// </summary>
    internal class SoapTransport : ITransport
    {
        private readonly Uri _uri;

        private readonly HttpClient _httpClient;

        private static readonly XNamespace _soapEnvelopeNs = "http://schemas.xmlsoap.org/soap/envelope/";
        private static readonly XNamespace _soapEncodingeNs = "http://schemas.xmlsoap.org/soap/encoding/";
        private static readonly XNamespace _xsiNs = "http://www.w3.org/2001/XMLSchema-instance";
        private static readonly XNamespace _bwNs = "urn:com:broadsoft:webservice";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="ocipOptions"></param>
        public SoapTransport(Uri uri, OcipClientOptions ocipOptions)
        {
            _uri = uri;
            var handler = new HttpClientHandler();

            if (ocipOptions.IgnoreSslCertificateErrors)
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            _httpClient = new HttpClient(handler)
            {
                Timeout = ocipOptions.SoapTimeout <= 0
                         ? Timeout.InfiniteTimeSpan
                         : TimeSpan.FromMilliseconds(ocipOptions.SoapTimeout)
            };
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        /// <summary>
        /// Handle request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="BadResponseException"></exception>
        public async Task<string> SendAsync(string request, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var envelope = new XElement(_soapEnvelopeNs + "Envelope",
                new XElement(_soapEnvelopeNs + "Body",
                    new XElement("processOCIMessage",
                        new XElement("arg0",
                            new XAttribute(_xsiNs + "type", _soapEncodingeNs + "string"),
                            request
                        )
                    )
                )
            );

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, _uri)
            {
                Content = new StringContent(envelope.ToString(), Encoding.UTF8, "text/xml")
            };

            httpRequest.Headers.Add("SOAPAction", "");

            var httpResponse = await _httpClient.SendAsync(httpRequest, cancellationToken);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new BadResponseException($"SOAP endpoint responded with status code {httpResponse.StatusCode}");
            }

            var resp =  await httpResponse.Content.ReadAsStringAsync();


            string processOCIMessageReturn = null;

            try
            {
                var document = XDocument.Parse(resp);
                processOCIMessageReturn = document.Descendants(_bwNs + "processOCIMessageReturn").FirstOrDefault()?.Value;
            }
            catch (XmlException)
            {
                throw new BadResponseException("SOAP endpoint did not respond with a SOAP response");
            }

            return processOCIMessageReturn == null
                ? throw new BadResponseException("No processOCIMessageReturn in SOAP response")
                : processOCIMessageReturn;
        }
    }
}
