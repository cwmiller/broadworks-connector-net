using BroadWorksConnector.Ocip.Models.C;
using System;
using System.Text.RegularExpressions;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// Thrown when BroadWorks returns an ErrorResponse object. This is generally returned when a validation or permission check fails.
    /// </summary>
    public class ErrorResponseException : Exception
    {
        public int Code { get; private set; }

        public string Detail { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="response"></param>
        public ErrorResponseException(ErrorResponse response) : base(response.Summary)
        {
            Detail = response.Detail;

            // There is a field in ErrorResponse for an error code, however it's sometimes blank.
            // The error message will include the error code so it can retrieved from there.

            Code = response.ErrorCode;

            var rx = new Regex(@"\[Error (\d+)\]", RegexOptions.Compiled);
            var matches = rx.Matches(response.Summary);

            if (matches.Count > 0)
            {
                Code = Int32.Parse(matches[0].Groups[1].Value);
            }
        }
    }
}
