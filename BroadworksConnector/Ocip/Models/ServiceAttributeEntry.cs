using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceAttributeEntry 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "value", IsNullable = true)]
    public string Value { get; set; }
 }
}
