using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SimultaneousRingSelection{
    [XmlEnum(Name = "Do not Ring if on a Call")]
    DonotRingifonaCall,
    [XmlEnum(Name = "Ring for all Incoming Calls")]
    RingforallIncomingCalls,
 }
}
