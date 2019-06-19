using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device Management queues available in the system.
    /// They contain events at various stage of processing.
    /// </summary>
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
