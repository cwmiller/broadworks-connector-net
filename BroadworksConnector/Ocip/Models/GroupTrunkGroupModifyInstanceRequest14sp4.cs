using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupModifyInstanceRequest14sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    [XmlElement(ElementName = "unreachableDestinationTrapInitialCalls", IsNullable = false)]
    public int UnreachableDestinationTrapInitialCalls { get; set; }
    [XmlElement(ElementName = "unreachableDestinationTrapOffsetCalls", IsNullable = false)]
    public int UnreachableDestinationTrapOffsetCalls { get; set; }
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
    [XmlElement(ElementName = "usePilotUserCallingLineIdentity", IsNullable = false)]
    public bool UsePilotUserCallingLineIdentity { get; set; }
    [XmlElement(ElementName = "usePilotUserChargeNumber", IsNullable = false)]
    public bool UsePilotUserChargeNumber { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysAction", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupCallForwardingAlwaysAction? CallForwardingAlwaysAction { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysForwardAddress", IsNullable = true)]
    public string CallForwardingAlwaysForwardAddress { get; set; }
    [XmlElement(ElementName = "callForwardingAlwaysRerouteTrunkGroupKey", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey CallForwardingAlwaysRerouteTrunkGroupKey { get; set; }
 }
}
