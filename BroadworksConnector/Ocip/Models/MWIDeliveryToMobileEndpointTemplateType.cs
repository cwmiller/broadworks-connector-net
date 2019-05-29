using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum MWIDeliveryToMobileEndpointTemplateType{
    Default,
    SingleNewNoPreviousMessage,
    SingleNewWithPreviousMessage,
    MultipleNewMessages,
 }
}
