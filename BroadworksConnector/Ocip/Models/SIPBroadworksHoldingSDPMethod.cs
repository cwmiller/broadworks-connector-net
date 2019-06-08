using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPBroadworksHoldingSDPMethod{
    [XmlEnum(Name = "Hold SDP")]
    HoldSDP,
    [XmlEnum(Name = "Modified Address SDP")]
    ModifiedAddressSDP,
 }
}
