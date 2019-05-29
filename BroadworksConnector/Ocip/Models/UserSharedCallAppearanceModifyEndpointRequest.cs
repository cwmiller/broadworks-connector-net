using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSharedCallAppearanceModifyEndpointRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointKey AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "allowOrigination", IsNullable = false)]
    public bool AllowOrigination { get; set; }
    [XmlElement(ElementName = "allowTermination", IsNullable = false)]
    public bool AllowTermination { get; set; }
 }
}
