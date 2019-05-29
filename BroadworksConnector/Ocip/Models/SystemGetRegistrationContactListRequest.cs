using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGetRegistrationContactListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "svcProviderId", IsNullable = false)]
    public string SvcProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "deviceLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "searchCriteriaRegistrationURI", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaRegistrationURI> SearchCriteriaRegistrationURI { get; set; }
    [XmlElement(ElementName = "searchCriteriaSIPContact", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaSIPContact> SearchCriteriaSIPContact { get; set; }
    [XmlElement(ElementName = "endpointType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RegistrationEndpointType EndpointType { get; set; }
    [XmlElement(ElementName = "expired", IsNullable = false)]
    public bool Expired { get; set; }
 }
}
