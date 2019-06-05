using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoAttendantType
    {
        [XmlEnum(Name = "Basic")]
        Basic,
        [XmlEnum(Name = "Standard")]
        Standard,
    }
}
