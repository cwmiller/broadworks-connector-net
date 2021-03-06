using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the access device status.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AccessDeviceStatus
    {
        [XmlEnum(Name = "Online")]
        Online,
        [XmlEnum(Name = "Offline")]
        Offline,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
        [XmlEnum(Name = "Unknown")]
        Unknown,
    }
}
