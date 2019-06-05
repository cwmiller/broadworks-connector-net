using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallForwardingService
    {
        [XmlEnum(Name = "Call Forwarding Always")]
        CallForwardingAlways,
        [XmlEnum(Name = "Call Forwarding Always Secondary")]
        CallForwardingAlwaysSecondary,
        [XmlEnum(Name = "Call Forwarding Busy")]
        CallForwardingBusy,
        [XmlEnum(Name = "Call Forwarding No Answer")]
        CallForwardingNoAnswer,
        [XmlEnum(Name = "Call Forwarding Not Reachable")]
        CallForwardingNotReachable,
        [XmlEnum(Name = "Call Forwarding Selective")]
        CallForwardingSelective,
    }
}
