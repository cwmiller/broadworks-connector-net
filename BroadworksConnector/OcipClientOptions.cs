using System;
using System.Text;

namespace BroadWorksConnector
{
    public class OcipClientOptions
    {
        /// <summary>
        /// Minimum supported BroadWorks version.
        /// Defaults to R14sp4, set to R22 if running R22 or greater to set ResellerId in UserDetails 
        /// </summary>
        public ServerVersion MinServerVersion { get; set; } = ServerVersion.R14sp4;

        /// <summary>
        /// Timeout setting for opening new connections with SOAP transport. Value is in milliseconds. Defaults to 60 seconds.
        /// </summary>
        [Obsolete("Value has no effect. Use SoapTimeout instead.")]
        public int SoapOpenTimeout { get; set; } = 60000;

        /// <summary>
        /// Timeout setting for closing connections with SOAP transport. Value is in milliseconds. Defaults to 60 seconds.
        /// </summary>
        [Obsolete("Value has no effect. Use SoapTimeout instead.")]
        public int SoapCloseTimeout { get; set; } = 60000;

        /// <summary>
        /// Timeout setting for sending and receiving data with SOAP transport. Value is in milliseconds. Defaults to 60 seconds.
        /// </summary>
        [Obsolete("Value has no effect. Use SoapTimeout instead.")]
        public int SoapSendTimeout { get; set; } = 60000;

        /// <summary>
        /// Timeout setting to wait before SOAP transport times out. Value is in milliseconds. 
        /// Defaults to 100 seconds. Any value equal or below 0 will be treated as an infinite timeout
        /// </summary>
        public int SoapTimeout { get; set; } = 100_000;

        /// <summary>
        /// Timeout setting for sending data with TCP transport. Value is in milliseconds. Defaults to 0.
        /// </summary>
        public int TcpSendTimeout { get; set; } = 0;

        /// <summary>
        /// Timeout setting for receiving data with TCP transport. Value is in milliseconds. Defaults to 0.
        /// </summary>
        public int TcpReceiveTimeout { get; set; } = 0;

        /// <summary>
        /// Encoding setting for encoding the request data with TCP transport. Defaults to UTF8.
        /// </summary>
        public Encoding TcpRequestEncoding { get; set; } = Encoding.UTF8;

        /// <summary>
        /// Encoding setting for decoding the request data with TCP transport. Defaults to UTF8.
        /// </summary>
        public Encoding TcpResponseEncoding { get; set; } = Encoding.UTF8;
    }
}
