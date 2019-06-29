using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing custom greeting audio file.
    /// The response is either SuccessResponse or
    /// ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32810""}]")]
    public class UserMeetMeConferencingModifyConferenceGreetingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32810")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32810")]
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

        private bool _playEntranceGreeting;

        [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32810")]
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

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _entranceGreetingFile;

        [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32810")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource EntranceGreetingFile
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
