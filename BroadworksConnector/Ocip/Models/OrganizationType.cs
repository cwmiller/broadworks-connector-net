using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Types of organizations.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum OrganizationType
    {
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "Enterprise")]
        Enterprise,
    }
}
