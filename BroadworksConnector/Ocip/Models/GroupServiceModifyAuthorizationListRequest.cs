using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceModifyAuthorizationListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "servicePackAuthorization", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ServicePackAuthorization> ServicePackAuthorization { get; set; }
    [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupServiceAuthorization> GroupServiceAuthorization { get; set; }
    [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserServiceAuthorization> UserServiceAuthorization { get; set; }
 }
}
