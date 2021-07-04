using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the reset event of an access device.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AccessDeviceResetEvent22
    {
        [XmlEnum(Name = "Resync")]
        Resync,
        [XmlEnum(Name = "CheckSync")]
        CheckSync,
        [XmlEnum(Name = "ResetString")]
        ResetString,
    }
}
