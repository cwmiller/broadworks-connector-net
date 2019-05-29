using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceGetUserListRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
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
    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactEndpointType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactEndpointType21sp1 SearchCriteriaExactEndpointType { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserType SearchCriteriaExactUserType { get; set; }
    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactPortNumber", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactPortNumber SearchCriteriaExactPortNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaAccessDeviceEndpointPrivateIdentity", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity> SearchCriteriaAccessDeviceEndpointPrivateIdentity { get; set; }
 }
}
