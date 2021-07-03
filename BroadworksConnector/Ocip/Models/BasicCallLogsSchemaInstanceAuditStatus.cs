using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Status of the Basic Call Logs schema instance audit process initiated by
    /// the SystemBasicCallLogsSchemaInstanceAuditRequest command.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BasicCallLogsSchemaInstanceAuditStatus
    {
        [XmlEnum(Name = "Not Started")]
        NotStarted,
        [XmlEnum(Name = "In Progress")]
        InProgress,
        [XmlEnum(Name = "Completed Success")]
        CompletedSuccess,
        [XmlEnum(Name = "Completed Error")]
        CompletedError,
    }
}
