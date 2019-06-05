using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingMessageProcessing{
    [XmlEnum(Name = "Unified Voice and Email Messaging")]
    UnifiedVoiceandEmailMessaging,
    [XmlEnum(Name = "Deliver To Email Address Only")]
    DeliverToEmailAddressOnly,
 }
}
