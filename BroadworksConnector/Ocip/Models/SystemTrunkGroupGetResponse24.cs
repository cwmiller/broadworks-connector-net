using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTrunkGroupGetRequest24.
    /// Following attributes are only used in IMS mode:
    /// implicitRegistrationSetSupportPolicy
    /// sipIdentityForPilotAndProxyTrunkModesPolicy
    /// useMostRecentEntryOnDeflection
    /// <see cref="SystemTrunkGroupGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1735""}]")]
    public class SystemTrunkGroupGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enforceCLIDServiceAssignmentForPilotUser;

        [XmlElement(ElementName = "enforceCLIDServiceAssignmentForPilotUser", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool EnforceCLIDServiceAssignmentForPilotUserSpecified { get; set; }

        protected bool _terminateUnreachableTriggerDetectionOnReceiptOf18x;

        [XmlElement(ElementName = "terminateUnreachableTriggerDetectionOnReceiptOf18x", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool TerminateUnreachableTriggerDetectionOnReceiptOf18xSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy _pilotUserCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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

        protected bool _enforceOutOfDialogPBXRedirectionPolicies;

        [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionPolicies", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool EnforceOutOfDialogPBXRedirectionPoliciesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUnscreenedRedirectionHandling _unscreenedRedirectionHandling;

        [XmlElement(ElementName = "unscreenedRedirectionHandling", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool UnscreenedRedirectionHandlingSpecified { get; set; }

        protected bool _enableHoldoverOfHighwaterCallCounts;

        [XmlElement(ElementName = "enableHoldoverOfHighwaterCallCounts", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool EnableHoldoverOfHighwaterCallCountsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupHighwaterCallCountHoldoverPeriodMinutes _holdoverPeriod;

        [XmlElement(ElementName = "holdoverPeriod", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool HoldoverPeriodSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupTimeZoneOffsetMinutes _timeZoneOffsetMinutes;

        [XmlElement(ElementName = "timeZoneOffsetMinutes", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool TimeZoneOffsetMinutesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy _clidSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy _userLookupPolicy;

        [XmlElement(ElementName = "userLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupOutOfDialogPBXRedirectionCLIDMapping _outOfDialogPBXRedirectionCLIDMapping;

        [XmlElement(ElementName = "outOfDialogPBXRedirectionCLIDMapping", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool OutOfDialogPBXRedirectionCLIDMappingSpecified { get; set; }

        protected bool _enforceOutOfDialogPBXRedirectionTrunkGroupCapacity;

        [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionTrunkGroupCapacity", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool EnforceOutOfDialogPBXRedirectionTrunkGroupCapacitySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupImplicitRegistrationSetSupportPolicy _implicitRegistrationSetSupportPolicy;

        [XmlElement(ElementName = "implicitRegistrationSetSupportPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy _sipIdentityForPilotAndProxyTrunkModesPolicy;

        [XmlElement(ElementName = "sipIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupSupportConnectedIdentityPolicy _supportConnectedIdentityPolicy;

        [XmlElement(ElementName = "supportConnectedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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

        protected bool _useUnmappedSessionsForTrunkUsers;

        [XmlElement(ElementName = "useUnmappedSessionsForTrunkUsers", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
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
        protected bool UseUnmappedSessionsForTrunkUsersSpecified { get; set; }

        protected bool _allowPAILookupForOutOfDialogPBXRedirection;

        [XmlElement(ElementName = "allowPAILookupForOutOfDialogPBXRedirection", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
        public bool AllowPAILookupForOutOfDialogPBXRedirection
        {
            get => _allowPAILookupForOutOfDialogPBXRedirection;
            set
            {
                AllowPAILookupForOutOfDialogPBXRedirectionSpecified = true;
                _allowPAILookupForOutOfDialogPBXRedirection = value;
            }
        }

        [XmlIgnore]
        protected bool AllowPAILookupForOutOfDialogPBXRedirectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupOutOfDialogPBXRedirectionOriginatorLookupPolicy _outOfDialogPBXRedirectionOriginatorLookupPolicy;

        [XmlElement(ElementName = "outOfDialogPBXRedirectionOriginatorLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupOutOfDialogPBXRedirectionOriginatorLookupPolicy OutOfDialogPBXRedirectionOriginatorLookupPolicy
        {
            get => _outOfDialogPBXRedirectionOriginatorLookupPolicy;
            set
            {
                OutOfDialogPBXRedirectionOriginatorLookupPolicySpecified = true;
                _outOfDialogPBXRedirectionOriginatorLookupPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool OutOfDialogPBXRedirectionOriginatorLookupPolicySpecified { get; set; }

        protected bool _allowTrunkIdentityForAllOriginations;

        [XmlElement(ElementName = "allowTrunkIdentityForAllOriginations", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
        public bool AllowTrunkIdentityForAllOriginations
        {
            get => _allowTrunkIdentityForAllOriginations;
            set
            {
                AllowTrunkIdentityForAllOriginationsSpecified = true;
                _allowTrunkIdentityForAllOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool AllowTrunkIdentityForAllOriginationsSpecified { get; set; }

        protected bool _useMostRecentEntryOnDeflection;

        [XmlElement(ElementName = "useMostRecentEntryOnDeflection", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1735")]
        public bool UseMostRecentEntryOnDeflection
        {
            get => _useMostRecentEntryOnDeflection;
            set
            {
                UseMostRecentEntryOnDeflectionSpecified = true;
                _useMostRecentEntryOnDeflection = value;
            }
        }

        [XmlIgnore]
        protected bool UseMostRecentEntryOnDeflectionSpecified { get; set; }

    }
}
