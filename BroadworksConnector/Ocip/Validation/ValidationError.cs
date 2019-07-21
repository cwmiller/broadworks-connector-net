namespace BroadWorksConnector.Ocip.Validation
{
    public abstract class ValidationError
    {
        public object Object { get; protected set; }

        public string Message { get; protected set; }
    }
}
