using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group timezone offset minutes
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupTimeZoneOffsetMinutes    {
            [XmlEnum(Name = "0")]
        _0,
            [XmlEnum(Name = "30")]
        _30,
            [XmlEnum(Name = "45")]
        _45,
     }
}
