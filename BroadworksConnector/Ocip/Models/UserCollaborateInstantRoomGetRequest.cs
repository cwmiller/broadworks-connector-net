using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the collaborate room settings for an instant room.
    /// The request fails when requesting collaborate room settings for My Room or project rooms.
    /// The response is either UserCollaborateInstantRoomGetResponse or
    /// ErrorResponse.
        /// <see cref="UserCollaborateInstantRoomGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCollaborateInstantRoomGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private string _roomId;

        [XmlElement(ElementName = "roomId", IsNullable = false, Namespace = "")]
        public string RoomId {
            get => _roomId;
            set {
                RoomIdSpecified = true;
                _roomId = value;
            }
        }

        [XmlIgnore]
        public bool RoomIdSpecified { get; set; }
        
    }
}
