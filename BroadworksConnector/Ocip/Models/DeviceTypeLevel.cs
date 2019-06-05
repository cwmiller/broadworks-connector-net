using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceTypeLevel
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Reseller")]
        Reseller,
    }
}
