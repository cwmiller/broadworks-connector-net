using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceManagementEventGetListRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "eventQueueType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventQueueType EventQueueType { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusInProgressOrPending", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusCompleted", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusCompleted SearchCriteriaExactDeviceManagementEventStatusCompleted { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventAction SearchCriteriaExactDeviceManagementEventAction { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventLevel SearchCriteriaExactDeviceManagementEventLevel { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventType SearchCriteriaExactDeviceManagementEventType { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceManagementEventAdditionalInfo", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo> SearchCriteriaDeviceManagementEventAdditionalInfo { get; set; }
    [XmlElement(ElementName = "searchCriteriaDeviceManagementEventLoginId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId> SearchCriteriaDeviceManagementEventLoginId { get; set; }
 }
}
