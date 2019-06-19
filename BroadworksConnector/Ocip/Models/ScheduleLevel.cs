using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Schedule access level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ScheduleLevel
    {
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "User")]
        User,
    }
}
