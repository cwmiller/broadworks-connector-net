using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceResponse14sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint { get; set; }
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
    [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupId", IsNullable = false)]
    public string CapacityExceededRerouteTrunkGroupId { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false)]
    public int CapacityExceededTrapInitialCalls { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false)]
    public int CapacityExceededTrapOffsetCalls { get; set; }
    [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction UnreachableDestinationAction { get; set; }
    [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = false)]
    public string UnreachableDestinationForwardAddress { get; set; }
    [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupId", IsNullable = false)]
    public string UnreachableDestinationRerouteTrunkGroupId { get; set; }
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
 }
}
