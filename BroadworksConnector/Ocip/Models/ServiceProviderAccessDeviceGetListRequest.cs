using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceMACAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> SearchCriteriaDeviceMACAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceNetAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> SearchCriteriaDeviceNetAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactDeviceType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceType SearchCriteriaExactDeviceType { get; set; }
    [XmlElement(ElementName = "searchCriteriaAccessDeviceVersion", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion> SearchCriteriaAccessDeviceVersion { get; set; }
 }
}
