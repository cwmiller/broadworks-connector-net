using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Type of reset event for a CPE device.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CPEDeviceResetEventType
    {
        [XmlEnum(Name = "Resync")]
        Resync,
        [XmlEnum(Name = "Check Sync")]
        CheckSync,
    }
}
