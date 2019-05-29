using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkGroupDeviceEndpointRead 
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public string Contact { get; set; }
    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false)]
    public bool StaticRegistrationCapable { get; set; }
    [XmlElement(ElementName = "useDomain", IsNullable = false)]
    public bool UseDomain { get; set; }
 }
}
