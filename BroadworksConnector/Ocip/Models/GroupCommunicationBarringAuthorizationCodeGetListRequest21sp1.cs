using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode> SearchCriteriaCommunicationBarringAuthorizationCode { get; set; }
    [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCodeDescription", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription> SearchCriteriaCommunicationBarringAuthorizationCodeDescription { get; set; }
    [XmlElement(ElementName = "searchCriteriaNetworkClassOfServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName> SearchCriteriaNetworkClassOfServiceName { get; set; }
 }
}
