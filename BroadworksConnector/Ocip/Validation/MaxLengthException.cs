using System;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a field is set to a value with a length longer than allowed.
    /// </summary>
    public class MaxLengthException : Exception
    {
        public string PropertyName { get; private set; }

        public int Actual { get; private set; }

        public int Max { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="actual"></param>
        /// <param name="max"></param>
        public MaxLengthException(string propertyName, int actual, int max) : base($"Length of field {propertyName} can't be over {max}.")
        {
            PropertyName = propertyName;
            Actual = actual;
            Max = max;
        }
    }
}
