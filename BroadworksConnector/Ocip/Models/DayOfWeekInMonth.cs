using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Defines the day of week in the month (First, Second, Third, Fourth, or Last).
    /// </summary>
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
