using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete one or more conferences which are owned by the user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:609""}]")]
    public class UserMeetMeConferencingDeleteConferenceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:609")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey> _conferenceKey = new List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey>();

        [XmlElement(ElementName = "conferenceKey", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:609")]
        public List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey> ConferenceKey
        {
            get => _conferenceKey;
            set
            {
                ConferenceKeySpecified = true;
                _conferenceKey = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceKeySpecified { get; set; }

    }
}
