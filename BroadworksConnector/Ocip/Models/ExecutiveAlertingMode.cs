using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive alerting mode.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveAlertingMode
    {
        [XmlEnum(Name = "Simultaneous")]
        Simultaneous,
        [XmlEnum(Name = "Sequential")]
        Sequential,
    }
}
