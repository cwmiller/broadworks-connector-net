using System;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Base exception for all validation exceptions
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        public ValidationException(string message) : base(message)
        {
        }
    }
}
