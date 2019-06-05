using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportWebStatisticsSource
    {
        [XmlEnum(Name = "CCRS")]
        CCRS,
        [XmlEnum(Name = "Enhanced")]
        Enhanced,
    }
}
