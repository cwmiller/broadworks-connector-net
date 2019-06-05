using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventQueueType
    {
        [XmlEnum(Name = "Completed")]
        Completed,
        [XmlEnum(Name = "In Progress Or Pending")]
        InProgressOrPending,
    }
}
