using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementServicePackNameList 
{
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public List<string> ServicePackName { get; set; }
 }
}
