using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupCLIDSourceForScreenedCallsPolicy{
    [XmlEnum(Name = "Profile Name Profile Number")]
    ProfileNameProfileNumber,
    [XmlEnum(Name = "Received Name Profile Number")]
    ReceivedNameProfileNumber,
    [XmlEnum(Name = "Received Name Received Number")]
    ReceivedNameReceivedNumber,
 }
}
