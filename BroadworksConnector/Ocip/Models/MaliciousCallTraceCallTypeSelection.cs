using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MaliciousCallTraceCallTypeSelection{
    [XmlEnum(Name = "All Incoming")]
    AllIncoming,
    [XmlEnum(Name = "Answered Incoming")]
    AnsweredIncoming,
    [XmlEnum(Name = "All Incoming And Outgoing")]
    AllIncomingAndOutgoing,
 }
}
