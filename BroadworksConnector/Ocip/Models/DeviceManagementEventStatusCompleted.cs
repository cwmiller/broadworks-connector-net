using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The status of a completed device management event.
    /// It can be 'Canceled', meaning that it was canceled in the middle of processing.
    /// It can be 'Completed', meaning that all its related expanded events have
    /// been successfully processed.
    /// </summary>
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
