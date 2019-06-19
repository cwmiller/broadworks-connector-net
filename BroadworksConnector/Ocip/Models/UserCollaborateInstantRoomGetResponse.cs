using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCollaborateInstantRoomGetRequest.
    /// <see cref="UserCollaborateInstantRoomGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:684""}]")]
    public class UserCollaborateInstantRoomGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _roomName;

        [XmlElement(ElementName = "roomName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:684")]
        [MinLength(1)]
        [MaxLength(40)]
        public string RoomName
        {
            get => _roomName;
            set
            {
                RoomNameSpecified = true;
                _roomName = value;
            }
        }

        [XmlIgnore]
        public bool RoomNameSpecified { get; set; }

        private string _instantRoomStartTime;

        [XmlElement(ElementName = "instantRoomStartTime", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:684")]
        public string InstantRoomStartTime
        {
            get => _instantRoomStartTime;
            set
            {
                InstantRoomStartTimeSpecified = true;
                _instantRoomStartTime = value;
            }
        }

        [XmlIgnore]
        public bool InstantRoomStartTimeSpecified { get; set; }

        private string _instantRoomEndTime;

        [XmlElement(ElementName = "instantRoomEndTime", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:684")]
        public string InstantRoomEndTime
        {
            get => _instantRoomEndTime;
            set
            {
                InstantRoomEndTimeSpecified = true;
                _instantRoomEndTime = value;
            }
        }

        [XmlIgnore]
        public bool InstantRoomEndTimeSpecified { get; set; }

    }
}
