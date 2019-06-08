using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTrunkGroupGetResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enforceCLIDServiceAssignmentForPilotUser;

    [XmlElement(ElementName = "enforceCLIDServiceAssignmentForPilotUser", IsNullable = false, Namespace = "")]
    public bool EnforceCLIDServiceAssignmentForPilotUser {
        get => _enforceCLIDServiceAssignmentForPilotUser;
        set {
            EnforceCLIDServiceAssignmentForPilotUserSpecified = true;
            _enforceCLIDServiceAssignmentForPilotUser = value;
        }
    }

    [XmlIgnore]
    public bool EnforceCLIDServiceAssignmentForPilotUserSpecified { get; set; }
    private bool _terminateUnreachableTriggerDetectionOnReceiptOf18x;

    [XmlElement(ElementName = "terminateUnreachableTriggerDetectionOnReceiptOf18x", IsNullable = false, Namespace = "")]
    public bool TerminateUnreachableTriggerDetectionOnReceiptOf18x {
        get => _terminateUnreachableTriggerDetectionOnReceiptOf18x;
        set {
            TerminateUnreachableTriggerDetectionOnReceiptOf18xSpecified = true;
            _terminateUnreachableTriggerDetectionOnReceiptOf18x = value;
        }
    }

    [XmlIgnore]
    public bool TerminateUnreachableTriggerDetectionOnReceiptOf18xSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy _pilotUserCallingLineAssertedIdentityPolicy;

    [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy PilotUserCallingLineAssertedIdentityPolicy {
        get => _pilotUserCallingLineAssertedIdentityPolicy;
        set {
            PilotUserCallingLineAssertedIdentityPolicySpecified = true;
            _pilotUserCallingLineAssertedIdentityPolicy = value;
        }
    }

    [XmlIgnore]
    public bool PilotUserCallingLineAssertedIdentityPolicySpecified { get; set; }
    private bool _enforceOutOfDialogPBXRedirectionPolicies;

    [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionPolicies", IsNullable = false, Namespace = "")]
    public bool EnforceOutOfDialogPBXRedirectionPolicies {
        get => _enforceOutOfDialogPBXRedirectionPolicies;
        set {
            EnforceOutOfDialogPBXRedirectionPoliciesSpecified = true;
            _enforceOutOfDialogPBXRedirectionPolicies = value;
        }
    }

    [XmlIgnore]
    public bool EnforceOutOfDialogPBXRedirectionPoliciesSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupUnscreenedRedirectionHandling _unscreenedRedirectionHandling;

    [XmlElement(ElementName = "unscreenedRedirectionHandling", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupUnscreenedRedirectionHandling UnscreenedRedirectionHandling {
        get => _unscreenedRedirectionHandling;
        set {
            UnscreenedRedirectionHandlingSpecified = true;
            _unscreenedRedirectionHandling = value;
        }
    }

    [XmlIgnore]
    public bool UnscreenedRedirectionHandlingSpecified { get; set; }
    private bool _enableHoldoverOfHighwaterCallCounts;

    [XmlElement(ElementName = "enableHoldoverOfHighwaterCallCounts", IsNullable = false, Namespace = "")]
    public bool EnableHoldoverOfHighwaterCallCounts {
        get => _enableHoldoverOfHighwaterCallCounts;
        set {
            EnableHoldoverOfHighwaterCallCountsSpecified = true;
            _enableHoldoverOfHighwaterCallCounts = value;
        }
    }

    [XmlIgnore]
    public bool EnableHoldoverOfHighwaterCallCountsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupHighwaterCallCountHoldoverPeriodMinutes _holdoverPeriod;

    [XmlElement(ElementName = "holdoverPeriod", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupHighwaterCallCountHoldoverPeriodMinutes HoldoverPeriod {
        get => _holdoverPeriod;
        set {
            HoldoverPeriodSpecified = true;
            _holdoverPeriod = value;
        }
    }

    [XmlIgnore]
    public bool HoldoverPeriodSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupTimeZoneOffsetMinutes _timeZoneOffsetMinutes;

    [XmlElement(ElementName = "timeZoneOffsetMinutes", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupTimeZoneOffsetMinutes TimeZoneOffsetMinutes {
        get => _timeZoneOffsetMinutes;
        set {
            TimeZoneOffsetMinutesSpecified = true;
            _timeZoneOffsetMinutes = value;
        }
    }

    [XmlIgnore]
    public bool TimeZoneOffsetMinutesSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy _clidSourceForScreenedCallsPolicy;

    [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy ClidSourceForScreenedCallsPolicy {
        get => _clidSourceForScreenedCallsPolicy;
        set {
            ClidSourceForScreenedCallsPolicySpecified = true;
            _clidSourceForScreenedCallsPolicy = value;
        }
    }

    [XmlIgnore]
    public bool ClidSourceForScreenedCallsPolicySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy _userLookupPolicy;

    [XmlElement(ElementName = "userLookupPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupUserLookupPolicy UserLookupPolicy {
        get => _userLookupPolicy;
        set {
            UserLookupPolicySpecified = true;
            _userLookupPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UserLookupPolicySpecified { get; set; }
}
}
