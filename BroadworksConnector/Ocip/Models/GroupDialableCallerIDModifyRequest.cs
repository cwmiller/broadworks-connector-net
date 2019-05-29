using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDialableCallerIDModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useGroupCriteria", IsNullable = false)]
    public bool UseGroupCriteria { get; set; }
    [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy { get; set; }
    [XmlElement(ElementName = "criteriaPriorityOrder", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> CriteriaPriorityOrder { get; set; }
 }
}
