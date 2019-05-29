using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTrunkGroupGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enforceCLIDServiceAssignmentForPilotUser", IsNullable = false)]
    public bool EnforceCLIDServiceAssignmentForPilotUser { get; set; }
    [XmlElement(ElementName = "terminateUnreachableTriggerDetectionOnReceiptOf18x", IsNullable = false)]
    public bool TerminateUnreachableTriggerDetectionOnReceiptOf18x { get; set; }
    [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy PilotUserCallingLineAssertedIdentityPolicy { get; set; }
    [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionPolicies", IsNullable = false)]
    public bool EnforceOutOfDialogPBXRedirectionPolicies { get; set; }
    [XmlElement(ElementName = "unscreenedRedirectionHandling", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUnscreenedRedirectionHandling UnscreenedRedirectionHandling { get; set; }
    [XmlElement(ElementName = "enableHoldoverOfHighwaterCallCounts", IsNullable = false)]
    public bool EnableHoldoverOfHighwaterCallCounts { get; set; }
    [XmlElement(ElementName = "holdoverPeriod", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupHighwaterCallCountHoldoverPeriodMinutes HoldoverPeriod { get; set; }
    [XmlElement(ElementName = "timeZoneOffsetMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupTimeZoneOffsetMinutes TimeZoneOffsetMinutes { get; set; }
    [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy ClidSourceForScreenedCallsPolicy { get; set; }
    [XmlElement(ElementName = "userLookupPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUserLookupPolicy UserLookupPolicy { get; set; }
    [XmlElement(ElementName = "outOfDialogPBXRedirectionCLIDMapping", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupOutOfDialogPBXRedirectionCLIDMapping OutOfDialogPBXRedirectionCLIDMapping { get; set; }
    [XmlElement(ElementName = "enforceOutOfDialogPBXRedirectionTrunkGroupCapacity", IsNullable = false)]
    public bool EnforceOutOfDialogPBXRedirectionTrunkGroupCapacity { get; set; }
    [XmlElement(ElementName = "implicitRegistrationSetSupportPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupImplicitRegistrationSetSupportPolicy ImplicitRegistrationSetSupportPolicy { get; set; }
    [XmlElement(ElementName = "sipIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy SipIdentityForPilotAndProxyTrunkModesPolicy { get; set; }
    [XmlElement(ElementName = "supportConnectedIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupSupportConnectedIdentityPolicy SupportConnectedIdentityPolicy { get; set; }
    [XmlElement(ElementName = "useUnmappedSessionsForTrunkUsers", IsNullable = false)]
    public bool UseUnmappedSessionsForTrunkUsers { get; set; }
 }
}
