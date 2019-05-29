using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoiceMessagingAliasReplacementList 
{
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public List<string> PhoneNumber { get; set; }
 }
}
