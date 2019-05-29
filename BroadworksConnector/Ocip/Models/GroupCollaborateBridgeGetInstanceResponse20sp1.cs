using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeGetInstanceResponse20sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "maximumBridgeParticipants", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants MaximumBridgeParticipants { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "isDefault", IsNullable = false)]
    public bool IsDefault { get; set; }
    [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false)]
    public int MaxCollaborateRoomParticipants { get; set; }
    [XmlElement(ElementName = "supportOutdial", IsNullable = false)]
    public bool SupportOutdial { get; set; }
    [XmlElement(ElementName = "collaborateOwnerUserTable", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.C.OCITable CollaborateOwnerUserTable { get; set; }
 }
}
