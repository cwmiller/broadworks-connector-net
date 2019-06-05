using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MWIDeliveryToMobileEndpointTemplateTag{
    [XmlEnum(Name = "Voice Mail Number")]
    VoiceMailNumber,
    [XmlEnum(Name = "New Messages Count")]
    NewMessagesCount,
    [XmlEnum(Name = "Total Messages Count")]
    TotalMessagesCount,
    [XmlEnum(Name = "Caller Name")]
    CallerName,
    [XmlEnum(Name = "Caller Number")]
    CallerNumber,
 }
}
