using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center type.
    /// 
    /// The following values are only used in AS data mode and will fail in XS data mode:
    /// Standard
    /// Premium
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterType    {
            [XmlEnum(Name = "Basic")]
        Basic,
            [XmlEnum(Name = "Standard")]
        Standard,
            [XmlEnum(Name = "Premium")]
        Premium,
     }
}
