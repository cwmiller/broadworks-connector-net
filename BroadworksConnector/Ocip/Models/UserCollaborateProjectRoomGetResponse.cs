using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateProjectRoomGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "roomName", IsNullable = false)]
    public string RoomName { get; set; }
    [XmlElement(ElementName = "attendeeNotification", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateRoomAttendeeNotification AttendeeNotification { get; set; }
    [XmlElement(ElementName = "endCollaborateRoomSessionOnOwnerExit", IsNullable = false)]
    public bool EndCollaborateRoomSessionOnOwnerExit { get; set; }
    [XmlElement(ElementName = "ownerRequired", IsNullable = false)]
    public bool OwnerRequired { get; set; }
    [XmlElement(ElementName = "roomSchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateRoomSchedule RoomSchedule { get; set; }
 }
}
