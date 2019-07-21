using System;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Exception that gets thrown when a request object fails validation 
    /// </summary>
    public class ValidationException : Exception
    {
        public IEnumerable<ValidationError> Errors { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errors"></param>
        public ValidationException(string message, IEnumerable<ValidationError> errors) : base(message)
        {
            Errors = errors;
        }
    }
}
