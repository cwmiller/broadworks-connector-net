using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkGroupDeviceEndpointModify 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = true)]
    public string Contact { get; set; }
 }
}
