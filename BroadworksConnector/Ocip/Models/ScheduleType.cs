using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Schedule type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ScheduleType    {
            [XmlEnum(Name = "Holiday")]
        Holiday,
            [XmlEnum(Name = "Time")]
        Time,
     }
}
