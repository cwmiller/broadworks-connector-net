using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
