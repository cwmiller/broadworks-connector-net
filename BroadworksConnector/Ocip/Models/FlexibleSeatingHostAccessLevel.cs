using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access level of a flexible seating host
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum FlexibleSeatingHostAccessLevel
    {
        [XmlEnum(Name = "Enterprise")]
        Enterprise,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
