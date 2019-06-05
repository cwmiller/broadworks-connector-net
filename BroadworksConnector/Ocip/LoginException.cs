using System;

namespace BroadworksConnector.Ocip
{
    /// <summary>
    /// Thrown when login 
    /// </summary>
    public class LoginException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        public LoginException(string message) : base(message) { }

        /// <summary>
        /// Constructor with inner exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public LoginException(string message, Exception innerException) : base(message, innerException) { }
    }
}
