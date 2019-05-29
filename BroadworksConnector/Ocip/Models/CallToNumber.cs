using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallToNumber 
{
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallToNumberType Type { get; set; }
    [XmlElement(ElementName = "number", IsNullable = false)]
    public string Number { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = false)]
    public string Extension { get; set; }
 }
}
