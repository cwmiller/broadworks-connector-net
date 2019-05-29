using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupModifyInstanceRequest19sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "trunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "pilotUserId", IsNullable = true)]
    public string PilotUserId { get; set; }
    [XmlElement(ElementName = "department", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department { get; set; }
    [XmlElement(ElementName = "accessDevice", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false)]
    public int MaxActiveCalls { get; set; }
    [XmlElement(ElementName = "maxIncomingCalls", IsNullable = true)]
    public int? MaxIncomingCalls { get; set; }
    [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = true)]
    public int? MaxOutgoingCalls { get; set; }
    [XmlElement(ElementName = "enableBursting", IsNullable = false)]
    public bool EnableBursting { get; set; }
    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = true)]
    public int? BurstingMaxActiveCalls { get; set; }
    [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = true)]
    public int? BurstingMaxIncomingCalls { get; set; }
    [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = true)]
    public int? BurstingMaxOutgoingCalls { get; set; }
    [XmlElement(ElementName = "capacityExceededAction", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCapacityExceededAction? CapacityExceededAction { get; set; }
    [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = true)]
    public string CapacityExceededForwardAddress { get; set; }
    [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey CapacityExceededRerouteTrunkGroupKey { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false)]
    public int CapacityExceededTrapInitialCalls { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false)]
    public int CapacityExceededTrapOffsetCalls { get; set; }
    [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction? UnreachableDestinationAction { get; set; }
    [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = true)]
    public string UnreachableDestinationForwardAddress { get; set; }
    [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey UnreachableDestinationRerouteTrunkGroupKey { get; set; }
    [XmlElement(ElementName = "invitationTimeout", IsNullable = false)]
    public int InvitationTimeout { get; set; }
    [XmlElement(ElementName = "requireAuthentication", IsNullable = false)]
    public bool RequireAuthentication { get; set; }
    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = true)]
    public string SipAuthenticationUserName { get; set; }
    [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = true)]
    public string SipAuthenticationPassword { get; set; }
    [XmlElement(ElementName = "hostedUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList HostedUserIdList { get; set; }
    [XmlElement(ElementName = "trunkGroupIdentity", IsNullable = true)]
    public string TrunkGroupIdentity { get; set; }
    [XmlElement(ElementName = "otgDtgIdentity", IsNullable = true)]
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
    [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction? CallForwardingAlwaysAction { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = true)]
    public string CallForwardingAlwaysForwardAddress { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey CallForwardingAlwaysRerouteTrunkGroupKey { get; set; }
    [XmlElement(ElementName = "peeringDomain", IsNullable = true)]
    public string PeeringDomain { get; set; }
    [XmlElement(ElementName = "routeToPeeringDomain", IsNullable = false)]
    public bool RouteToPeeringDomain { get; set; }
    [XmlElement(ElementName = "prefixEnabled", IsNullable = false)]
    public bool PrefixEnabled { get; set; }
    [XmlElement(ElementName = "prefix", IsNullable = true)]
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
    [XmlElement(ElementName = "implicitRegistrationSetSupportPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupImplicitRegistrationSetSupportPolicy ImplicitRegistrationSetSupportPolicy { get; set; }
    [XmlElement(ElementName = "useSystemImplicitRegistrationSetSupportPolicy", IsNullable = false)]
    public bool UseSystemImplicitRegistrationSetSupportPolicy { get; set; }
    [XmlElement(ElementName = "sipIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy SipIdentityForPilotAndProxyTrunkModesPolicy { get; set; }
    [XmlElement(ElementName = "useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy", IsNullable = false)]
    public bool UseSystemSIPIdentityForPilotAndProxyTrunkModesPolicy { get; set; }
    [XmlElement(ElementName = "useSystemSupportConnectedIdentityPolicy", IsNullable = false)]
    public bool UseSystemSupportConnectedIdentityPolicy { get; set; }
    [XmlElement(ElementName = "supportConnectedIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupSupportConnectedIdentityPolicy SupportConnectedIdentityPolicy { get; set; }
    [XmlElement(ElementName = "useSystemOptionsMessageResponseStatusCodes", IsNullable = false)]
    public bool UseSystemOptionsMessageResponseStatusCodes { get; set; }
    [XmlElement(ElementName = "deleteOptionsMessageResponseStatusCode", IsNullable = false)]
    public List<string> DeleteOptionsMessageResponseStatusCode { get; set; }
 }
}
