using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Center statistics sampling period.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterStatisticsSamplingPeriodMinutes
    {
        [XmlEnum(Name = "15")]
        _15,
        [XmlEnum(Name = "30")]
        _30,
    }
}
