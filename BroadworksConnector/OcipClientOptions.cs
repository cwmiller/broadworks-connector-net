namespace BroadWorksConnector
{
    public class OcipClientOptions
    {
        /// <summary>
        /// Minimum supported BroadWorks version.
        /// Defaults to R14sp4, set to R22 if running R22 or greater to set ResellerId in UserDetails 
        /// </summary>
        public ServerVersion MinServerVersion { get; set; }

        public OcipClientOptions()
        {
            MinServerVersion = ServerVersion.R14sp4;
        }
    }
}
