using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Types of bandwidth enforcement.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MediaBandwidthEnforcementType    {
            [XmlEnum(Name = "Allow All")]
        AllowAll,
            [XmlEnum(Name = "Allow Unspecified")]
        AllowUnspecified,
            [XmlEnum(Name = "Enforce All")]
        EnforceAll,
     }
}
