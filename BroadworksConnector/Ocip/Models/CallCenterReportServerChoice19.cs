using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center report server choice.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportServerChoice19    {
            [XmlEnum(Name = "Enhanced")]
        Enhanced,
            [XmlEnum(Name = "Off")]
        Off,
     }
}
