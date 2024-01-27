using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete one or more conference recordings owned by the user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:589""}]")]
    public class UserMeetMeConferencingDeleteConferenceRecordingListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:589")]
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

        protected List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceRecordingKey> _recordingKey = new List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceRecordingKey>();

        [XmlElement(ElementName = "recordingKey", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:589")]
        public List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceRecordingKey> RecordingKey
        {
            get => _recordingKey;
            set
            {
                RecordingKeySpecified = true;
                _recordingKey = value;
            }
        }

        [XmlIgnore]
        protected bool RecordingKeySpecified { get; set; }

    }
}
