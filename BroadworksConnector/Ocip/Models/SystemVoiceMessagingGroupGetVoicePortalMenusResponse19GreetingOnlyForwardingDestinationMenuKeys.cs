using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingOnlyForwardingDestinationMenuKeys 
{
    [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = false)]
    public string GreetingOnlyForwardingDestination { get; set; }
 }
}
