using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The status of a device management event.
    /// It can be 'Pending', meaning that it is not yet queued for processing.
    /// It can be 'Queued', waiting to be processed.
    /// It can be 'In Progress', meaning that it is currently being processed.
    /// It can be 'Process On Other Host', meaning that it is currently being
    /// processed on another host.
    /// It can be 'Stale', meaning that it should currently be queued in
    /// the internal Device Management queue but is not.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventStatusInProgressOrPending    {
            [XmlEnum(Name = "Pending")]
        Pending,
            [XmlEnum(Name = "Queued")]
        Queued,
            [XmlEnum(Name = "In Progress")]
        InProgress,
            [XmlEnum(Name = "Process On Other Host")]
        ProcessOnOtherHost,
            [XmlEnum(Name = "Stale")]
        Stale,
     }
}
