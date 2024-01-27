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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc805893b9cc7e3e01eec64e9ad62768:684""}]")]
    public class UserCollaborateInstantRoomGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _roomName;

        [XmlElement(ElementName = "roomName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:684")]
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
        protected bool RoomNameSpecified { get; set; }

        protected string _instantRoomStartTime;

        [XmlElement(ElementName = "instantRoomStartTime", IsNullable = false, Namespace = "")]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:684")]
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
        protected bool InstantRoomStartTimeSpecified { get; set; }

        protected string _instantRoomEndTime;

        [XmlElement(ElementName = "instantRoomEndTime", IsNullable = false, Namespace = "")]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:684")]
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
        protected bool InstantRoomEndTimeSpecified { get; set; }

    }
}
