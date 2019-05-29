using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVideoAddOnModifyRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "maxOriginatingCallDelaySeconds", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds MaxOriginatingCallDelaySeconds { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify AccessDeviceEndpoint { get; set; }
 }
}
