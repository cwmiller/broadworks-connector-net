using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTrunkGroupGetRequest22.
    /// Following attributes are only used in IMS mode:
    /// implicitRegistrationSetSupportPolicy
    /// sipIdentityForPilotAndProxyTrunkModesPolicy
    /// 
    /// Replaced by: SystemTrunkGroupGetResponse23
    /// <see cref="SystemTrunkGroupGetRequest22"/>
    /// <see cref="SystemTrunkGroupGetResponse23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:42423""}]")]
    public class SystemTrunkGroupGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enforceCLIDServiceAssignmentForPilotUser;

        [XmlElement(ElementName = "enforceCLIDServiceAssignmentForPilotUser", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public bool EnforceCLIDServiceAssignmentForPilotUser
        {
            get => _enforceCLIDServiceAssignmentForPilotUser;
            set
            {
                EnforceCLIDServiceAssignmentForPilotUserSpecified = true;
                _enforceCLIDServiceAssignmentForPilotUser = value;
            }
        }

        [XmlIgnore]
        public bool EnforceCLIDServiceAssignmentForPilotUserSpecified { get; set; }

        private bool _terminateUnreachableTriggerDetectionOnReceiptOf18x;

        [XmlElement(ElementName = "terminateUnreachableTriggerDetectionOnReceiptOf18x", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public bool TerminateUnreachableTriggerDetectionOnReceiptOf18x
        {
            get => _terminateUnreachableTriggerDetectionOnReceiptOf18x;
            set
            {
                TerminateUnreachableTriggerDetectionOnReceiptOf18xSpecified = true;
                _terminateUnreachableTriggerDetectionOnReceiptOf18x = value;
            }
        }

        [XmlIgnore]
        public bool TerminateUnreachableTriggerDetectionOnReceiptOf18xSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy _pilotUserCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
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

        private bool _enforceOutOfDialogPBXRedirectionPolicies;

        [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionPolicies", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public bool EnforceOutOfDialogPBXRedirectionPolicies
        {
            get => _enforceOutOfDialogPBXRedirectionPolicies;
            set
            {
                EnforceOutOfDialogPBXRedirectionPoliciesSpecified = true;
                _enforceOutOfDialogPBXRedirectionPolicies = value;
            }
        }

        [XmlIgnore]
        public bool EnforceOutOfDialogPBXRedirectionPoliciesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupUnscreenedRedirectionHandling _unscreenedRedirectionHandling;

        [XmlElement(ElementName = "unscreenedRedirectionHandling", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUnscreenedRedirectionHandling UnscreenedRedirectionHandling
        {
            get => _unscreenedRedirectionHandling;
            set
            {
                UnscreenedRedirectionHandlingSpecified = true;
                _unscreenedRedirectionHandling = value;
            }
        }

        [XmlIgnore]
        public bool UnscreenedRedirectionHandlingSpecified { get; set; }

        private bool _enableHoldoverOfHighwaterCallCounts;

        [XmlElement(ElementName = "enableHoldoverOfHighwaterCallCounts", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public bool EnableHoldoverOfHighwaterCallCounts
        {
            get => _enableHoldoverOfHighwaterCallCounts;
            set
            {
                EnableHoldoverOfHighwaterCallCountsSpecified = true;
                _enableHoldoverOfHighwaterCallCounts = value;
            }
        }

        [XmlIgnore]
        public bool EnableHoldoverOfHighwaterCallCountsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupHighwaterCallCountHoldoverPeriodMinutes _holdoverPeriod;

        [XmlElement(ElementName = "holdoverPeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupHighwaterCallCountHoldoverPeriodMinutes HoldoverPeriod
        {
            get => _holdoverPeriod;
            set
            {
                HoldoverPeriodSpecified = true;
                _holdoverPeriod = value;
            }
        }

        [XmlIgnore]
        public bool HoldoverPeriodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupTimeZoneOffsetMinutes _timeZoneOffsetMinutes;

        [XmlElement(ElementName = "timeZoneOffsetMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupTimeZoneOffsetMinutes TimeZoneOffsetMinutes
        {
            get => _timeZoneOffsetMinutes;
            set
            {
                TimeZoneOffsetMinutesSpecified = true;
                _timeZoneOffsetMinutes = value;
            }
        }

        [XmlIgnore]
        public bool TimeZoneOffsetMinutesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy _clidSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy _userLookupPolicy;

        [XmlElement(ElementName = "userLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupOutOfDialogPBXRedirectionCLIDMapping _outOfDialogPBXRedirectionCLIDMapping;

        [XmlElement(ElementName = "outOfDialogPBXRedirectionCLIDMapping", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupOutOfDialogPBXRedirectionCLIDMapping OutOfDialogPBXRedirectionCLIDMapping
        {
            get => _outOfDialogPBXRedirectionCLIDMapping;
            set
            {
                OutOfDialogPBXRedirectionCLIDMappingSpecified = true;
                _outOfDialogPBXRedirectionCLIDMapping = value;
            }
        }

        [XmlIgnore]
        public bool OutOfDialogPBXRedirectionCLIDMappingSpecified { get; set; }

        private bool _enforceOutOfDialogPBXRedirectionTrunkGroupCapacity;

        [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionTrunkGroupCapacity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public bool EnforceOutOfDialogPBXRedirectionTrunkGroupCapacity
        {
            get => _enforceOutOfDialogPBXRedirectionTrunkGroupCapacity;
            set
            {
                EnforceOutOfDialogPBXRedirectionTrunkGroupCapacitySpecified = true;
                _enforceOutOfDialogPBXRedirectionTrunkGroupCapacity = value;
            }
        }

        [XmlIgnore]
        public bool EnforceOutOfDialogPBXRedirectionTrunkGroupCapacitySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkGroupImplicitRegistrationSetSupportPolicy _implicitRegistrationSetSupportPolicy;

        [XmlElement(ElementName = "implicitRegistrationSetSupportPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy _sipIdentityForPilotAndProxyTrunkModesPolicy;

        [XmlElement(ElementName = "sipIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupSupportConnectedIdentityPolicy _supportConnectedIdentityPolicy;

        [XmlElement(ElementName = "supportConnectedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
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

        private bool _useUnmappedSessionsForTrunkUsers;

        [XmlElement(ElementName = "useUnmappedSessionsForTrunkUsers", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42423")]
        public bool UseUnmappedSessionsForTrunkUsers
        {
            get => _useUnmappedSessionsForTrunkUsers;
            set
            {
                UseUnmappedSessionsForTrunkUsersSpecified = true;
                _useUnmappedSessionsForTrunkUsers = value;
            }
        }

        [XmlIgnore]
        public bool UseUnmappedSessionsForTrunkUsersSpecified { get; set; }

    }
}
