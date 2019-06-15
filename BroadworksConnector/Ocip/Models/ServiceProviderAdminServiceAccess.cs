using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator's policy for accessing services.
    /// "No Authorization" was added in release 14.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminServiceAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "No Authorization")]
        NoAuthorization,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
     }
}
