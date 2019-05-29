using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateInstantRoomGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "roomName", IsNullable = false)]
    public string RoomName { get; set; }
    [XmlElement(ElementName = "instantRoomStartTime", IsNullable = false)]
    public string InstantRoomStartTime { get; set; }
    [XmlElement(ElementName = "instantRoomEndTime", IsNullable = false)]
    public string InstantRoomEndTime { get; set; }
 }
}
