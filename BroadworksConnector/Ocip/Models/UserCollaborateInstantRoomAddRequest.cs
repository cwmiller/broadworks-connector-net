using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateInstantRoomAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "roomName", IsNullable = false)]
    public string RoomName { get; set; }
    [XmlElement(ElementName = "useRoomIdAsRoomName", IsNullable = false)]
    public bool UseRoomIdAsRoomName { get; set; }
 }
}
