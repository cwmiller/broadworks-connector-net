using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommunicationBarringProfileReplacementList 
{
    [XmlElement(ElementName = "profileName", IsNullable = false)]
    public List<string> ProfileName { get; set; }
 }
}
