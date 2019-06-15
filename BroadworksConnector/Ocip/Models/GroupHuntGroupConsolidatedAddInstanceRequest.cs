using System;
using System.Xml.Serialization;
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
     
    public class GroupHuntGroupConsolidatedAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private bool _addPhoneNumberToGroup;

        [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
        public bool AddPhoneNumberToGroup {
            get => _addPhoneNumberToGroup;
            set {
                AddPhoneNumberToGroupSpecified = true;
                _addPhoneNumberToGroup = value;
            }
        }

        [XmlIgnore]
        public bool AddPhoneNumberToGroupSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy Policy {
            get => _policy;
            set {
                PolicySpecified = true;
                _policy = value;
            }
        }

        [XmlIgnore]
        public bool PolicySpecified { get; set; }
        
        private bool _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        public bool HuntAfterNoAnswer {
            get => _huntAfterNoAnswer;
            set {
                HuntAfterNoAnswerSpecified = true;
                _huntAfterNoAnswer = value;
            }
        }

        [XmlIgnore]
        public bool HuntAfterNoAnswerSpecified { get; set; }
        
        private int _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        public int NoAnswerNumberOfRings {
            get => _noAnswerNumberOfRings;
            set {
                NoAnswerNumberOfRingsSpecified = true;
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool NoAnswerNumberOfRingsSpecified { get; set; }
        
        private bool _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        public bool ForwardAfterTimeout {
            get => _forwardAfterTimeout;
            set {
                ForwardAfterTimeoutSpecified = true;
                _forwardAfterTimeout = value;
            }
        }

        [XmlIgnore]
        public bool ForwardAfterTimeoutSpecified { get; set; }
        
        private int _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int ForwardTimeoutSeconds {
            get => _forwardTimeoutSeconds;
            set {
                ForwardTimeoutSecondsSpecified = true;
                _forwardTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ForwardTimeoutSecondsSpecified { get; set; }
        
        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        public string ForwardToPhoneNumber {
            get => _forwardToPhoneNumber;
            set {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool ForwardToPhoneNumberSpecified { get; set; }
        
        private List<string> _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        public List<string> AgentUserId {
            get => _agentUserId;
            set {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> _agentWeight;

        [XmlElement(ElementName = "agentWeight", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> AgentWeight {
            get => _agentWeight;
            set {
                AgentWeightSpecified = true;
                _agentWeight = value;
            }
        }

        [XmlIgnore]
        public bool AgentWeightSpecified { get; set; }
        
        private bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        public bool AllowCallWaitingForAgents {
            get => _allowCallWaitingForAgents;
            set {
                AllowCallWaitingForAgentsSpecified = true;
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        public bool AllowCallWaitingForAgentsSpecified { get; set; }
        
        private bool _useSystemHuntGroupCLIDSetting;

        [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false, Namespace = "")]
        public bool UseSystemHuntGroupCLIDSetting {
            get => _useSystemHuntGroupCLIDSetting;
            set {
                UseSystemHuntGroupCLIDSettingSpecified = true;
                _useSystemHuntGroupCLIDSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseSystemHuntGroupCLIDSettingSpecified { get; set; }
        
        private bool _includeHuntGroupNameInCLID;

        [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false, Namespace = "")]
        public bool IncludeHuntGroupNameInCLID {
            get => _includeHuntGroupNameInCLID;
            set {
                IncludeHuntGroupNameInCLIDSpecified = true;
                _includeHuntGroupNameInCLID = value;
            }
        }

        [XmlIgnore]
        public bool IncludeHuntGroupNameInCLIDSpecified { get; set; }
        
        private bool _enableNotReachableForwarding;

        [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false, Namespace = "")]
        public bool EnableNotReachableForwarding {
            get => _enableNotReachableForwarding;
            set {
                EnableNotReachableForwardingSpecified = true;
                _enableNotReachableForwarding = value;
            }
        }

        [XmlIgnore]
        public bool EnableNotReachableForwardingSpecified { get; set; }
        
        private string _notReachableForwardToPhoneNumber;

        [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        public string NotReachableForwardToPhoneNumber {
            get => _notReachableForwardToPhoneNumber;
            set {
                NotReachableForwardToPhoneNumberSpecified = true;
                _notReachableForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool NotReachableForwardToPhoneNumberSpecified { get; set; }
        
        private bool _makeBusyWhenNotReachable;

        [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false, Namespace = "")]
        public bool MakeBusyWhenNotReachable {
            get => _makeBusyWhenNotReachable;
            set {
                MakeBusyWhenNotReachableSpecified = true;
                _makeBusyWhenNotReachable = value;
            }
        }

        [XmlIgnore]
        public bool MakeBusyWhenNotReachableSpecified { get; set; }
        
        private bool _allowMembersToControlGroupBusy;

        [XmlElement(ElementName = "allowMembersToControlGroupBusy", IsNullable = false, Namespace = "")]
        public bool AllowMembersToControlGroupBusy {
            get => _allowMembersToControlGroupBusy;
            set {
                AllowMembersToControlGroupBusySpecified = true;
                _allowMembersToControlGroupBusy = value;
            }
        }

        [XmlIgnore]
        public bool AllowMembersToControlGroupBusySpecified { get; set; }
        
        private bool _enableGroupBusy;

        [XmlElement(ElementName = "enableGroupBusy", IsNullable = false, Namespace = "")]
        public bool EnableGroupBusy {
            get => _enableGroupBusy;
            set {
                EnableGroupBusySpecified = true;
                _enableGroupBusy = value;
            }
        }

        [XmlIgnore]
        public bool EnableGroupBusySpecified { get; set; }
        
        private bool _applyGroupBusyWhenTerminatingToAgent;

        [XmlElement(ElementName = "applyGroupBusyWhenTerminatingToAgent", IsNullable = false, Namespace = "")]
        public bool ApplyGroupBusyWhenTerminatingToAgent {
            get => _applyGroupBusyWhenTerminatingToAgent;
            set {
                ApplyGroupBusyWhenTerminatingToAgentSpecified = true;
                _applyGroupBusyWhenTerminatingToAgent = value;
            }
        }

        [XmlIgnore]
        public bool ApplyGroupBusyWhenTerminatingToAgentSpecified { get; set; }
        
        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        public string NetworkClassOfService {
            get => _networkClassOfService;
            set {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _service;

        [XmlElement(ElementName = "service", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> Service {
            get => _service;
            set {
                ServiceSpecified = true;
                _service = value;
            }
        }

        [XmlIgnore]
        public bool ServiceSpecified { get; set; }
        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private List<string> _directoryNumberHuntingAgentUserIdList;

        [XmlElement(ElementName = "directoryNumberHuntingAgentUserIdList", IsNullable = false, Namespace = "")]
        public List<string> DirectoryNumberHuntingAgentUserIdList {
            get => _directoryNumberHuntingAgentUserIdList;
            set {
                DirectoryNumberHuntingAgentUserIdListSpecified = true;
                _directoryNumberHuntingAgentUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool DirectoryNumberHuntingAgentUserIdListSpecified { get; set; }
        
        private bool _directoryNumberHuntingUseTerminateCallToAgentFirst;

        [XmlElement(ElementName = "directoryNumberHuntingUseTerminateCallToAgentFirst", IsNullable = false, Namespace = "")]
        public bool DirectoryNumberHuntingUseTerminateCallToAgentFirst {
            get => _directoryNumberHuntingUseTerminateCallToAgentFirst;
            set {
                DirectoryNumberHuntingUseTerminateCallToAgentFirstSpecified = true;
                _directoryNumberHuntingUseTerminateCallToAgentFirst = value;
            }
        }

        [XmlIgnore]
        public bool DirectoryNumberHuntingUseTerminateCallToAgentFirstSpecified { get; set; }
        
        private bool _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls;

        [XmlElement(ElementName = "directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false, Namespace = "")]
        public bool DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls {
            get => _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls;
            set {
                DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified = true;
                _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls = value;
            }
        }

        [XmlIgnore]
        public bool DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified { get; set; }
        
    }
}
