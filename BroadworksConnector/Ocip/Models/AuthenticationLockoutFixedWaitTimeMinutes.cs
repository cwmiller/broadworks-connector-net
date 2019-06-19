using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Number of minutes to wait when AuthenticationLockoutWaitAlgorithmType is set to fixed.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthenticationLockoutFixedWaitTimeMinutes
    {
        [XmlEnum(Name = "5")]
        _5,
        [XmlEnum(Name = "10")]
        _10,
        [XmlEnum(Name = "20")]
        _20,
        [XmlEnum(Name = "40")]
        _40,
        [XmlEnum(Name = "60")]
        _60,
    }
}
