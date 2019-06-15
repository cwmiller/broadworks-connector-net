using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Voice Portal Scope.
    /// When set to System, users can call any group voice portal hosted on the same Application Server
    /// as themselves rather than only the voice portal of their own group to initiate the login process.
    /// When set to Service Providers, the voice portal scope is configured within the Service Provider.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemVoicePortalScope    {
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "System")]
        System,
     }
}
