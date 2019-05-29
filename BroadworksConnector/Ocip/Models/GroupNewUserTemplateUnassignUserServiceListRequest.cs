using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupNewUserTemplateUnassignUserServiceListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> ServiceName { get; set; }
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public List<string> ServicePackName { get; set; }
 }
}
