using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByDeviceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDeviceName SortByDeviceName { get; set; }
    [XmlElement(ElementName = "sortByDeviceType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDeviceType SortByDeviceType { get; set; }
    [XmlElement(ElementName = "sortByDeviceNetAddress", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDeviceNetAddress SortByDeviceNetAddress { get; set; }
    [XmlElement(ElementName = "sortByDeviceMACAddress", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByDeviceMACAddress SortByDeviceMACAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceMACAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> SearchCriteriaDeviceMACAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceNetAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> SearchCriteriaDeviceNetAddress { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactDeviceType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceType> SearchCriteriaExactDeviceType { get; set; }
    [XmlElement(ElementName = "searchCriteriaAccessDeviceVersion", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAccessDeviceVersion> SearchCriteriaAccessDeviceVersion { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
 }
}
