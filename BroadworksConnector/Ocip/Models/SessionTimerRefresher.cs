using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Preferred Session Timer Refresher.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SessionTimerRefresher
    {
        [XmlEnum(Name = "Local")]
        Local,
        [XmlEnum(Name = "Remote")]
        Remote,
    }
}
