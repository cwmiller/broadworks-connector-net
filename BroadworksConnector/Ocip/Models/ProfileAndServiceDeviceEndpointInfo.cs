using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceDeviceEndpointInfo 
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "privateIdentity", IsNullable = false)]
    public string PrivateIdentity { get; set; }
    [XmlElement(ElementName = "accessDeviceMacAddress", IsNullable = false)]
    public string AccessDeviceMacAddress { get; set; }
 }
}
