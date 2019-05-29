using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderNumberPortabilityQueryGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "includeDigitPatterns", IsNullable = false)]
    public bool IncludeDigitPatterns { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern> SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
 }
}
