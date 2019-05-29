using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVirtualOnNetEnterpriseExtensionsAddUserRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "virtualOnNetUser", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.VirtualOnNetUser> VirtualOnNetUser { get; set; }
    [XmlElement(ElementName = "virtualOnNetUserRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.VirtualOnNetUserRange> VirtualOnNetUserRange { get; set; }
 }
}
