using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible status values of a service pack migration task.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServicePackMigrationTaskStatus21
    {
        [XmlEnum(Name = "Awaiting Edits")]
        AwaitingEdits,
        [XmlEnum(Name = "Pending")]
        Pending,
        [XmlEnum(Name = "Processing")]
        Processing,
        [XmlEnum(Name = "Terminating")]
        Terminating,
        [XmlEnum(Name = "Terminated")]
        Terminated,
        [XmlEnum(Name = "Stopped By System")]
        StoppedBySystem,
        [XmlEnum(Name = "Completed")]
        Completed,
        [XmlEnum(Name = "Expired")]
        Expired,
    }
}
