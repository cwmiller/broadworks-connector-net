using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group Administrator's policy for accessing calling line id number.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminCallingLineIdNumberAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Read-Only")]
        ReadOnly,
    }
}
