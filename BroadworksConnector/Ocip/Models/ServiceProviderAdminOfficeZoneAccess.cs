using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator's policy for accessing
    /// the Office Zone information.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminOfficeZoneAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Read-Only")]
        ReadOnly,
    }
}
