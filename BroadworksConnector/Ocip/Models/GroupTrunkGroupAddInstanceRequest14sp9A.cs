using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupAddInstanceRequest14sp9A : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "pilotUser", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUser PilotUser { get; set; }
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
    [XmlElement(ElementName = "unreachableDestinationTrapInitialCalls", IsNullable = false)]
    public int UnreachableDestinationTrapInitialCalls { get; set; }
    [XmlElement(ElementName = "unreachableDestinationTrapOffsetCalls", IsNullable = false)]
    public int UnreachableDestinationTrapOffsetCalls { get; set; }
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
    [XmlElement(ElementName = "includeTrunkGroupIdentity", IsNullable = false)]
    public bool IncludeTrunkGroupIdentity { get; set; }
    [XmlElement(ElementName = "includeDtgIdentity", IsNullable = false)]
    public bool IncludeDtgIdentity { get; set; }
    [XmlElement(ElementName = "enableNetworkAddressIdentity", IsNullable = false)]
    public bool EnableNetworkAddressIdentity { get; set; }
    [XmlElement(ElementName = "allowUnscreenedCalls", IsNullable = false)]
    public bool AllowUnscreenedCalls { get; set; }
    [XmlElement(ElementName = "allowUnscreenedEmergencyCalls", IsNullable = false)]
    public bool AllowUnscreenedEmergencyCalls { get; set; }
    [XmlElement(ElementName = "pilotUserCallingLineIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserCallingLineIdentityUsagePolicy PilotUserCallingLineIdentityPolicy { get; set; }
    [XmlElement(ElementName = "pilotUserChargeNumberPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupPilotUserChargeNumberUsagePolicy PilotUserChargeNumberPolicy { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction CallForwardingAlwaysAction { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = false)]
    public string CallForwardingAlwaysForwardAddress { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey CallForwardingAlwaysRerouteTrunkGroupKey { get; set; }
 }
}
