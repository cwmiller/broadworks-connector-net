using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Hunt Group instance to a group.
    /// The domain is required in the serviceUserId.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true,
    /// it will be added to group if the command is executed by a service provider administrator or above
    /// and the number is already assigned to the service provider. The command will fail otherwise.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
    /// includeHuntGroupNameInCLID, use value "true" in XS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc829065f9d696d3ca7084121d57f8c0:105"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""bc829065f9d696d3ca7084121d57f8c0:117"",""optional"":true}]}]")]
    public class GroupHuntGroupConsolidatedAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        private bool _addPhoneNumberToGroup;

        [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool AddPhoneNumberToGroup
        {
            get => _addPhoneNumberToGroup;
            set
            {
                AddPhoneNumberToGroupSpecified = true;
                _addPhoneNumberToGroup = value;
            }
        }

        [XmlIgnore]
        protected bool AddPhoneNumberToGroupSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy Policy
        {
            get => _policy;
            set
            {
                PolicySpecified = true;
                _policy = value;
            }
        }

        [XmlIgnore]
        protected bool PolicySpecified { get; set; }

        private bool _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool HuntAfterNoAnswer
        {
            get => _huntAfterNoAnswer;
            set
            {
                HuntAfterNoAnswerSpecified = true;
                _huntAfterNoAnswer = value;
            }
        }

        [XmlIgnore]
        protected bool HuntAfterNoAnswerSpecified { get; set; }

        private int _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int NoAnswerNumberOfRings
        {
            get => _noAnswerNumberOfRings;
            set
            {
                NoAnswerNumberOfRingsSpecified = true;
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerNumberOfRingsSpecified { get; set; }

        private bool _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool ForwardAfterTimeout
        {
            get => _forwardAfterTimeout;
            set
            {
                ForwardAfterTimeoutSpecified = true;
                _forwardAfterTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardAfterTimeoutSpecified { get; set; }

        private int _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinInclusive(0)]
        [MaxInclusive(7200)]
        public int ForwardTimeoutSeconds
        {
            get => _forwardTimeoutSeconds;
            set
            {
                ForwardTimeoutSecondsSpecified = true;
                _forwardTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardTimeoutSecondsSpecified { get; set; }

        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ForwardToPhoneNumber
        {
            get => _forwardToPhoneNumber;
            set
            {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardToPhoneNumberSpecified { get; set; }

        private List<string> _agentUserId = new List<string>();

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:117")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> AgentUserId
        {
            get => _agentUserId;
            set
            {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> _agentWeight = new List<BroadWorksConnector.Ocip.Models.HuntAgentWeight>();

        [XmlElement(ElementName = "agentWeight", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:117")]
        public List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> AgentWeight
        {
            get => _agentWeight;
            set
            {
                AgentWeightSpecified = true;
                _agentWeight = value;
            }
        }

        [XmlIgnore]
        protected bool AgentWeightSpecified { get; set; }

        private bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool AllowCallWaitingForAgents
        {
            get => _allowCallWaitingForAgents;
            set
            {
                AllowCallWaitingForAgentsSpecified = true;
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallWaitingForAgentsSpecified { get; set; }

        private bool _useSystemHuntGroupCLIDSetting;

        [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool UseSystemHuntGroupCLIDSetting
        {
            get => _useSystemHuntGroupCLIDSetting;
            set
            {
                UseSystemHuntGroupCLIDSettingSpecified = true;
                _useSystemHuntGroupCLIDSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemHuntGroupCLIDSettingSpecified { get; set; }

        private bool _includeHuntGroupNameInCLID;

        [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool IncludeHuntGroupNameInCLID
        {
            get => _includeHuntGroupNameInCLID;
            set
            {
                IncludeHuntGroupNameInCLIDSpecified = true;
                _includeHuntGroupNameInCLID = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeHuntGroupNameInCLIDSpecified { get; set; }

        private bool _enableNotReachableForwarding;

        [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool EnableNotReachableForwarding
        {
            get => _enableNotReachableForwarding;
            set
            {
                EnableNotReachableForwardingSpecified = true;
                _enableNotReachableForwarding = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNotReachableForwardingSpecified { get; set; }

        private string _notReachableForwardToPhoneNumber;

        [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinLength(1)]
        [MaxLength(161)]
        public string NotReachableForwardToPhoneNumber
        {
            get => _notReachableForwardToPhoneNumber;
            set
            {
                NotReachableForwardToPhoneNumberSpecified = true;
                _notReachableForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool NotReachableForwardToPhoneNumberSpecified { get; set; }

        private bool _makeBusyWhenNotReachable;

        [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool MakeBusyWhenNotReachable
        {
            get => _makeBusyWhenNotReachable;
            set
            {
                MakeBusyWhenNotReachableSpecified = true;
                _makeBusyWhenNotReachable = value;
            }
        }

        [XmlIgnore]
        protected bool MakeBusyWhenNotReachableSpecified { get; set; }

        private bool _allowMembersToControlGroupBusy;

        [XmlElement(ElementName = "allowMembersToControlGroupBusy", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool AllowMembersToControlGroupBusy
        {
            get => _allowMembersToControlGroupBusy;
            set
            {
                AllowMembersToControlGroupBusySpecified = true;
                _allowMembersToControlGroupBusy = value;
            }
        }

        [XmlIgnore]
        protected bool AllowMembersToControlGroupBusySpecified { get; set; }

        private bool _enableGroupBusy;

        [XmlElement(ElementName = "enableGroupBusy", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool EnableGroupBusy
        {
            get => _enableGroupBusy;
            set
            {
                EnableGroupBusySpecified = true;
                _enableGroupBusy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableGroupBusySpecified { get; set; }

        private bool _applyGroupBusyWhenTerminatingToAgent;

        [XmlElement(ElementName = "applyGroupBusyWhenTerminatingToAgent", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool ApplyGroupBusyWhenTerminatingToAgent
        {
            get => _applyGroupBusyWhenTerminatingToAgent;
            set
            {
                ApplyGroupBusyWhenTerminatingToAgentSpecified = true;
                _applyGroupBusyWhenTerminatingToAgent = value;
            }
        }

        [XmlIgnore]
        protected bool ApplyGroupBusyWhenTerminatingToAgentSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _service = new List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment>();

        [XmlElement(ElementName = "service", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> Service
        {
            get => _service;
            set
            {
                ServiceSpecified = true;
                _service = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        private List<string> _directoryNumberHuntingAgentUserIdList = new List<string>();

        [XmlElement(ElementName = "directoryNumberHuntingAgentUserIdList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> DirectoryNumberHuntingAgentUserIdList
        {
            get => _directoryNumberHuntingAgentUserIdList;
            set
            {
                DirectoryNumberHuntingAgentUserIdListSpecified = true;
                _directoryNumberHuntingAgentUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool DirectoryNumberHuntingAgentUserIdListSpecified { get; set; }

        private bool _directoryNumberHuntingUseTerminateCallToAgentFirst;

        [XmlElement(ElementName = "directoryNumberHuntingUseTerminateCallToAgentFirst", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool DirectoryNumberHuntingUseTerminateCallToAgentFirst
        {
            get => _directoryNumberHuntingUseTerminateCallToAgentFirst;
            set
            {
                DirectoryNumberHuntingUseTerminateCallToAgentFirstSpecified = true;
                _directoryNumberHuntingUseTerminateCallToAgentFirst = value;
            }
        }

        [XmlIgnore]
        protected bool DirectoryNumberHuntingUseTerminateCallToAgentFirstSpecified { get; set; }

        private bool _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls;

        [XmlElement(ElementName = "directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:105")]
        public bool DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls
        {
            get => _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls;
            set
            {
                DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified = true;
                _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls = value;
            }
        }

        [XmlIgnore]
        protected bool DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified { get; set; }

    }
}
