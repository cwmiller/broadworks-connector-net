using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceReadExternalSource 
{
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint { get; set; }
 }
}
