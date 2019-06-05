using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingDisableMessageDepositSelection{
    [XmlEnum(Name = "Disconnect")]
    Disconnect,
    [XmlEnum(Name = "Forward")]
    Forward,
 }
}
