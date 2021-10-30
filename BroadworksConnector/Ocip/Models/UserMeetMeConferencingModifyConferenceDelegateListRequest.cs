using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the existing conference delegates list.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:869""}]")]
    public class UserMeetMeConferencingModifyConferenceDelegateListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:869")]
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

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey _conferenceKey;

        [XmlElement(ElementName = "conferenceKey", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:869")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _conferenceDelegateUserList;

        [XmlElement(ElementName = "conferenceDelegateUserList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:869")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList ConferenceDelegateUserList
        {
            get => _conferenceDelegateUserList;
            set
            {
                ConferenceDelegateUserListSpecified = true;
                _conferenceDelegateUserList = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceDelegateUserListSpecified { get; set; }

    }
}
