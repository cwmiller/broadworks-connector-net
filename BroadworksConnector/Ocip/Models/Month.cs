using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Defines the month (January - December).
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum Month    {
            [XmlEnum(Name = "January")]
        January,
            [XmlEnum(Name = "February")]
        February,
            [XmlEnum(Name = "March")]
        March,
            [XmlEnum(Name = "April")]
        April,
            [XmlEnum(Name = "May")]
        May,
            [XmlEnum(Name = "June")]
        June,
            [XmlEnum(Name = "July")]
        July,
            [XmlEnum(Name = "August")]
        August,
            [XmlEnum(Name = "September")]
        September,
            [XmlEnum(Name = "October")]
        October,
            [XmlEnum(Name = "November")]
        November,
            [XmlEnum(Name = "December")]
        December,
     }
}
