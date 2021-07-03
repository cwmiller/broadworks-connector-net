using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingGetConferenceRequest.
    /// Contains the information of a conference.
    /// <see cref="UserMeetMeConferencingGetConferenceRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:45206"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:45209""}]}]")]
    public class UserMeetMeConferencingGetConferenceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _title;

        [XmlElement(ElementName = "title", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Title
        {
            get => _title;
            set
            {
                TitleSpecified = true;
                _title = value;
            }
        }

        [XmlIgnore]
        protected bool TitleSpecified { get; set; }

        private int _estimatedParticipants;

        [XmlElement(ElementName = "estimatedParticipants", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        [MinInclusive(1)]
        [MaxInclusive(294)]
        public int EstimatedParticipants
        {
            get => _estimatedParticipants;
            set
            {
                EstimatedParticipantsSpecified = true;
                _estimatedParticipants = value;
            }
        }

        [XmlIgnore]
        protected bool EstimatedParticipantsSpecified { get; set; }

        private bool _restrictParticipants;

        [XmlElement(ElementName = "restrictParticipants", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45209")]
        public bool RestrictParticipants
        {
            get => _restrictParticipants;
            set
            {
                RestrictParticipantsSpecified = true;
                _restrictParticipants = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictParticipantsSpecified { get; set; }

        private int _maxParticipants;

        [XmlElement(ElementName = "maxParticipants", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45209")]
        [MinInclusive(1)]
        [MaxInclusive(294)]
        public int MaxParticipants
        {
            get => _maxParticipants;
            set
            {
                MaxParticipantsSpecified = true;
                _maxParticipants = value;
            }
        }

        [XmlIgnore]
        protected bool MaxParticipantsSpecified { get; set; }

        private string _accountCode;

        [XmlElement(ElementName = "accountCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        [MinLength(1)]
        [MaxLength(50)]
        public string AccountCode
        {
            get => _accountCode;
            set
            {
                AccountCodeSpecified = true;
                _accountCode = value;
            }
        }

        [XmlIgnore]
        protected bool AccountCodeSpecified { get; set; }

        private bool _muteAllAttendeesOnEntry;

        [XmlElement(ElementName = "muteAllAttendeesOnEntry", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        public bool MuteAllAttendeesOnEntry
        {
            get => _muteAllAttendeesOnEntry;
            set
            {
                MuteAllAttendeesOnEntrySpecified = true;
                _muteAllAttendeesOnEntry = value;
            }
        }

        [XmlIgnore]
        protected bool MuteAllAttendeesOnEntrySpecified { get; set; }

        private bool _endConferenceOnModeratorExit;

        [XmlElement(ElementName = "endConferenceOnModeratorExit", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        public bool EndConferenceOnModeratorExit
        {
            get => _endConferenceOnModeratorExit;
            set
            {
                EndConferenceOnModeratorExitSpecified = true;
                _endConferenceOnModeratorExit = value;
            }
        }

        [XmlIgnore]
        protected bool EndConferenceOnModeratorExitSpecified { get; set; }

        private bool _moderatorRequired;

        [XmlElement(ElementName = "moderatorRequired", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        public bool ModeratorRequired
        {
            get => _moderatorRequired;
            set
            {
                ModeratorRequiredSpecified = true;
                _moderatorRequired = value;
            }
        }

        [XmlIgnore]
        protected bool ModeratorRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceAttendeeNotification _attendeeNotification;

        [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceAttendeeNotification AttendeeNotification
        {
            get => _attendeeNotification;
            set
            {
                AttendeeNotificationSpecified = true;
                _attendeeNotification = value;
            }
        }

        [XmlIgnore]
        protected bool AttendeeNotificationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceSchedule _conferenceSchedule;

        [XmlElement(ElementName = "conferenceSchedule", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceSchedule ConferenceSchedule
        {
            get => _conferenceSchedule;
            set
            {
                ConferenceScheduleSpecified = true;
                _conferenceSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceScheduleSpecified { get; set; }

        private string _moderatorPin;

        [XmlElement(ElementName = "moderatorPin", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45206")]
        [MinLength(6)]
        [MaxLength(12)]
        public string ModeratorPin
        {
            get => _moderatorPin;
            set
            {
                ModeratorPinSpecified = true;
                _moderatorPin = value;
            }
        }

        [XmlIgnore]
        protected bool ModeratorPinSpecified { get; set; }

    }
}
