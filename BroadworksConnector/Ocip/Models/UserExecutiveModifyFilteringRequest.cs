using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveModifyFilteringRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "enableFiltering", IsNullable = false)]
    public bool EnableFiltering { get; set; }
    [XmlElement(ElementName = "filteringMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringMode FilteringMode { get; set; }
    [XmlElement(ElementName = "simpleFilterType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType SimpleFilterType { get; set; }
    [XmlElement(ElementName = "criteriaActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation { get; set; }
 }
}
