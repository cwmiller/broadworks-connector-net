using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportSamplingPeriod
    {
        [XmlEnum(Name = "15 Minutes")]
        _15Minutes,
        [XmlEnum(Name = "30 Minutes")]
        _30Minutes,
        [XmlEnum(Name = "Hourly")]
        Hourly,
        [XmlEnum(Name = "Daily")]
        Daily,
        [XmlEnum(Name = "Weekly")]
        Weekly,
        [XmlEnum(Name = "Monthly")]
        Monthly,
    }
}
