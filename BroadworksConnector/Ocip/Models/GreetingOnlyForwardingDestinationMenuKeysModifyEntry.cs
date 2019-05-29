using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GreetingOnlyForwardingDestinationMenuKeysModifyEntry 
{
    [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = true)]
    public string GreetingOnlyForwardingDestination { get; set; }
 }
}
