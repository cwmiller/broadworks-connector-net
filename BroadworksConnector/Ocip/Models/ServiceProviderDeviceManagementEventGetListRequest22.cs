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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:2956""}]")]
    public class ServiceProviderDeviceManagementEventGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderDeviceManagementEventGetListResponse22>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventQueueType _eventQueueType;

        [XmlElement(ElementName = "eventQueueType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool EventQueueTypeSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending _searchCriteriaExactDeviceManagementEventStatusInProgressOrPending;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusInProgressOrPending", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool SearchCriteriaExactDeviceManagementEventStatusInProgressOrPendingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventStatusCompleted _searchCriteriaExactDeviceManagementEventStatusCompleted;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventStatusCompleted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool SearchCriteriaExactDeviceManagementEventStatusCompletedSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventAction _searchCriteriaExactDeviceManagementEventAction;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool SearchCriteriaExactDeviceManagementEventActionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventLevel _searchCriteriaExactDeviceManagementEventLevel;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool SearchCriteriaExactDeviceManagementEventLevelSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceManagementEventType _searchCriteriaExactDeviceManagementEventType;

        [XmlElement(ElementName = "searchCriteriaExactDeviceManagementEventType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool SearchCriteriaExactDeviceManagementEventTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo> _searchCriteriaDeviceManagementEventAdditionalInfo = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventAdditionalInfo>();

        [XmlElement(ElementName = "searchCriteriaDeviceManagementEventAdditionalInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool SearchCriteriaDeviceManagementEventAdditionalInfoSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId> _searchCriteriaDeviceManagementEventLoginId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventLoginId>();

        [XmlElement(ElementName = "searchCriteriaDeviceManagementEventLoginId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
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
        protected bool SearchCriteriaDeviceManagementEventLoginIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventRequest> _searchCriteriaDeviceManagementEventRequest = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventRequest>();

        [XmlElement(ElementName = "searchCriteriaDeviceManagementEventRequest", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventRequest> SearchCriteriaDeviceManagementEventRequest
        {
            get => _searchCriteriaDeviceManagementEventRequest;
            set
            {
                SearchCriteriaDeviceManagementEventRequestSpecified = true;
                _searchCriteriaDeviceManagementEventRequest = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDeviceManagementEventRequestSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventRequestTrackingId> _searchCriteriaDeviceManagementEventRequestTrackingId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventRequestTrackingId>();

        [XmlElement(ElementName = "searchCriteriaDeviceManagementEventRequestTrackingId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2956")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceManagementEventRequestTrackingId> SearchCriteriaDeviceManagementEventRequestTrackingId
        {
            get => _searchCriteriaDeviceManagementEventRequestTrackingId;
            set
            {
                SearchCriteriaDeviceManagementEventRequestTrackingIdSpecified = true;
                _searchCriteriaDeviceManagementEventRequestTrackingId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDeviceManagementEventRequestTrackingIdSpecified { get; set; }

    }
}
