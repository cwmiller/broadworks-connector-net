using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum MWIDeliveryToMobileEndpointTemplateTag{
    VoiceMailNumber,
    NewMessagesCount,
    TotalMessagesCount,
    CallerName,
    CallerNumber,
 }
}
