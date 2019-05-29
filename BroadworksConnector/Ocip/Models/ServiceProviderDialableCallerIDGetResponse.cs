using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialableCallerIDGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useServiceProviderCriteria", IsNullable = false)]
    public bool UseServiceProviderCriteria { get; set; }
    [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy { get; set; }
    [XmlElement(ElementName = "criteriaTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable { get; set; }
 }
}
