using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Types that are traced for malicious calls
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MaliciousCallTraceCallTypeSelection
    {
        [XmlEnum(Name = "All Incoming")]
        AllIncoming,
        [XmlEnum(Name = "Answered Incoming")]
        AnsweredIncoming,
        [XmlEnum(Name = "All Incoming And Outgoing")]
        AllIncomingAndOutgoing,
    }
}
