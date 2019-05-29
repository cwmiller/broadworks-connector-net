using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseTrunkReplacementNumberPrefixList 
{
    [XmlElement(ElementName = "numberPrefix", IsNullable = false)]
    public List<string> NumberPrefix { get; set; }
 }
}
