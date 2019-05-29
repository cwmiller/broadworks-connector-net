using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTrunkGroupGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
 }
}
