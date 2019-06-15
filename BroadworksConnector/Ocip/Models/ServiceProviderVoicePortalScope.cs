using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Voice Portal Scope.
    /// The Service Provider option allows users to log in to their voice portal using the voice portal
    /// of any group that is both hosted on the same application server and within the same service provider
    /// or enterprise.
    /// The Group option keeps groups completely independent. Users can only log in to their voice portal
    /// using the access number for their group.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderVoicePortalScope    {
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
     }
}
