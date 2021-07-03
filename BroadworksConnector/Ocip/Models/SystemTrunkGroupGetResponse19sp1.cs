using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTrunkGroupGetRequest19sp1.
    /// <see cref="SystemTrunkGroupGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35865""}]")]
    public class SystemTrunkGroupGetResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enforceCLIDServiceAssignmentForPilotUser;

        [XmlElement(ElementName = "enforceCLIDServiceAssignmentForPilotUser", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private bool _terminateUnreachableTriggerDetectionOnReceiptOf18x;

        [XmlElement(ElementName = "terminateUnreachableTriggerDetectionOnReceiptOf18x", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy _pilotUserCallingLineAssertedIdentityPolicy;

        [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private bool _enforceOutOfDialogPBXRedirectionPolicies;

        [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionPolicies", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupUnscreenedRedirectionHandling _unscreenedRedirectionHandling;

        [XmlElement(ElementName = "unscreenedRedirectionHandling", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private bool _enableHoldoverOfHighwaterCallCounts;

        [XmlElement(ElementName = "enableHoldoverOfHighwaterCallCounts", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupHighwaterCallCountHoldoverPeriodMinutes _holdoverPeriod;

        [XmlElement(ElementName = "holdoverPeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupTimeZoneOffsetMinutes _timeZoneOffsetMinutes;

        [XmlElement(ElementName = "timeZoneOffsetMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy _clidSourceForScreenedCallsPolicy;

        [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

        private BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy _userLookupPolicy;

        [XmlElement(ElementName = "userLookupPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35865")]
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

    }
}
