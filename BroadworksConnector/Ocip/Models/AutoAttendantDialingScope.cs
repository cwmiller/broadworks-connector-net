using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoAttendantDialingScope
    {
        [XmlEnum(Name = "Enterprise")]
        Enterprise,
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "Department")]
        Department,
    }
}
