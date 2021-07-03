using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Trunk Group instance to a group.
    /// The command will fail if enableNetworkAddressIdentity is set to
    /// true and administrator is not System/Provisioning level administrator.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupTrunkGroupAddInstanceRequest21
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupTrunkGroupAddInstanceRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:13833""}]")]
    public class GroupTrunkGroupAddInstanceRequest20sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
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

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupMultipleContactPilotUser _pilotUser;

        [XmlElement(ElementName = "pilotUser", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupMultipleContactPilotUser PilotUser
        {
            get => _pilotUser;
            set
            {
                PilotUserSpecified = true;
                _pilotUser = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey Department
        {
            get => _department;
            set
            {
                DepartmentSpecified = true;
                _department = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.AccessDevice AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceSpecified { get; set; }

        private int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(1)]
        public int MaxActiveCalls
        {
            get => _maxActiveCalls;
            set
            {
                MaxActiveCallsSpecified = true;
                _maxActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxActiveCallsSpecified { get; set; }

        private int _maxIncomingCalls;

        [XmlElement(ElementName = "maxIncomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int MaxIncomingCalls
        {
            get => _maxIncomingCalls;
            set
            {
                MaxIncomingCallsSpecified = true;
                _maxIncomingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxIncomingCallsSpecified { get; set; }

        private int _maxOutgoingCalls;

        [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int MaxOutgoingCalls
        {
            get => _maxOutgoingCalls;
            set
            {
                MaxOutgoingCallsSpecified = true;
                _maxOutgoingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxOutgoingCallsSpecified { get; set; }

        private bool _enableBursting;

        [XmlElement(ElementName = "enableBursting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool EnableBursting
        {
            get => _enableBursting;
            set
            {
                EnableBurstingSpecified = true;
                _enableBursting = value;
            }
        }

        [XmlIgnore]
        protected bool EnableBurstingSpecified { get; set; }

        private int _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int BurstingMaxActiveCalls
        {
            get => _burstingMaxActiveCalls;
            set
            {
                BurstingMaxActiveCallsSpecified = true;
                _burstingMaxActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool BurstingMaxActiveCallsSpecified { get; set; }

        private int _burstingMaxIncomingCalls;

        [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int BurstingMaxIncomingCalls
        {
            get => _burstingMaxIncomingCalls;
            set
            {
                BurstingMaxIncomingCallsSpecified = true;
                _burstingMaxIncomingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool BurstingMaxIncomingCallsSpecified { get; set; }

        private int _burstingMaxOutgoingCalls;

        [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int BurstingMaxOutgoingCalls
        {
            get => _burstingMaxOutgoingCalls;
            set
            {
                BurstingMaxOutgoingCallsSpecified = true;
                _burstingMaxOutgoingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool BurstingMaxOutgoingCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction _capacityExceededAction;

        [XmlElement(ElementName = "capacityExceededAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction CapacityExceededAction
        {
            get => _capacityExceededAction;
            set
            {
                CapacityExceededActionSpecified = true;
                _capacityExceededAction = value;
            }
        }

        [XmlIgnore]
        protected bool CapacityExceededActionSpecified { get; set; }

        private string _capacityExceededForwardAddress;

        [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(161)]
        public string CapacityExceededForwardAddress
        {
            get => _capacityExceededForwardAddress;
            set
            {
                CapacityExceededForwardAddressSpecified = true;
                _capacityExceededForwardAddress = value;
            }
        }

        [XmlIgnore]
        protected bool CapacityExceededForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _capacityExceededRerouteTrunkGroupKey;

        [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey CapacityExceededRerouteTrunkGroupKey
        {
            get => _capacityExceededRerouteTrunkGroupKey;
            set
            {
                CapacityExceededRerouteTrunkGroupKeySpecified = true;
                _capacityExceededRerouteTrunkGroupKey = value;
            }
        }

        [XmlIgnore]
        protected bool CapacityExceededRerouteTrunkGroupKeySpecified { get; set; }

        private int _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(0)]
        public int CapacityExceededTrapInitialCalls
        {
            get => _capacityExceededTrapInitialCalls;
            set
            {
                CapacityExceededTrapInitialCallsSpecified = true;
                _capacityExceededTrapInitialCalls = value;
            }
        }

        [XmlIgnore]
        protected bool CapacityExceededTrapInitialCallsSpecified { get; set; }

        private int _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(0)]
        public int CapacityExceededTrapOffsetCalls
        {
            get => _capacityExceededTrapOffsetCalls;
            set
            {
                CapacityExceededTrapOffsetCallsSpecified = true;
                _capacityExceededTrapOffsetCalls = value;
            }
        }

        [XmlIgnore]
        protected bool CapacityExceededTrapOffsetCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction _unreachableDestinationAction;

        [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction UnreachableDestinationAction
        {
            get => _unreachableDestinationAction;
            set
            {
                UnreachableDestinationActionSpecified = true;
                _unreachableDestinationAction = value;
            }
        }

        [XmlIgnore]
        protected bool UnreachableDestinationActionSpecified { get; set; }

        private string _unreachableDestinationForwardAddress;

        [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UnreachableDestinationForwardAddress
        {
            get => _unreachableDestinationForwardAddress;
            set
            {
                UnreachableDestinationForwardAddressSpecified = true;
                _unreachableDestinationForwardAddress = value;
            }
        }

        [XmlIgnore]
        protected bool UnreachableDestinationForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _unreachableDestinationRerouteTrunkGroupKey;

        [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey UnreachableDestinationRerouteTrunkGroupKey
        {
            get => _unreachableDestinationRerouteTrunkGroupKey;
            set
            {
                UnreachableDestinationRerouteTrunkGroupKeySpecified = true;
                _unreachableDestinationRerouteTrunkGroupKey = value;
            }
        }

        [XmlIgnore]
        protected bool UnreachableDestinationRerouteTrunkGroupKeySpecified { get; set; }

        private int _invitationTimeout;

        [XmlElement(ElementName = "invitationTimeout", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(1)]
        [MaxInclusive(255)]
        public int InvitationTimeout
        {
            get => _invitationTimeout;
            set
            {
                InvitationTimeoutSpecified = true;
                _invitationTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool InvitationTimeoutSpecified { get; set; }

        private bool _requireAuthentication;

        [XmlElement(ElementName = "requireAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool RequireAuthentication
        {
            get => _requireAuthentication;
            set
            {
                RequireAuthenticationSpecified = true;
                _requireAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool RequireAuthenticationSpecified { get; set; }

        private string _sipAuthenticationUserName;

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SipAuthenticationUserName
        {
            get => _sipAuthenticationUserName;
            set
            {
                SipAuthenticationUserNameSpecified = true;
                _sipAuthenticationUserName = value;
            }
        }

        [XmlIgnore]
        protected bool SipAuthenticationUserNameSpecified { get; set; }

        private string _sipAuthenticationPassword;

        [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(60)]
        public string SipAuthenticationPassword
        {
            get => _sipAuthenticationPassword;
            set
            {
                SipAuthenticationPasswordSpecified = true;
                _sipAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        protected bool SipAuthenticationPasswordSpecified { get; set; }

        private List<string> _hostedUserId = new List<string>();

        [XmlElement(ElementName = "hostedUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> HostedUserId
        {
            get => _hostedUserId;
            set
            {
                HostedUserIdSpecified = true;
                _hostedUserId = value;
            }
        }

        [XmlIgnore]
        protected bool HostedUserIdSpecified { get; set; }

        private string _trunkGroupIdentity;

        [XmlElement(ElementName = "trunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(161)]
        public string TrunkGroupIdentity
        {
            get => _trunkGroupIdentity;
            set
            {
                TrunkGroupIdentitySpecified = true;
                _trunkGroupIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupIdentitySpecified { get; set; }

        private string _otgDtgIdentity;

        [XmlElement(ElementName = "otgDtgIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(80)]
        public string OtgDtgIdentity
        {
            get => _otgDtgIdentity;
            set
            {
                OtgDtgIdentitySpecified = true;
                _otgDtgIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool OtgDtgIdentitySpecified { get; set; }

        private bool _allowTerminationToTrunkGroupIdentity;

        [XmlElement(ElementName = "allowTerminationToTrunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool AllowTerminationToTrunkGroupIdentity
        {
            get => _allowTerminationToTrunkGroupIdentity;
            set
            {
                AllowTerminationToTrunkGroupIdentitySpecified = true;
                _allowTerminationToTrunkGroupIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool AllowTerminationToTrunkGroupIdentitySpecified { get; set; }

        private bool _allowTerminationToDtgIdentity;

        [XmlElement(ElementName = "allowTerminationToDtgIdentity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool AllowTerminationToDtgIdentity
        {
            get => _allowTerminationToDtgIdentity;
            set
            {
                AllowTerminationToDtgIdentitySpecified = true;
                _allowTerminationToDtgIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool AllowTerminationToDtgIdentitySpecified { get; set; }

        private bool _includeTrunkGroupIdentity;

        [XmlElement(ElementName = "includeTrunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool IncludeTrunkGroupIdentity
        {
            get => _includeTrunkGroupIdentity;
            set
            {
                IncludeTrunkGroupIdentitySpecified = true;
                _includeTrunkGroupIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeTrunkGroupIdentitySpecified { get; set; }

        private bool _includeDtgIdentity;

        [XmlElement(ElementName = "includeDtgIdentity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool IncludeDtgIdentity
        {
            get => _includeDtgIdentity;
            set
            {
                IncludeDtgIdentitySpecified = true;
                _includeDtgIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeDtgIdentitySpecified { get; set; }

        private bool _includeTrunkGroupIdentityForNetworkCalls;

        [XmlElement(ElementName = "includeTrunkGroupIdentityForNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool IncludeTrunkGroupIdentityForNetworkCalls
        {
            get => _includeTrunkGroupIdentityForNetworkCalls;
            set
            {
                IncludeTrunkGroupIdentityForNetworkCallsSpecified = true;
                _includeTrunkGroupIdentityForNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeTrunkGroupIdentityForNetworkCallsSpecified { get; set; }

        private bool _includeOtgIdentityForNetworkCalls;

        [XmlElement(ElementName = "includeOtgIdentityForNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool IncludeOtgIdentityForNetworkCalls
        {
            get => _includeOtgIdentityForNetworkCalls;
            set
            {
                IncludeOtgIdentityForNetworkCallsSpecified = true;
                _includeOtgIdentityForNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeOtgIdentityForNetworkCallsSpecified { get; set; }

        private bool _enableNetworkAddressIdentity;

        [XmlElement(ElementName = "enableNetworkAddressIdentity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool EnableNetworkAddressIdentity
        {
            get => _enableNetworkAddressIdentity;
            set
            {
                EnableNetworkAddressIdentitySpecified = true;
                _enableNetworkAddressIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNetworkAddressIdentitySpecified { get; set; }

        private bool _allowUnscreenedCalls;

        [XmlElement(ElementName = "allowUnscreenedCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool AllowUnscreenedCalls
        {
            get => _allowUnscreenedCalls;
            set
            {
                AllowUnscreenedCallsSpecified = true;
                _allowUnscreenedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUnscreenedCallsSpecified { get; set; }

        private bool _allowUnscreenedEmergencyCalls;

        [XmlElement(ElementName = "allowUnscreenedEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool AllowUnscreenedEmergencyCalls
        {
            get => _allowUnscreenedEmergencyCalls;
            set
            {
                AllowUnscreenedEmergencyCallsSpecified = true;
                _allowUnscreenedEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUnscreenedEmergencyCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy _pilotUserCallingLineIdentityForExternalCallsPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineIdentityForExternalCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy PilotUserCallingLineIdentityForExternalCallsPolicy
        {
            get => _pilotUserCallingLineIdentityForExternalCallsPolicy;
            set
            {
                PilotUserCallingLineIdentityForExternalCallsPolicySpecified = true;
                _pilotUserCallingLineIdentityForExternalCallsPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserCallingLineIdentityForExternalCallsPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserChargeNumberUsagePolicy _pilotUserChargeNumberPolicy;

        [XmlElement(ElementName = "pilotUserChargeNumberPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserChargeNumberUsagePolicy PilotUserChargeNumberPolicy
        {
            get => _pilotUserChargeNumberPolicy;
            set
            {
                PilotUserChargeNumberPolicySpecified = true;
                _pilotUserChargeNumberPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserChargeNumberPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction _callForwardingAlwaysAction;

        [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction CallForwardingAlwaysAction
        {
            get => _callForwardingAlwaysAction;
            set
            {
                CallForwardingAlwaysActionSpecified = true;
                _callForwardingAlwaysAction = value;
            }
        }

        [XmlIgnore]
        protected bool CallForwardingAlwaysActionSpecified { get; set; }

        private string _callForwardingAlwaysForwardAddress;

        [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(161)]
        public string CallForwardingAlwaysForwardAddress
        {
            get => _callForwardingAlwaysForwardAddress;
            set
            {
                CallForwardingAlwaysForwardAddressSpecified = true;
                _callForwardingAlwaysForwardAddress = value;
            }
        }

        [XmlIgnore]
        protected bool CallForwardingAlwaysForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _callForwardingAlwaysRerouteTrunkGroupKey;

        [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey CallForwardingAlwaysRerouteTrunkGroupKey
        {
            get => _callForwardingAlwaysRerouteTrunkGroupKey;
            set
            {
                CallForwardingAlwaysRerouteTrunkGroupKeySpecified = true;
                _callForwardingAlwaysRerouteTrunkGroupKey = value;
            }
        }

        [XmlIgnore]
        protected bool CallForwardingAlwaysRerouteTrunkGroupKeySpecified { get; set; }

        private string _peeringDomain;

        [XmlElement(ElementName = "peeringDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PeeringDomain
        {
            get => _peeringDomain;
            set
            {
                PeeringDomainSpecified = true;
                _peeringDomain = value;
            }
        }

        [XmlIgnore]
        protected bool PeeringDomainSpecified { get; set; }

        private bool _routeToPeeringDomain;

        [XmlElement(ElementName = "routeToPeeringDomain", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool RouteToPeeringDomain
        {
            get => _routeToPeeringDomain;
            set
            {
                RouteToPeeringDomainSpecified = true;
                _routeToPeeringDomain = value;
            }
        }

        [XmlIgnore]
        protected bool RouteToPeeringDomainSpecified { get; set; }

        private bool _prefixEnabled;

        [XmlElement(ElementName = "prefixEnabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool PrefixEnabled
        {
            get => _prefixEnabled;
            set
            {
                PrefixEnabledSpecified = true;
                _prefixEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixEnabledSpecified { get; set; }

        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(15)]
        public string Prefix
        {
            get => _prefix;
            set
            {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixSpecified { get; set; }

        private bool _statefulReroutingEnabled;

        [XmlElement(ElementName = "statefulReroutingEnabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool StatefulReroutingEnabled
        {
            get => _statefulReroutingEnabled;
            set
            {
                StatefulReroutingEnabledSpecified = true;
                _statefulReroutingEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool StatefulReroutingEnabledSpecified { get; set; }

        private bool _sendContinuousOptionsMessage;

        [XmlElement(ElementName = "sendContinuousOptionsMessage", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool SendContinuousOptionsMessage
        {
            get => _sendContinuousOptionsMessage;
            set
            {
                SendContinuousOptionsMessageSpecified = true;
                _sendContinuousOptionsMessage = value;
            }
        }

        [XmlIgnore]
        protected bool SendContinuousOptionsMessageSpecified { get; set; }

        private int _continuousOptionsSendingIntervalSeconds;

        [XmlElement(ElementName = "continuousOptionsSendingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(30)]
        [MaxInclusive(86400)]
        public int ContinuousOptionsSendingIntervalSeconds
        {
            get => _continuousOptionsSendingIntervalSeconds;
            set
            {
                ContinuousOptionsSendingIntervalSecondsSpecified = true;
                _continuousOptionsSendingIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ContinuousOptionsSendingIntervalSecondsSpecified { get; set; }

        private int _failureOptionsSendingIntervalSeconds;

        [XmlElement(ElementName = "failureOptionsSendingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(10)]
        [MaxInclusive(86400)]
        public int FailureOptionsSendingIntervalSeconds
        {
            get => _failureOptionsSendingIntervalSeconds;
            set
            {
                FailureOptionsSendingIntervalSecondsSpecified = true;
                _failureOptionsSendingIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool FailureOptionsSendingIntervalSecondsSpecified { get; set; }

        private int _failureThresholdCounter;

        [XmlElement(ElementName = "failureThresholdCounter", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int FailureThresholdCounter
        {
            get => _failureThresholdCounter;
            set
            {
                FailureThresholdCounterSpecified = true;
                _failureThresholdCounter = value;
            }
        }

        [XmlIgnore]
        protected bool FailureThresholdCounterSpecified { get; set; }

        private int _successThresholdCounter;

        [XmlElement(ElementName = "successThresholdCounter", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int SuccessThresholdCounter
        {
            get => _successThresholdCounter;
            set
            {
                SuccessThresholdCounterSpecified = true;
                _successThresholdCounter = value;
            }
        }

        [XmlIgnore]
        protected bool SuccessThresholdCounterSpecified { get; set; }

        private int _inviteFailureThresholdCounter;

        [XmlElement(ElementName = "inviteFailureThresholdCounter", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int InviteFailureThresholdCounter
        {
            get => _inviteFailureThresholdCounter;
            set
            {
                InviteFailureThresholdCounterSpecified = true;
                _inviteFailureThresholdCounter = value;
            }
        }

        [XmlIgnore]
        protected bool InviteFailureThresholdCounterSpecified { get; set; }

        private int _inviteFailureThresholdWindowSeconds;

        [XmlElement(ElementName = "inviteFailureThresholdWindowSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinInclusive(30)]
        [MaxInclusive(240)]
        public int InviteFailureThresholdWindowSeconds
        {
            get => _inviteFailureThresholdWindowSeconds;
            set
            {
                InviteFailureThresholdWindowSecondsSpecified = true;
                _inviteFailureThresholdWindowSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool InviteFailureThresholdWindowSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy _pilotUserCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy PilotUserCallingLineAssertedIdentityPolicy
        {
            get => _pilotUserCallingLineAssertedIdentityPolicy;
            set
            {
                PilotUserCallingLineAssertedIdentityPolicySpecified = true;
                _pilotUserCallingLineAssertedIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserCallingLineAssertedIdentityPolicySpecified { get; set; }

        private bool _useSystemCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "useSystemCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool UseSystemCallingLineAssertedIdentityPolicy
        {
            get => _useSystemCallingLineAssertedIdentityPolicy;
            set
            {
                UseSystemCallingLineAssertedIdentityPolicySpecified = true;
                _useSystemCallingLineAssertedIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemCallingLineAssertedIdentityPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallOptimizationPolicy _pilotUserCallOptimizationPolicy;

        [XmlElement(ElementName = "pilotUserCallOptimizationPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallOptimizationPolicy PilotUserCallOptimizationPolicy
        {
            get => _pilotUserCallOptimizationPolicy;
            set
            {
                PilotUserCallOptimizationPolicySpecified = true;
                _pilotUserCallOptimizationPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserCallOptimizationPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy _clidSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy ClidSourceForScreenedCallsPolicy
        {
            get => _clidSourceForScreenedCallsPolicy;
            set
            {
                ClidSourceForScreenedCallsPolicySpecified = true;
                _clidSourceForScreenedCallsPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool ClidSourceForScreenedCallsPolicySpecified { get; set; }

        private bool _useSystemCLIDSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "useSystemCLIDSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool UseSystemCLIDSourceForScreenedCallsPolicy
        {
            get => _useSystemCLIDSourceForScreenedCallsPolicy;
            set
            {
                UseSystemCLIDSourceForScreenedCallsPolicySpecified = true;
                _useSystemCLIDSourceForScreenedCallsPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemCLIDSourceForScreenedCallsPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy _userLookupPolicy;

        [XmlElement(ElementName = "userLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy UserLookupPolicy
        {
            get => _userLookupPolicy;
            set
            {
                UserLookupPolicySpecified = true;
                _userLookupPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UserLookupPolicySpecified { get; set; }

        private bool _useSystemUserLookupPolicy;

        [XmlElement(ElementName = "useSystemUserLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public bool UseSystemUserLookupPolicy
        {
            get => _useSystemUserLookupPolicy;
            set
            {
                UseSystemUserLookupPolicySpecified = true;
                _useSystemUserLookupPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemUserLookupPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy _pilotUserCallingLineIdentityForEmergencyCallsPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineIdentityForEmergencyCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy PilotUserCallingLineIdentityForEmergencyCallsPolicy
        {
            get => _pilotUserCallingLineIdentityForEmergencyCallsPolicy;
            set
            {
                PilotUserCallingLineIdentityForEmergencyCallsPolicySpecified = true;
                _pilotUserCallingLineIdentityForEmergencyCallsPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserCallingLineIdentityForEmergencyCallsPolicySpecified { get; set; }

        private string _pilotUserNetworkClassOfService;

        [XmlElement(ElementName = "pilotUserNetworkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:13833")]
        [MinLength(1)]
        [MaxLength(40)]
        public string PilotUserNetworkClassOfService
        {
            get => _pilotUserNetworkClassOfService;
            set
            {
                PilotUserNetworkClassOfServiceSpecified = true;
                _pilotUserNetworkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserNetworkClassOfServiceSpecified { get; set; }

    }
}
