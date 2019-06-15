using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Logout request reason.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LogoutRequestReason    {
            [XmlEnum(Name = "Client Logout")]
        ClientLogout,
            [XmlEnum(Name = "Server Connection Failure")]
        ServerConnectionFailure,
            [XmlEnum(Name = "Open Client Server Forced Logout")]
        OpenClientServerForcedLogout,
     }
}
