using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing custom greeting audio file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Engineering Note: This command can only be executed from the Execution Server
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0b10bca40a55275de6ba2076c583b7fd:108""}]")]
    public class UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:108")]
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
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:108")]
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

        protected bool _playEntranceGreeting;

        [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:108")]
        public bool PlayEntranceGreeting
        {
            get => _playEntranceGreeting;
            set
            {
                PlayEntranceGreetingSpecified = true;
                _playEntranceGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool PlayEntranceGreetingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LabeledFileNameResource _entranceGreetingFile;

        [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:108")]
        public BroadWorksConnector.Ocip.Models.LabeledFileNameResource EntranceGreetingFile
        {
            get => _entranceGreetingFile;
            set
            {
                EntranceGreetingFileSpecified = true;
                _entranceGreetingFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceGreetingFileSpecified { get; set; }

    }
}
