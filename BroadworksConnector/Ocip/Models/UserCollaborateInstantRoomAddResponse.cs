using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCollaborateInstantRoomAddRequest.
    /// <see cref="UserCollaborateInstantRoomAddRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:650""}]")]
    public class UserCollaborateInstantRoomAddResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _roomId;

        [XmlElement(ElementName = "roomId", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:650")]
        [MinLength(4)]
        [MaxLength(15)]
        public string RoomId
        {
            get => _roomId;
            set
            {
                RoomIdSpecified = true;
                _roomId = value;
            }
        }

        [XmlIgnore]
        public bool RoomIdSpecified { get; set; }

    }
}
