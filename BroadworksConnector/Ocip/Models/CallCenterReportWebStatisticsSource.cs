using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center report web statistics source.
    /// </summary>
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
