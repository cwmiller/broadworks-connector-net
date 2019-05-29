using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupAddInstanceRequest19sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "pilotUser", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupMultipleContactPilotUser PilotUser { get; set; }
    [XmlElement(ElementName = "department", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department { get; set; }
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false)]
    public int MaxActiveCalls { get; set; }
    [XmlElement(ElementName = "maxIncomingCalls", IsNullable = false)]
    public int MaxIncomingCalls { get; set; }
    [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = false)]
    public int MaxOutgoingCalls { get; set; }
    [XmlElement(ElementName = "enableBursting", IsNullable = false)]
    public bool EnableBursting { get; set; }
    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false)]
    public int BurstingMaxActiveCalls { get; set; }
    [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = false)]
    public int BurstingMaxIncomingCalls { get; set; }
    [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = false)]
    public int BurstingMaxOutgoingCalls { get; set; }
    [XmlElement(ElementName = "capacityExceededAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCapacityExceededAction CapacityExceededAction { get; set; }
    [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = false)]
    public string CapacityExceededForwardAddress { get; set; }
    [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey CapacityExceededRerouteTrunkGroupKey { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false)]
    public int CapacityExceededTrapInitialCalls { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false)]
    public int CapacityExceededTrapOffsetCalls { get; set; }
    [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction UnreachableDestinationAction { get; set; }
    [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = false)]
    public string UnreachableDestinationForwardAddress { get; set; }
    [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey UnreachableDestinationRerouteTrunkGroupKey { get; set; }
    [XmlElement(ElementName = "invitationTimeout", IsNullable = false)]
    public int InvitationTimeout { get; set; }
    [XmlElement(ElementName = "requireAuthentication", IsNullable = false)]
    public bool RequireAuthentication { get; set; }
    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false)]
    public string SipAuthenticationUserName { get; set; }
    [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = false)]
    public string SipAuthenticationPassword { get; set; }
    [XmlElement(ElementName = "hostedUserId", IsNullable = false)]
    public List<string> HostedUserId { get; set; }
    [XmlElement(ElementName = "trunkGroupIdentity", IsNullable = false)]
    public string TrunkGroupIdentity { get; set; }
    [XmlElement(ElementName = "otgDtgIdentity", IsNullable = false)]
    public string OtgDtgIdentity { get; set; }
    [XmlElement(ElementName = "allowTerminationToTrunkGroupIdentity", IsNullable = false)]
    public bool AllowTerminationToTrunkGroupIdentity { get; set; }
    [XmlElement(ElementName = "allowTerminationToDtgIdentity", IsNullable = false)]
    public bool AllowTerminationToDtgIdentity { get; set; }
    [XmlElement(ElementName = "includeTrunkGroupIdentity", IsNullable = false)]
    public bool IncludeTrunkGroupIdentity { get; set; }
    [XmlElement(ElementName = "includeDtgIdentity", IsNullable = false)]
    public bool IncludeDtgIdentity { get; set; }
    [XmlElement(ElementName = "includeTrunkGroupIdentityForNetworkCalls", IsNullable = false)]
    public bool IncludeTrunkGroupIdentityForNetworkCalls { get; set; }
    [XmlElement(ElementName = "includeOtgIdentityForNetworkCalls", IsNullable = false)]
    public bool IncludeOtgIdentityForNetworkCalls { get; set; }
    [XmlElement(ElementName = "enableNetworkAddressIdentity", IsNullable = false)]
    public bool EnableNetworkAddressIdentity { get; set; }
    [XmlElement(ElementName = "allowUnscreenedCalls", IsNullable = false)]
    public bool AllowUnscreenedCalls { get; set; }
    [XmlElement(ElementName = "allowUnscreenedEmergencyCalls", IsNullable = false)]
    public bool AllowUnscreenedEmergencyCalls { get; set; }
    [XmlElement(ElementName = "pilotUserCallingLineIdentityForExternalCallsPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy PilotUserCallingLineIdentityForExternalCallsPolicy { get; set; }
    [XmlElement(ElementName = "pilotUserChargeNumberPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserChargeNumberUsagePolicy PilotUserChargeNumberPolicy { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction CallForwardingAlwaysAction { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = false)]
    public string CallForwardingAlwaysForwardAddress { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey CallForwardingAlwaysRerouteTrunkGroupKey { get; set; }
    [XmlElement(ElementName = "peeringDomain", IsNullable = false)]
    public string PeeringDomain { get; set; }
    [XmlElement(ElementName = "routeToPeeringDomain", IsNullable = false)]
    public bool RouteToPeeringDomain { get; set; }
    [XmlElement(ElementName = "prefixEnabled", IsNullable = false)]
    public bool PrefixEnabled { get; set; }
    [XmlElement(ElementName = "prefix", IsNullable = false)]
    public string Prefix { get; set; }
    [XmlElement(ElementName = "statefulReroutingEnabled", IsNullable = false)]
    public bool StatefulReroutingEnabled { get; set; }
    [XmlElement(ElementName = "sendContinuousOptionsMessage", IsNullable = false)]
    public bool SendContinuousOptionsMessage { get; set; }
    [XmlElement(ElementName = "continuousOptionsSendingIntervalSeconds", IsNullable = false)]
    public int ContinuousOptionsSendingIntervalSeconds { get; set; }
    [XmlElement(ElementName = "failureOptionsSendingIntervalSeconds", IsNullable = false)]
    public int FailureOptionsSendingIntervalSeconds { get; set; }
    [XmlElement(ElementName = "failureThresholdCounter", IsNullable = false)]
    public int FailureThresholdCounter { get; set; }
    [XmlElement(ElementName = "successThresholdCounter", IsNullable = false)]
    public int SuccessThresholdCounter { get; set; }
    [XmlElement(ElementName = "inviteFailureThresholdCounter", IsNullable = false)]
    public int InviteFailureThresholdCounter { get; set; }
    [XmlElement(ElementName = "inviteFailureThresholdWindowSeconds", IsNullable = false)]
    public int InviteFailureThresholdWindowSeconds { get; set; }
    [XmlElement(ElementName = "pilotUserCallingLineAssertedIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineAssertedIdentityUsagePolicy PilotUserCallingLineAssertedIdentityPolicy { get; set; }
    [XmlElement(ElementName = "useSystemCallingLineAssertedIdentityPolicy", IsNullable = false)]
    public bool UseSystemCallingLineAssertedIdentityPolicy { get; set; }
    [XmlElement(ElementName = "pilotUserCallOptimizationPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserCallOptimizationPolicy PilotUserCallOptimizationPolicy { get; set; }
    [XmlElement(ElementName = "clidSourceForScreenedCallsPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCLIDSourceForScreenedCallsPolicy ClidSourceForScreenedCallsPolicy { get; set; }
    [XmlElement(ElementName = "useSystemCLIDSourceForScreenedCallsPolicy", IsNullable = false)]
    public bool UseSystemCLIDSourceForScreenedCallsPolicy { get; set; }
    [XmlElement(ElementName = "userLookupPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUserLookupPolicy UserLookupPolicy { get; set; }
    [XmlElement(ElementName = "useSystemUserLookupPolicy", IsNullable = false)]
    public bool UseSystemUserLookupPolicy { get; set; }
    [XmlElement(ElementName = "pilotUserCallingLineIdentityForEmergencyCallsPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy PilotUserCallingLineIdentityForEmergencyCallsPolicy { get; set; }
    [XmlElement(ElementName = "pilotUserNetworkClassOfService", IsNullable = false)]
    public string PilotUserNetworkClassOfService { get; set; }
 }
}
