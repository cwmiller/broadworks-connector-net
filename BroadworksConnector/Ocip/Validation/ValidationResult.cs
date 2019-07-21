using System.Collections.Generic;
using System.Linq;

namespace BroadWorksConnector.Ocip.Validation
{
    public class ValidationResult
    {
        public bool Success { get => Errors.Count() == 0; }

        public IEnumerable<ValidationError> Errors { get; set; }

        public ValidationResult(IEnumerable<ValidationError> errors)
        {
            Errors = errors;
        }
    }
}
