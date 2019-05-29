using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementContactList 
{
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public List<string> Contact { get; set; }
 }
}
