using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DayOfWeekInMonth
    {
        [XmlEnum(Name = "First")]
        First,
        [XmlEnum(Name = "Second")]
        Second,
        [XmlEnum(Name = "Third")]
        Third,
        [XmlEnum(Name = "Fourth")]
        Fourth,
        [XmlEnum(Name = "Last")]
        Last,
    }
}
