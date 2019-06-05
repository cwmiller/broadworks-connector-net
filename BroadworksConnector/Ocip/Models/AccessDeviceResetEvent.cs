using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AccessDeviceResetEvent
    {
        [XmlEnum(Name = "Resync")]
        Resync,
        [XmlEnum(Name = "CheckSync")]
        CheckSync,
    }
}
