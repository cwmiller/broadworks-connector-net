using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminType
    {
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "Department")]
        Department,
    }
}
