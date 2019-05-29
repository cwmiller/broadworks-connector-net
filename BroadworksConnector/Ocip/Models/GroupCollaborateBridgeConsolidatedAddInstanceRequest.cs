using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeConsolidatedAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false)]
    public bool AddPhoneNumberToGroup { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "maximumBridgeParticipants", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants MaximumBridgeParticipants { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false)]
    public int MaxCollaborateRoomParticipants { get; set; }
    [XmlElement(ElementName = "supportOutdial", IsNullable = false)]
    public bool SupportOutdial { get; set; }
    [XmlElement(ElementName = "collaborateOwnerUserId", IsNullable = false)]
    public List<string> CollaborateOwnerUserId { get; set; }
    [XmlElement(ElementName = "service", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> Service { get; set; }
 }
}
