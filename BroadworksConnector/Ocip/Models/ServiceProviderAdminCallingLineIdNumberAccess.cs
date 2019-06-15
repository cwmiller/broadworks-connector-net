using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator's policy for accessing calling line id number.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminCallingLineIdNumberAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
     }
}
