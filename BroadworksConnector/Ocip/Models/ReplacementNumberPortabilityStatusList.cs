using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementNumberPortabilityStatusList 
{
    [XmlElement(ElementName = "status", IsNullable = false)]
    public List<string> Status { get; set; }
 }
}
