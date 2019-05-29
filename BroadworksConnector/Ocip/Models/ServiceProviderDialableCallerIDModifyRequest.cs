using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialableCallerIDModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "useServiceProviderCriteria", IsNullable = false)]
    public bool UseServiceProviderCriteria { get; set; }
    [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy { get; set; }
    [XmlElement(ElementName = "criteriaPriorityOrder", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> CriteriaPriorityOrder { get; set; }
 }
}
