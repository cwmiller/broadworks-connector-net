using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request device management's events for a specific queue.
    /// It is possible to restrict the number of rows returned using
    /// responseSizeLimit.
    /// If eventQueueType is not specified, the events from all the
    /// event queues are returned.
    /// The response is either a ServiceProviderDeviceManagementEventGetListResponse22 or an ErrorResponse.
    /// <see cref="ServiceProviderDeviceManagementEventGetListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2242""}]")]
    public class ServiceProviderDeviceManagementEventGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementEventQueueType _eventQueueType;

        [XmlElement(ElementName = "eventQueueType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventQueueType EventQueueType
        {
            get => _eventQueueType;
            set
            {
                EventQueueTypeSpecified = true;
                _eventQueueType = value;
            }
        }

        [XmlIgnore]
        public bool EventQueueTypeSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending _searchCriteriaExactDeviceManagementEventStatusInProgressOrPending;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusInProgressOrPending", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending
        {
            get => _searchCriteriaExactDeviceManagementEventStatusInProgressOrPending;
            set
            {
                SearchCriteriaExactDeviceManagementEventStatusInProgressOrPendingSpecified = true;
                _searchCriteriaExactDeviceManagementEventStatusInProgressOrPending = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactDeviceManagementEventStatusInProgressOrPendingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusCompleted _searchCriteriaExactDeviceManagementEventStatusCompleted;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusCompleted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusCompleted SearchCriteriaExactDeviceManagementEventStatusCompleted
        {
            get => _searchCriteriaExactDeviceManagementEventStatusCompleted;
            set
            {
                SearchCriteriaExactDeviceManagementEventStatusCompletedSpecified = true;
                _searchCriteriaExactDeviceManagementEventStatusCompleted = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactDeviceManagementEventStatusCompletedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventAction _searchCriteriaExactDeviceManagementEventAction;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventAction SearchCriteriaExactDeviceManagementEventAction
        {
            get => _searchCriteriaExactDeviceManagementEventAction;
            set
            {
                SearchCriteriaExactDeviceManagementEventActionSpecified = true;
                _searchCriteriaExactDeviceManagementEventAction = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactDeviceManagementEventActionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventLevel _searchCriteriaExactDeviceManagementEventLevel;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventLevel SearchCriteriaExactDeviceManagementEventLevel
        {
            get => _searchCriteriaExactDeviceManagementEventLevel;
            set
            {
                SearchCriteriaExactDeviceManagementEventLevelSpecified = true;
                _searchCriteriaExactDeviceManagementEventLevel = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactDeviceManagementEventLevelSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventType _searchCriteriaExactDeviceManagementEventType;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventType SearchCriteriaExactDeviceManagementEventType
        {
            get => _searchCriteriaExactDeviceManagementEventType;
            set
            {
                SearchCriteriaExactDeviceManagementEventTypeSpecified = true;
                _searchCriteriaExactDeviceManagementEventType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactDeviceManagementEventTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo> _searchCriteriaDeviceManagementEventAdditionalInfo = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo>();

        [XmlElement(ElementName = "searchCriteriaDeviceManagementEventAdditionalInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo> SearchCriteriaDeviceManagementEventAdditionalInfo
        {
            get => _searchCriteriaDeviceManagementEventAdditionalInfo;
            set
            {
                SearchCriteriaDeviceManagementEventAdditionalInfoSpecified = true;
                _searchCriteriaDeviceManagementEventAdditionalInfo = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDeviceManagementEventAdditionalInfoSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId> _searchCriteriaDeviceManagementEventLoginId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId>();

        [XmlElement(ElementName = "searchCriteriaDeviceManagementEventLoginId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2242")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId> SearchCriteriaDeviceManagementEventLoginId
        {
            get => _searchCriteriaDeviceManagementEventLoginId;
            set
            {
                SearchCriteriaDeviceManagementEventLoginIdSpecified = true;
                _searchCriteriaDeviceManagementEventLoginId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDeviceManagementEventLoginIdSpecified { get; set; }

    }
}
