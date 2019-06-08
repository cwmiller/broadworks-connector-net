using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceManagementEventGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventQueueType _eventQueueType;

    [XmlElement(ElementName = "eventQueueType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventQueueType EventQueueType {
        get => _eventQueueType;
        set {
            EventQueueTypeSpecified = true;
            _eventQueueType = value;
        }
    }

    [XmlIgnore]
    public bool EventQueueTypeSpecified { get; set; }
    private int _responseSizeLimit;

    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
    public int ResponseSizeLimit {
        get => _responseSizeLimit;
        set {
            ResponseSizeLimitSpecified = true;
            _responseSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool ResponseSizeLimitSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending _searchCriteriaExactDeviceManagementEventStatusInProgressOrPending;

    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusInProgressOrPending", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending {
        get => _searchCriteriaExactDeviceManagementEventStatusInProgressOrPending;
        set {
            SearchCriteriaExactDeviceManagementEventStatusInProgressOrPendingSpecified = true;
            _searchCriteriaExactDeviceManagementEventStatusInProgressOrPending = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactDeviceManagementEventStatusInProgressOrPendingSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusCompleted _searchCriteriaExactDeviceManagementEventStatusCompleted;

    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusCompleted", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusCompleted SearchCriteriaExactDeviceManagementEventStatusCompleted {
        get => _searchCriteriaExactDeviceManagementEventStatusCompleted;
        set {
            SearchCriteriaExactDeviceManagementEventStatusCompletedSpecified = true;
            _searchCriteriaExactDeviceManagementEventStatusCompleted = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactDeviceManagementEventStatusCompletedSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventAction _searchCriteriaExactDeviceManagementEventAction;

    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventAction SearchCriteriaExactDeviceManagementEventAction {
        get => _searchCriteriaExactDeviceManagementEventAction;
        set {
            SearchCriteriaExactDeviceManagementEventActionSpecified = true;
            _searchCriteriaExactDeviceManagementEventAction = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactDeviceManagementEventActionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventLevel _searchCriteriaExactDeviceManagementEventLevel;

    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventLevel SearchCriteriaExactDeviceManagementEventLevel {
        get => _searchCriteriaExactDeviceManagementEventLevel;
        set {
            SearchCriteriaExactDeviceManagementEventLevelSpecified = true;
            _searchCriteriaExactDeviceManagementEventLevel = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactDeviceManagementEventLevelSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventType _searchCriteriaExactDeviceManagementEventType;

    [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventType SearchCriteriaExactDeviceManagementEventType {
        get => _searchCriteriaExactDeviceManagementEventType;
        set {
            SearchCriteriaExactDeviceManagementEventTypeSpecified = true;
            _searchCriteriaExactDeviceManagementEventType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactDeviceManagementEventTypeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo> _searchCriteriaDeviceManagementEventAdditionalInfo;

    [XmlElement(ElementName = "searchCriteriaDeviceManagementEventAdditionalInfo", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo> SearchCriteriaDeviceManagementEventAdditionalInfo {
        get => _searchCriteriaDeviceManagementEventAdditionalInfo;
        set {
            SearchCriteriaDeviceManagementEventAdditionalInfoSpecified = true;
            _searchCriteriaDeviceManagementEventAdditionalInfo = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceManagementEventAdditionalInfoSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId> _searchCriteriaDeviceManagementEventLoginId;

    [XmlElement(ElementName = "searchCriteriaDeviceManagementEventLoginId", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId> SearchCriteriaDeviceManagementEventLoginId {
        get => _searchCriteriaDeviceManagementEventLoginId;
        set {
            SearchCriteriaDeviceManagementEventLoginIdSpecified = true;
            _searchCriteriaDeviceManagementEventLoginId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceManagementEventLoginIdSpecified { get; set; }
}
}
