namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Thrown when a required field is not set.
    /// </summary>
    public class FieldNotSetException : ValidationException
    {
        public object Object { get; private set; }

        public string FieldName { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="fieldName"></param>
        public FieldNotSetException(object obj, string fieldName) : base($"Field {fieldName} is required on {obj.GetType().Name}.")
        {
            Object = obj;
            FieldName = FieldName;
        }
    }
}
