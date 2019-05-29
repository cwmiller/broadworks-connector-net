using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsNumberFilter 
{
    [XmlElement(ElementName = "includeBasicCallType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.BasicCallType> IncludeBasicCallType { get; set; }
    [XmlElement(ElementName = "includeCallCategory", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCategory> IncludeCallCategory { get; set; }
    [XmlElement(ElementName = "includeConfigurableCallType", IsNullable = false)]
    public List<string> IncludeConfigurableCallType { get; set; }
    [XmlElement(ElementName = "searchCriteriaDialedNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaDialedNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaCalledNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaCalledNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaNetworkTranslatedNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaNetworkTranslatedNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaCallingPresentationNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaOutgoingDNorSIPURI> SearchCriteriaCallingPresentationNumber { get; set; }
 }
}
