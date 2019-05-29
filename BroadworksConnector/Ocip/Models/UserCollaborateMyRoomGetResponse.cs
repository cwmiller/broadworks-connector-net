using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateMyRoomGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "roomId", IsNullable = false)]
    public string RoomId { get; set; }
    [XmlElement(ElementName = "roomName", IsNullable = false)]
    public string RoomName { get; set; }
    [XmlElement(ElementName = "attendeeNotification", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateRoomAttendeeNotification AttendeeNotification { get; set; }
    [XmlElement(ElementName = "endCollaborateRoomSessionOnOwnerExit", IsNullable = false)]
    public bool EndCollaborateRoomSessionOnOwnerExit { get; set; }
    [XmlElement(ElementName = "ownerRequired", IsNullable = false)]
    public bool OwnerRequired { get; set; }
 }
}
