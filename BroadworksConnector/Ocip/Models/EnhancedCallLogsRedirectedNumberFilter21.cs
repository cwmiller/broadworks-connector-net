using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsRedirectedNumberFilter21 
{
    [XmlElement(ElementName = "redirectedCall", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnhancedCallLogsRedirectedCallSelection21 RedirectedCall { get; set; }
    [XmlElement(ElementName = "includeServiceInvocationBasicCallType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.BasicCallType> IncludeServiceInvocationBasicCallType { get; set; }
    [XmlElement(ElementName = "includeServiceInvocationCallCategory", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCategory> IncludeServiceInvocationCallCategory { get; set; }
    [XmlElement(ElementName = "includeServiceInvocationConfigurableCallType", IsNullable = false)]
    public List<string> IncludeServiceInvocationConfigurableCallType { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceInvocationDialedNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationDialedNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceInvocationCalledNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationCalledNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceInvocationNetworkTranslatedNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaServiceInvocationNetworkTranslatedNumber { get; set; }
 }
}
