using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group Call Count Highwater mark Holdover period in minutes
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupHighwaterCallCountHoldoverPeriodMinutes
    {
        [XmlEnum(Name = "5")]
        _5,
        [XmlEnum(Name = "10")]
        _10,
        [XmlEnum(Name = "15")]
        _15,
        [XmlEnum(Name = "20")]
        _20,
        [XmlEnum(Name = "30")]
        _30,
        [XmlEnum(Name = "60")]
        _60,
    }
}
