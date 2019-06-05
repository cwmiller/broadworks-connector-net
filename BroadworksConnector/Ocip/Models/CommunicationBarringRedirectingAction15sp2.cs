using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommunicationBarringRedirectingAction15sp2
    {
        [XmlEnum(Name = "Allow")]
        Allow,
        [XmlEnum(Name = "Block")]
        Block,
    }
}
