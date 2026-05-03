using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""781bbab86d937537938d4fe917029d5c:190"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""781bbab86d937537938d4fe917029d5c:201""}]}]")]
    public class GroupHuntGroupConsolidatedModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
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

        protected BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel? _unassignPhoneNumbers;

        [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel? UnassignPhoneNumbers
        {
            get => _unassignPhoneNumbers;
            set
            {
                UnassignPhoneNumbersSpecified = (value != null);
                _unassignPhoneNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool UnassignPhoneNumbersSpecified { get; set; }

        protected bool? _addPhoneNumberToGroup;

        [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? AddPhoneNumberToGroup
        {
            get => _addPhoneNumberToGroup;
            set
            {
                AddPhoneNumberToGroupSpecified = (value != null);
                _addPhoneNumberToGroup = value;
            }
        }

        [XmlIgnore]
        protected bool AddPhoneNumberToGroupSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = (value != null);
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HuntPolicy? _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy? Policy
        {
            get => _policy;
            set
            {
                PolicySpecified = (value != null);
                _policy = value;
            }
        }

        [XmlIgnore]
        protected bool PolicySpecified { get; set; }

        protected bool? _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? HuntAfterNoAnswer
        {
            get => _huntAfterNoAnswer;
            set
            {
                HuntAfterNoAnswerSpecified = (value != null);
                _huntAfterNoAnswer = value;
            }
        }

        [XmlIgnore]
        protected bool HuntAfterNoAnswerSpecified { get; set; }

        protected int? _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int? NoAnswerNumberOfRings
        {
            get => _noAnswerNumberOfRings;
            set
            {
                NoAnswerNumberOfRingsSpecified = (value != null);
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerNumberOfRingsSpecified { get; set; }

        protected bool? _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? ForwardAfterTimeout
        {
            get => _forwardAfterTimeout;
            set
            {
                ForwardAfterTimeoutSpecified = (value != null);
                _forwardAfterTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardAfterTimeoutSpecified { get; set; }

        protected int? _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        [MinInclusive(0)]
        [MaxInclusive(7200)]
        public int? ForwardTimeoutSeconds
        {
            get => _forwardTimeoutSeconds;
            set
            {
                ForwardTimeoutSecondsSpecified = (value != null);
                _forwardTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardTimeoutSecondsSpecified { get; set; }

        protected string _forwardToPhoneNumber;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:201")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList
        {
            get => _agentUserIdList;
            set
            {
                AgentUserIdListSpecified = true;
                _agentUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserIdListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementAgentWeightList _agentWeightList;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "agentWeightList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:201")]
        public BroadWorksConnector.Ocip.Models.ReplacementAgentWeightList AgentWeightList
        {
            get => _agentWeightList;
            set
            {
                AgentWeightListSpecified = true;
                _agentWeightList = value;
            }
        }

        [XmlIgnore]
        protected bool AgentWeightListSpecified { get; set; }

        protected bool? _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? AllowCallWaitingForAgents
        {
            get => _allowCallWaitingForAgents;
            set
            {
                AllowCallWaitingForAgentsSpecified = (value != null);
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallWaitingForAgentsSpecified { get; set; }

        protected bool? _useSystemHuntGroupCLIDSetting;

        [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? UseSystemHuntGroupCLIDSetting
        {
            get => _useSystemHuntGroupCLIDSetting;
            set
            {
                UseSystemHuntGroupCLIDSettingSpecified = (value != null);
                _useSystemHuntGroupCLIDSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemHuntGroupCLIDSettingSpecified { get; set; }

        protected bool? _includeHuntGroupNameInCLID;

        [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? IncludeHuntGroupNameInCLID
        {
            get => _includeHuntGroupNameInCLID;
            set
            {
                IncludeHuntGroupNameInCLIDSpecified = (value != null);
                _includeHuntGroupNameInCLID = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeHuntGroupNameInCLIDSpecified { get; set; }

        protected bool? _enableNotReachableForwarding;

        [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? EnableNotReachableForwarding
        {
            get => _enableNotReachableForwarding;
            set
            {
                EnableNotReachableForwardingSpecified = (value != null);
                _enableNotReachableForwarding = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNotReachableForwardingSpecified { get; set; }

        protected string _notReachableForwardToPhoneNumber;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
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

        protected bool? _makeBusyWhenNotReachable;

        [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? MakeBusyWhenNotReachable
        {
            get => _makeBusyWhenNotReachable;
            set
            {
                MakeBusyWhenNotReachableSpecified = (value != null);
                _makeBusyWhenNotReachable = value;
            }
        }

        [XmlIgnore]
        protected bool MakeBusyWhenNotReachableSpecified { get; set; }

        protected bool? _allowMembersToControlGroupBusy;

        [XmlElement(ElementName = "allowMembersToControlGroupBusy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? AllowMembersToControlGroupBusy
        {
            get => _allowMembersToControlGroupBusy;
            set
            {
                AllowMembersToControlGroupBusySpecified = (value != null);
                _allowMembersToControlGroupBusy = value;
            }
        }

        [XmlIgnore]
        protected bool AllowMembersToControlGroupBusySpecified { get; set; }

        protected bool? _enableGroupBusy;

        [XmlElement(ElementName = "enableGroupBusy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? EnableGroupBusy
        {
            get => _enableGroupBusy;
            set
            {
                EnableGroupBusySpecified = (value != null);
                _enableGroupBusy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableGroupBusySpecified { get; set; }

        protected bool? _applyGroupBusyWhenTerminatingToAgent;

        [XmlElement(ElementName = "applyGroupBusyWhenTerminatingToAgent", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? ApplyGroupBusyWhenTerminatingToAgent
        {
            get => _applyGroupBusyWhenTerminatingToAgent;
            set
            {
                ApplyGroupBusyWhenTerminatingToAgentSpecified = (value != null);
                _applyGroupBusyWhenTerminatingToAgent = value;
            }
        }

        [XmlIgnore]
        protected bool ApplyGroupBusyWhenTerminatingToAgentSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = (value != null);
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList _serviceList;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "serviceList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList ServiceList
        {
            get => _serviceList;
            set
            {
                ServiceListSpecified = true;
                _serviceList = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceListSpecified { get; set; }

        protected bool? _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = (value != null);
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _directoryNumberHuntingAgentUserIdList;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "directoryNumberHuntingAgentUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList DirectoryNumberHuntingAgentUserIdList
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

        protected bool? _directoryNumberHuntingUseTerminateCallToAgentFirst;

        [XmlElement(ElementName = "directoryNumberHuntingUseTerminateCallToAgentFirst", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? DirectoryNumberHuntingUseTerminateCallToAgentFirst
        {
            get => _directoryNumberHuntingUseTerminateCallToAgentFirst;
            set
            {
                DirectoryNumberHuntingUseTerminateCallToAgentFirstSpecified = (value != null);
                _directoryNumberHuntingUseTerminateCallToAgentFirst = value;
            }
        }

        [XmlIgnore]
        protected bool DirectoryNumberHuntingUseTerminateCallToAgentFirstSpecified { get; set; }

        protected bool? _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls;

        [XmlElement(ElementName = "directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"781bbab86d937537938d4fe917029d5c:190")]
        public bool? DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls
        {
            get => _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls;
            set
            {
                DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified = (value != null);
                _directoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCalls = value;
            }
        }

        [XmlIgnore]
        protected bool DirectoryNumberHuntingUseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified { get; set; }

    }
}
