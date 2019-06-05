using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventStatusCompleted
    {
        [XmlEnum(Name = "Canceled")]
        Canceled,
        [XmlEnum(Name = "Completed")]
        Completed,
    }
}
