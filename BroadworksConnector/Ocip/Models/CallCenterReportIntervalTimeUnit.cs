using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting report interval time unit.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportIntervalTimeUnit
    {
        [XmlEnum(Name = "Hour")]
        Hour,
        [XmlEnum(Name = "Day")]
        Day,
        [XmlEnum(Name = "Week")]
        Week,
        [XmlEnum(Name = "Month")]
        Month,
        [XmlEnum(Name = "Year")]
        Year,
    }
}
