using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventType
    {
        [XmlEnum(Name = "Automatic")]
        Automatic,
        [XmlEnum(Name = "Manual")]
        Manual,
    }
}
