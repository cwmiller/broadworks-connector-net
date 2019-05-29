using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceRead22ExternalSource 
{
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead AccessDeviceEndpoint { get; set; }
 }
}
