using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServiceGetAuthorizationRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "userServiceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserService UserServiceName { get; set; }
    [XmlElement(ElementName = "groupServiceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupService GroupServiceName { get; set; }
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public string ServicePackName { get; set; }
 }
}
