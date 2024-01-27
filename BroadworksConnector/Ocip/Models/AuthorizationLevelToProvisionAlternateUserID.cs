using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Authorization levels to provision alternate user id
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthorizationLevelToProvisionAlternateUserID
    {
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "System")]
        System,
    }
}
