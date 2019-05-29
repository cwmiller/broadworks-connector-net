using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeCallForwardingDestinationMenuKeys 
{
    [XmlElement(ElementName = "finishEnteringNewDestinationNumber", IsNullable = false)]
    public string FinishEnteringNewDestinationNumber { get; set; }
 }
}
