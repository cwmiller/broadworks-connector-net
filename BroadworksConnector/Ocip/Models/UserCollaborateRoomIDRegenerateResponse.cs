using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCollaborateRoomIDRegenerateRequest.
        /// <see cref="UserCollaborateRoomIDRegenerateRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCollaborateRoomIDRegenerateResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
