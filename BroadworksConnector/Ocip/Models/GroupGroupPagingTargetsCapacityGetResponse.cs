using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingTargetsCapacityGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maximumTargetUsersFromServiceProvider", IsNullable = false)]
    public int MaximumTargetUsersFromServiceProvider { get; set; }
    [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false)]
    public int MaximumTargetUsers { get; set; }
 }
}
