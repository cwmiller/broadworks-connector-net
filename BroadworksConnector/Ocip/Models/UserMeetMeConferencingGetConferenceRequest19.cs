using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the information of a conference owned by the user.
    /// The response is either UserMeetMeConferencingGetConferenceResponse19 or ErrorResponse.
    /// <see cref="UserMeetMeConferencingGetConferenceResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:45792""}]")]
    public class UserMeetMeConferencingGetConferenceRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserMeetMeConferencingGetConferenceResponse19>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:45792")]
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
        protected bool UserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey _conferenceKey;

        [XmlElement(ElementName = "conferenceKey", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:45792")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey ConferenceKey
        {
            get => _conferenceKey;
            set
            {
                ConferenceKeySpecified = true;
                _conferenceKey = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceKeySpecified { get; set; }

    }
}
