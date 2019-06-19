using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center report server choice.
    /// 
    /// Replaced by CallCenterReportServerChoice19
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportServerChoice
    {
        [XmlEnum(Name = "CCRS")]
        CCRS,
        [XmlEnum(Name = "Enhanced")]
        Enhanced,
        [XmlEnum(Name = "Both")]
        Both,
    }
}
