using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:1010""}]")]
    public class UserCollaborateRoomListGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _roomInstanceTable;

        [XmlElement(ElementName = "roomInstanceTable", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:1010")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoomInstanceTable
        {
            get => _roomInstanceTable;
            set
            {
                RoomInstanceTableSpecified = true;
                _roomInstanceTable = value;
            }
        }

        [XmlIgnore]
        protected bool RoomInstanceTableSpecified { get; set; }

    }
}
