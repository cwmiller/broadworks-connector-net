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
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15674""}]")]
    public class GroupTrunkGroupModifyInstanceRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private string _pilotUserId;

        [XmlElement(ElementName = "pilotUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        [XmlElement(ElementName = "accessDevice", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private int? _maxIncomingCalls;

        [XmlElement(ElementName = "maxIncomingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private int? _maxOutgoingCalls;

        [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private bool _enableBursting;

        [XmlElement(ElementName = "enableBursting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private int? _burstingMaxActiveCalls;

        [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private int? _burstingMaxIncomingCalls;

        [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private int? _burstingMaxOutgoingCalls;

        [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupCapacityExceededAction? _capacityExceededAction;

        [XmlElement(ElementName = "capacityExceededAction", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private string _capacityExceededForwardAddress;

        [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction? _unreachableDestinationAction;

        [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private string _unreachableDestinationForwardAddress;

        [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private int _unreachableDestinationTrapInitialCalls;

        [XmlElement(ElementName = "unreachableDestinationTrapInitialCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
        [MinInclusive(0)]
        public int UnreachableDestinationTrapInitialCalls
        {
            get => _unreachableDestinationTrapInitialCalls;
            set
            {
                UnreachableDestinationTrapInitialCallsSpecified = true;
                _unreachableDestinationTrapInitialCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UnreachableDestinationTrapInitialCallsSpecified { get; set; }

        private int _unreachableDestinationTrapOffsetCalls;

        [XmlElement(ElementName = "unreachableDestinationTrapOffsetCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
        [MinInclusive(0)]
        public int UnreachableDestinationTrapOffsetCalls
        {
            get => _unreachableDestinationTrapOffsetCalls;
            set
            {
                UnreachableDestinationTrapOffsetCallsSpecified = true;
                _unreachableDestinationTrapOffsetCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UnreachableDestinationTrapOffsetCallsSpecified { get; set; }

        private int _invitationTimeout;

        [XmlElement(ElementName = "invitationTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _hostedUserIdList;

        [XmlElement(ElementName = "hostedUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private string _trunkGroupIdentity;

        [XmlElement(ElementName = "trunkGroupIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        [XmlElement(ElementName = "otgDtgIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private bool _includeTrunkGroupIdentity;

        [XmlElement(ElementName = "includeTrunkGroupIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private bool _enableNetworkAddressIdentity;

        [XmlElement(ElementName = "enableNetworkAddressIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private bool _usePilotUserCallingLineIdentity;

        [XmlElement(ElementName = "usePilotUserCallingLineIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
        public bool UsePilotUserCallingLineIdentity
        {
            get => _usePilotUserCallingLineIdentity;
            set
            {
                UsePilotUserCallingLineIdentitySpecified = true;
                _usePilotUserCallingLineIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool UsePilotUserCallingLineIdentitySpecified { get; set; }

        private bool _usePilotUserChargeNumber;

        [XmlElement(ElementName = "usePilotUserChargeNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
        public bool UsePilotUserChargeNumber
        {
            get => _usePilotUserChargeNumber;
            set
            {
                UsePilotUserChargeNumberSpecified = true;
                _usePilotUserChargeNumber = value;
            }
        }

        [XmlIgnore]
        protected bool UsePilotUserChargeNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction? _callForwardingAlwaysAction;

        [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        private string _callForwardingAlwaysForwardAddress;

        [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

        [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15674")]
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

    }
}
