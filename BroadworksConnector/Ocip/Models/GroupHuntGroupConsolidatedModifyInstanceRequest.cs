using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Hunt Group instance.
    /// 
    /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting
    /// includeHuntGroupNameInCLID
        /// <see cref="ErrorResponse"/>
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupHuntGroupConsolidatedModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
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
        
        private BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

        [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers {
            get => _unassignPhoneNumbers;
            set {
                UnassignPhoneNumbersSpecified = true;
                _unassignPhoneNumbers = value;
            }
        }

        [XmlIgnore]
        public bool UnassignPhoneNumbersSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile {
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

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
        public string ForwardToPhoneNumber {
            get => _forwardToPhoneNumber;
            set {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool ForwardToPhoneNumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList {
            get => _agentUserIdList;
            set {
                AgentUserIdListSpecified = true;
                _agentUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdListSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementAgentWeightList _agentWeightList;

        [XmlElement(ElementName = "agentWeightList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementAgentWeightList AgentWeightList {
            get => _agentWeightList;
            set {
                AgentWeightListSpecified = true;
                _agentWeightList = value;
            }
        }

        [XmlIgnore]
        public bool AgentWeightListSpecified { get; set; }
        
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

        [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = true, Namespace = "")]
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
        
        private BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList _serviceList;

        [XmlElement(ElementName = "serviceList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList ServiceList {
            get => _serviceList;
            set {
                ServiceListSpecified = true;
                _serviceList = value;
            }
        }

        [XmlIgnore]
        public bool ServiceListSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _directoryNumberHuntingAgentUserIdList;

        [XmlElement(ElementName = "directoryNumberHuntingAgentUserIdList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList DirectoryNumberHuntingAgentUserIdList {
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
