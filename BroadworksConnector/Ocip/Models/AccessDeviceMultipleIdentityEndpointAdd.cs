using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AccessDeviceMultipleIdentityEndpointAdd 
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "privateIdentity", IsNullable = false)]
    public string PrivateIdentity { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public string Contact { get; set; }
    [XmlElement(ElementName = "portNumber", IsNullable = false)]
    public int PortNumber { get; set; }
 }
}
