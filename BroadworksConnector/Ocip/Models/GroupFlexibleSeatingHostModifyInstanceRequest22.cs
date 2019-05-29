using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostModifyInstanceRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfileFlexibleSeatingHost ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointModify22 AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
