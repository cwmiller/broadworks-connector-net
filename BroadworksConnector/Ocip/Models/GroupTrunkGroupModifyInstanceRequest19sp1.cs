using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Trunk Group Instance in a group.
    /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
    /// The command will fail if enableNetworkAddressIdentity is set and
    /// administrator is not System/Provisioning level administrator.
    /// Following attributes are only used in IMS mode:
    /// implicitRegistrationSetSupportPolicy
    /// useSystemImplicitRegistrationSetSupportPolicy
    /// sipIdentityForPilotAndProxyTrunkModesPolicy
    /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: GroupTrunkGroupModifyInstanceRequest20sp1
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupTrunkGroupModifyInstanceRequest20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:16258""}]")]
    public class GroupTrunkGroupModifyInstanceRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey
        {
            get => _trunkGroupKey;
            set
            {
                TrunkGroupKeySpecified = true;
                _trunkGroupKey = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupKeySpecified { get; set; }

        protected string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        protected bool NewNameSpecified { get; set; }

        protected string _pilotUserId;

        [XmlElement(ElementName = "pilotUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PilotUserId
        {
            get => _pilotUserId;
            set
            {
                PilotUserIdSpecified = true;
                _pilotUserId = value;
            }
        }

        [XmlIgnore]
        protected bool PilotUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int? _maxIncomingCalls;

        [XmlElement(ElementName = "maxIncomingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int? MaxIncomingCalls
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

        protected int? _maxOutgoingCalls;

        [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int? MaxOutgoingCalls
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

        protected bool _enableBursting;

        [XmlElement(ElementName = "enableBursting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int? _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int? BurstingMaxActiveCalls
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

        protected int? _burstingMaxIncomingCalls;

        [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int? BurstingMaxIncomingCalls
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

        protected int? _burstingMaxOutgoingCalls;

        [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinInclusive(0)]
        [MaxInclusive(999999)]
        public int? BurstingMaxOutgoingCalls
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction? _capacityExceededAction;

        [XmlElement(ElementName = "capacityExceededAction", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction? CapacityExceededAction
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

        protected string _capacityExceededForwardAddress;

        [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupKey _capacityExceededRerouteTrunkGroupKey;

        [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction? _unreachableDestinationAction;

        [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction? UnreachableDestinationAction
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

        protected string _unreachableDestinationForwardAddress;

        [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupKey _unreachableDestinationRerouteTrunkGroupKey;

        [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _invitationTimeout;

        [XmlElement(ElementName = "invitationTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _requireAuthentication;

        [XmlElement(ElementName = "requireAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected string _sipAuthenticationUserName;

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected string _sipAuthenticationPassword;

        [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _hostedUserIdList;

        [XmlElement(ElementName = "hostedUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList HostedUserIdList
        {
            get => _hostedUserIdList;
            set
            {
                HostedUserIdListSpecified = true;
                _hostedUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool HostedUserIdListSpecified { get; set; }

        protected string _trunkGroupIdentity;

        [XmlElement(ElementName = "trunkGroupIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected string _otgDtgIdentity;

        [XmlElement(ElementName = "otgDtgIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _allowTerminationToTrunkGroupIdentity;

        [XmlElement(ElementName = "allowTerminationToTrunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _allowTerminationToDtgIdentity;

        [XmlElement(ElementName = "allowTerminationToDtgIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _includeTrunkGroupIdentity;

        [XmlElement(ElementName = "includeTrunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _includeDtgIdentity;

        [XmlElement(ElementName = "includeDtgIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _includeTrunkGroupIdentityForNetworkCalls;

        [XmlElement(ElementName = "includeTrunkGroupIdentityForNetworkCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _includeOtgIdentityForNetworkCalls;

        [XmlElement(ElementName = "includeOtgIdentityForNetworkCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _enableNetworkAddressIdentity;

        [XmlElement(ElementName = "enableNetworkAddressIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _allowUnscreenedCalls;

        [XmlElement(ElementName = "allowUnscreenedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _allowUnscreenedEmergencyCalls;

        [XmlElement(ElementName = "allowUnscreenedEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy _pilotUserCallingLineIdentityForExternalCallsPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineIdentityForExternalCallsPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserChargeNumberUsagePolicy _pilotUserChargeNumberPolicy;

        [XmlElement(ElementName = "pilotUserChargeNumberPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction? _callForwardingAlwaysAction;

        [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction? CallForwardingAlwaysAction
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

        protected string _callForwardingAlwaysForwardAddress;

        [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupKey _callForwardingAlwaysRerouteTrunkGroupKey;

        [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected string _peeringDomain;

        [XmlElement(ElementName = "peeringDomain", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _routeToPeeringDomain;

        [XmlElement(ElementName = "routeToPeeringDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _prefixEnabled;

        [XmlElement(ElementName = "prefixEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _statefulReroutingEnabled;

        [XmlElement(ElementName = "statefulReroutingEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _sendContinuousOptionsMessage;

        [XmlElement(ElementName = "sendContinuousOptionsMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _continuousOptionsSendingIntervalSeconds;

        [XmlElement(ElementName = "continuousOptionsSendingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _failureOptionsSendingIntervalSeconds;

        [XmlElement(ElementName = "failureOptionsSendingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _failureThresholdCounter;

        [XmlElement(ElementName = "failureThresholdCounter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _successThresholdCounter;

        [XmlElement(ElementName = "successThresholdCounter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _inviteFailureThresholdCounter;

        [XmlElement(ElementName = "inviteFailureThresholdCounter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected int _inviteFailureThresholdWindowSeconds;

        [XmlElement(ElementName = "inviteFailureThresholdWindowSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy _pilotUserCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _useSystemCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "useSystemCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallOptimizationPolicy _pilotUserCallOptimizationPolicy;

        [XmlElement(ElementName = "pilotUserCallOptimizationPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy _clidSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _useSystemCLIDSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "useSystemCLIDSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy _userLookupPolicy;

        [XmlElement(ElementName = "userLookupPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected bool _useSystemUserLookupPolicy;

        [XmlElement(ElementName = "useSystemUserLookupPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy _pilotUserCallingLineIdentityForEmergencyCallsPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineIdentityForEmergencyCallsPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupImplicitRegistrationSetSupportPolicy _implicitRegistrationSetSupportPolicy;

        [XmlElement(ElementName = "implicitRegistrationSetSupportPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupImplicitRegistrationSetSupportPolicy ImplicitRegistrationSetSupportPolicy
        {
            get => _implicitRegistrationSetSupportPolicy;
            set
            {
                ImplicitRegistrationSetSupportPolicySpecified = true;
                _implicitRegistrationSetSupportPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool ImplicitRegistrationSetSupportPolicySpecified { get; set; }

        protected bool _useSystemImplicitRegistrationSetSupportPolicy;

        [XmlElement(ElementName = "useSystemImplicitRegistrationSetSupportPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public bool UseSystemImplicitRegistrationSetSupportPolicy
        {
            get => _useSystemImplicitRegistrationSetSupportPolicy;
            set
            {
                UseSystemImplicitRegistrationSetSupportPolicySpecified = true;
                _useSystemImplicitRegistrationSetSupportPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemImplicitRegistrationSetSupportPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy _sipIdentityForPilotAndProxyTrunkModesPolicy;

        [XmlElement(ElementName = "sipIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy SipIdentityForPilotAndProxyTrunkModesPolicy
        {
            get => _sipIdentityForPilotAndProxyTrunkModesPolicy;
            set
            {
                SipIdentityForPilotAndProxyTrunkModesPolicySpecified = true;
                _sipIdentityForPilotAndProxyTrunkModesPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SipIdentityForPilotAndProxyTrunkModesPolicySpecified { get; set; }

        protected bool _useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy;

        [XmlElement(ElementName = "useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public bool UseSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        {
            get => _useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy;
            set
            {
                UseSystemSIPIdentityForPilotAndProxyTrunkModesPolicySpecified = true;
                _useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemSIPIdentityForPilotAndProxyTrunkModesPolicySpecified { get; set; }

        protected bool _useSystemSupportConnectedIdentityPolicy;

        [XmlElement(ElementName = "useSystemSupportConnectedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public bool UseSystemSupportConnectedIdentityPolicy
        {
            get => _useSystemSupportConnectedIdentityPolicy;
            set
            {
                UseSystemSupportConnectedIdentityPolicySpecified = true;
                _useSystemSupportConnectedIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemSupportConnectedIdentityPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupSupportConnectedIdentityPolicy _supportConnectedIdentityPolicy;

        [XmlElement(ElementName = "supportConnectedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupSupportConnectedIdentityPolicy SupportConnectedIdentityPolicy
        {
            get => _supportConnectedIdentityPolicy;
            set
            {
                SupportConnectedIdentityPolicySpecified = true;
                _supportConnectedIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SupportConnectedIdentityPolicySpecified { get; set; }

        protected bool _useSystemOptionsMessageResponseStatusCodes;

        [XmlElement(ElementName = "useSystemOptionsMessageResponseStatusCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        public bool UseSystemOptionsMessageResponseStatusCodes
        {
            get => _useSystemOptionsMessageResponseStatusCodes;
            set
            {
                UseSystemOptionsMessageResponseStatusCodesSpecified = true;
                _useSystemOptionsMessageResponseStatusCodes = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemOptionsMessageResponseStatusCodesSpecified { get; set; }

        protected List<string> _deleteOptionsMessageResponseStatusCode = new List<string>();

        [XmlElement(ElementName = "deleteOptionsMessageResponseStatusCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16258")]
        [MinLength(3)]
        [MaxLength(40)]
        public List<string> DeleteOptionsMessageResponseStatusCode
        {
            get => _deleteOptionsMessageResponseStatusCode;
            set
            {
                DeleteOptionsMessageResponseStatusCodeSpecified = true;
                _deleteOptionsMessageResponseStatusCode = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteOptionsMessageResponseStatusCodeSpecified { get; set; }

    }
}
