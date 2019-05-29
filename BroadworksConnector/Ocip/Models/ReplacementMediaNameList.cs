using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementMediaNameList 
{
    [XmlElement(ElementName = "mediaName", IsNullable = false)]
    public List<string> MediaName { get; set; }
 }
}
