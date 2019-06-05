using System;

namespace BroadworksConnector.Ocip
{
    /// <summary>
    /// Thrown when BroadWorks returns a response from an OCIP call that can't be handled.
    /// </summary>
    public class BadResponseException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        public BadResponseException(string message) : base(message) { }

        /// <summary>
        /// Constructor with inner exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public BadResponseException(string message, Exception innerException) : base(message, innerException) { }
    }
}
