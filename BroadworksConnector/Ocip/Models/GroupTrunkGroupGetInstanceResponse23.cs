using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupTrunkGroupGetInstanceRequest23.
    /// Returns the profile information for the Trunk Group.
    /// Contains a hosted user table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number",
    /// "Extension", "Department", "Email Address".
    /// Following attributes are only used in IMS mode:
    /// implicitRegistrationSetSupportPolicy
    /// useSystemImplicitRegistrationSetSupportPolicy
    /// sipIdentityForPilotAndProxyTrunkModesPolicy
    /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
    /// <see cref="GroupTrunkGroupGetInstanceRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1158""}]")]
    public class GroupTrunkGroupGetInstanceResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _pilotUserId;

        [XmlElement(ElementName = "pilotUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PilotUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool DepartmentSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool AccessDeviceSpecified { get; set; }

        private int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool MaxActiveCallsSpecified { get; set; }

        private int _maxIncomingCalls;

        [XmlElement(ElementName = "maxIncomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool MaxIncomingCallsSpecified { get; set; }

        private int _maxOutgoingCalls;

        [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool MaxOutgoingCallsSpecified { get; set; }

        private bool _enableBursting;

        [XmlElement(ElementName = "enableBursting", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool EnableBurstingSpecified { get; set; }

        private int _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool BurstingMaxActiveCallsSpecified { get; set; }

        private int _burstingMaxIncomingCalls;

        [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool BurstingMaxIncomingCallsSpecified { get; set; }

        private int _burstingMaxOutgoingCalls;

        [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool BurstingMaxOutgoingCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction _capacityExceededAction;

        [XmlElement(ElementName = "capacityExceededAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CapacityExceededActionSpecified { get; set; }

        private string _capacityExceededForwardAddress;

        [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CapacityExceededForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _capacityExceededRerouteTrunkGroupKey;

        [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CapacityExceededRerouteTrunkGroupKeySpecified { get; set; }

        private int _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CapacityExceededTrapInitialCallsSpecified { get; set; }

        private int _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CapacityExceededTrapOffsetCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction _unreachableDestinationAction;

        [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UnreachableDestinationActionSpecified { get; set; }

        private string _unreachableDestinationForwardAddress;

        [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UnreachableDestinationForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _unreachableDestinationRerouteTrunkGroupKey;

        [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UnreachableDestinationRerouteTrunkGroupKeySpecified { get; set; }

        private int _invitationTimeout;

        [XmlElement(ElementName = "invitationTimeout", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool InvitationTimeoutSpecified { get; set; }

        private bool _requireAuthentication;

        [XmlElement(ElementName = "requireAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool RequireAuthenticationSpecified { get; set; }

        private string _sipAuthenticationUserName;

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool SipAuthenticationUserNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _hostedUserTable;

        [XmlElement(ElementName = "hostedUserTable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HostedUserTable
        {
            get => _hostedUserTable;
            set
            {
                HostedUserTableSpecified = true;
                _hostedUserTable = value;
            }
        }

        [XmlIgnore]
        public bool HostedUserTableSpecified { get; set; }

        private string _trunkGroupIdentity;

        [XmlElement(ElementName = "trunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool TrunkGroupIdentitySpecified { get; set; }

        private string _otgDtgIdentity;

        [XmlElement(ElementName = "otgDtgIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool OtgDtgIdentitySpecified { get; set; }

        private bool _allowTerminationToTrunkGroupIdentity;

        [XmlElement(ElementName = "allowTerminationToTrunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool AllowTerminationToTrunkGroupIdentitySpecified { get; set; }

        private bool _allowTerminationToDtgIdentity;

        [XmlElement(ElementName = "allowTerminationToDtgIdentity", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool AllowTerminationToDtgIdentitySpecified { get; set; }

        private bool _includeTrunkGroupIdentity;

        [XmlElement(ElementName = "includeTrunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool IncludeTrunkGroupIdentitySpecified { get; set; }

        private bool _includeDtgIdentity;

        [XmlElement(ElementName = "includeDtgIdentity", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool IncludeDtgIdentitySpecified { get; set; }

        private bool _includeTrunkGroupIdentityForNetworkCalls;

        [XmlElement(ElementName = "includeTrunkGroupIdentityForNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool IncludeTrunkGroupIdentityForNetworkCallsSpecified { get; set; }

        private bool _includeOtgIdentityForNetworkCalls;

        [XmlElement(ElementName = "includeOtgIdentityForNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool IncludeOtgIdentityForNetworkCallsSpecified { get; set; }

        private bool _enableNetworkAddressIdentity;

        [XmlElement(ElementName = "enableNetworkAddressIdentity", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool EnableNetworkAddressIdentitySpecified { get; set; }

        private bool _allowUnscreenedCalls;

        [XmlElement(ElementName = "allowUnscreenedCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool AllowUnscreenedCallsSpecified { get; set; }

        private bool _allowUnscreenedEmergencyCalls;

        [XmlElement(ElementName = "allowUnscreenedEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool AllowUnscreenedEmergencyCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy _pilotUserCallingLineIdentityForExternalCallsPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineIdentityForExternalCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PilotUserCallingLineIdentityForExternalCallsPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserChargeNumberUsagePolicy _pilotUserChargeNumberPolicy;

        [XmlElement(ElementName = "pilotUserChargeNumberPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PilotUserChargeNumberPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction _callForwardingAlwaysAction;

        [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CallForwardingAlwaysActionSpecified { get; set; }

        private string _callForwardingAlwaysForwardAddress;

        [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CallForwardingAlwaysForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _callForwardingAlwaysRerouteTrunkGroupKey;

        [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool CallForwardingAlwaysRerouteTrunkGroupKeySpecified { get; set; }

        private string _peeringDomain;

        [XmlElement(ElementName = "peeringDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PeeringDomainSpecified { get; set; }

        private bool _routeToPeeringDomain;

        [XmlElement(ElementName = "routeToPeeringDomain", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool RouteToPeeringDomainSpecified { get; set; }

        private bool _prefixEnabled;

        [XmlElement(ElementName = "prefixEnabled", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PrefixEnabledSpecified { get; set; }

        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PrefixSpecified { get; set; }

        private bool _statefulReroutingEnabled;

        [XmlElement(ElementName = "statefulReroutingEnabled", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool StatefulReroutingEnabledSpecified { get; set; }

        private bool _sendContinuousOptionsMessage;

        [XmlElement(ElementName = "sendContinuousOptionsMessage", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool SendContinuousOptionsMessageSpecified { get; set; }

        private int _continuousOptionsSendingIntervalSeconds;

        [XmlElement(ElementName = "continuousOptionsSendingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool ContinuousOptionsSendingIntervalSecondsSpecified { get; set; }

        private int _failureOptionsSendingIntervalSeconds;

        [XmlElement(ElementName = "failureOptionsSendingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool FailureOptionsSendingIntervalSecondsSpecified { get; set; }

        private int _failureThresholdCounter;

        [XmlElement(ElementName = "failureThresholdCounter", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool FailureThresholdCounterSpecified { get; set; }

        private int _successThresholdCounter;

        [XmlElement(ElementName = "successThresholdCounter", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool SuccessThresholdCounterSpecified { get; set; }

        private int _inviteFailureThresholdCounter;

        [XmlElement(ElementName = "inviteFailureThresholdCounter", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool InviteFailureThresholdCounterSpecified { get; set; }

        private int _inviteFailureThresholdWindowSeconds;

        [XmlElement(ElementName = "inviteFailureThresholdWindowSeconds", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool InviteFailureThresholdWindowSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupState _trunkGroupState;

        [XmlElement(ElementName = "trunkGroupState", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupState TrunkGroupState
        {
            get => _trunkGroupState;
            set
            {
                TrunkGroupStateSpecified = true;
                _trunkGroupState = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupStateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy _pilotUserCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PilotUserCallingLineAssertedIdentityPolicySpecified { get; set; }

        private bool _useSystemCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "useSystemCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UseSystemCallingLineAssertedIdentityPolicySpecified { get; set; }

        private int _totalActiveIncomingCalls;

        [XmlElement(ElementName = "totalActiveIncomingCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
        public int TotalActiveIncomingCalls
        {
            get => _totalActiveIncomingCalls;
            set
            {
                TotalActiveIncomingCallsSpecified = true;
                _totalActiveIncomingCalls = value;
            }
        }

        [XmlIgnore]
        public bool TotalActiveIncomingCallsSpecified { get; set; }

        private int _totalActiveOutgoingCalls;

        [XmlElement(ElementName = "totalActiveOutgoingCalls", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
        public int TotalActiveOutgoingCalls
        {
            get => _totalActiveOutgoingCalls;
            set
            {
                TotalActiveOutgoingCallsSpecified = true;
                _totalActiveOutgoingCalls = value;
            }
        }

        [XmlIgnore]
        public bool TotalActiveOutgoingCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallOptimizationPolicy _pilotUserCallOptimizationPolicy;

        [XmlElement(ElementName = "pilotUserCallOptimizationPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PilotUserCallOptimizationPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy _clidSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool ClidSourceForScreenedCallsPolicySpecified { get; set; }

        private bool _useSystemCLIDSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "useSystemCLIDSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UseSystemCLIDSourceForScreenedCallsPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy _userLookupPolicy;

        [XmlElement(ElementName = "userLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UserLookupPolicySpecified { get; set; }

        private bool _useSystemUserLookupPolicy;

        [XmlElement(ElementName = "useSystemUserLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UseSystemUserLookupPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy _pilotUserCallingLineIdentityForEmergencyCallsPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineIdentityForEmergencyCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool PilotUserCallingLineIdentityForEmergencyCallsPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupImplicitRegistrationSetSupportPolicy _implicitRegistrationSetSupportPolicy;

        [XmlElement(ElementName = "implicitRegistrationSetSupportPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool ImplicitRegistrationSetSupportPolicySpecified { get; set; }

        private bool _useSystemImplicitRegistrationSetSupportPolicy;

        [XmlElement(ElementName = "useSystemImplicitRegistrationSetSupportPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UseSystemImplicitRegistrationSetSupportPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy _sipIdentityForPilotAndProxyTrunkModesPolicy;

        [XmlElement(ElementName = "sipIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool SipIdentityForPilotAndProxyTrunkModesPolicySpecified { get; set; }

        private bool _useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy;

        [XmlElement(ElementName = "useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UseSystemSIPIdentityForPilotAndProxyTrunkModesPolicySpecified { get; set; }

        private bool _useSystemSupportConnectedIdentityPolicy;

        [XmlElement(ElementName = "useSystemSupportConnectedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UseSystemSupportConnectedIdentityPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupSupportConnectedIdentityPolicy _supportConnectedIdentityPolicy;

        [XmlElement(ElementName = "supportConnectedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool SupportConnectedIdentityPolicySpecified { get; set; }

        private bool _useSystemOptionsMessageResponseStatusCodes;

        [XmlElement(ElementName = "useSystemOptionsMessageResponseStatusCodes", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
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
        public bool UseSystemOptionsMessageResponseStatusCodesSpecified { get; set; }

        private List<string> _optionsMessageResponseStatusCode = new List<string>();

        [XmlElement(ElementName = "optionsMessageResponseStatusCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1158")]
        [MinLength(3)]
        [MaxLength(40)]
        public List<string> OptionsMessageResponseStatusCode
        {
            get => _optionsMessageResponseStatusCode;
            set
            {
                OptionsMessageResponseStatusCodeSpecified = true;
                _optionsMessageResponseStatusCode = value;
            }
        }

        [XmlIgnore]
        public bool OptionsMessageResponseStatusCodeSpecified { get; set; }

    }
}
