using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceListRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "groupDepartmentName", IsNullable = false)]
    public string GroupDepartmentName { get; set; }
    [XmlElement(ElementName = "includeEnterpriseTrunkGroups", IsNullable = false)]
    public bool IncludeEnterpriseTrunkGroups { get; set; }
    [XmlElement(ElementName = "onlyTrunkGroupsWithDevice", IsNullable = false)]
    public bool OnlyTrunkGroupsWithDevice { get; set; }
 }
}
