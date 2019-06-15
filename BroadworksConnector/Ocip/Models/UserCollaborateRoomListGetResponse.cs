using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCollaborateRoomListGetRequest.
    /// Contains a table with column headings :  "Room Type", "Name", "Room Id",
    /// in a row for each collaborate room instance.
    /// Possible values for Room Type column are MyRoom, Project Room and
    /// Instant Room.
        /// <see cref="UserCollaborateRoomListGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCollaborateRoomListGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _roomInstanceTable;

        [XmlElement(ElementName = "roomInstanceTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoomInstanceTable {
            get => _roomInstanceTable;
            set {
                RoomInstanceTableSpecified = true;
                _roomInstanceTable = value;
            }
        }

        [XmlIgnore]
        public bool RoomInstanceTableSpecified { get; set; }
        
    }
}
