namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Error happens when a required field is not set.
    /// </summary>
    class FieldNotSetError : ValidationError
    {
        /// <summary>
        /// Name of the field that wasn't set
        /// </summary>
        public string FieldName { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="fieldName"></param>
        public FieldNotSetError(object obj, string fieldName)
        {
            Object = obj;
            FieldName = fieldName;
            Message = $"Field {fieldName} is required on {obj.GetType().Name}.";
        }
    }
}
