using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Days of the week (Sunday-Saturday).
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DayOfWeek    {
            [XmlEnum(Name = "Sunday")]
        Sunday,
            [XmlEnum(Name = "Monday")]
        Monday,
            [XmlEnum(Name = "Tuesday")]
        Tuesday,
            [XmlEnum(Name = "Wednesday")]
        Wednesday,
            [XmlEnum(Name = "Thursday")]
        Thursday,
            [XmlEnum(Name = "Friday")]
        Friday,
            [XmlEnum(Name = "Saturday")]
        Saturday,
     }
}
