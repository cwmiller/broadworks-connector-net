using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEndpointGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaLinePortUserPart", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaLinePortUserPart> SearchCriteriaLinePortUserPart { get; set; }
    [XmlElement(ElementName = "searchCriteriaLinePortDomain", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaLinePortDomain> SearchCriteriaLinePortDomain { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId { get; set; }
    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn { get; set; }
    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceType> SearchCriteriaDeviceType { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceMACAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> SearchCriteriaDeviceMACAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceNetAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> SearchCriteriaDeviceNetAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment> SearchCriteriaExactUserDepartment { get; set; }
 }
}
