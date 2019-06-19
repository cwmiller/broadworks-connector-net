using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingGetConferenceRequest19.
    /// Contains the information of a conference.
    /// <see cref="UserMeetMeConferencingGetConferenceRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32777"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32781""}]}]")]
    public class UserMeetMeConferencingGetConferenceResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _title;

        [XmlElement(ElementName = "title", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool TitleSpecified { get; set; }

        private int _estimatedParticipants;

        [XmlElement(ElementName = "estimatedParticipants", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool EstimatedParticipantsSpecified { get; set; }

        private bool _restrictParticipants;

        [XmlElement(ElementName = "restrictParticipants", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32781")]
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
        public bool RestrictParticipantsSpecified { get; set; }

        private int _maxParticipants;

        [XmlElement(ElementName = "maxParticipants", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32781")]
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
        public bool MaxParticipantsSpecified { get; set; }

        private string _accountCode;

        [XmlElement(ElementName = "accountCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool AccountCodeSpecified { get; set; }

        private bool _muteAllAttendeesOnEntry;

        [XmlElement(ElementName = "muteAllAttendeesOnEntry", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool MuteAllAttendeesOnEntrySpecified { get; set; }

        private bool _endConferenceOnModeratorExit;

        [XmlElement(ElementName = "endConferenceOnModeratorExit", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool EndConferenceOnModeratorExitSpecified { get; set; }

        private bool _moderatorRequired;

        [XmlElement(ElementName = "moderatorRequired", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool ModeratorRequiredSpecified { get; set; }

        private bool _requireSecurityPin;

        [XmlElement(ElementName = "requireSecurityPin", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
        public bool RequireSecurityPin
        {
            get => _requireSecurityPin;
            set
            {
                RequireSecurityPinSpecified = true;
                _requireSecurityPin = value;
            }
        }

        [XmlIgnore]
        public bool RequireSecurityPinSpecified { get; set; }

        private string _securityPin;

        [XmlElement(ElementName = "securityPin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
        [MinLength(4)]
        [MaxLength(12)]
        public string SecurityPin
        {
            get => _securityPin;
            set
            {
                SecurityPinSpecified = true;
                _securityPin = value;
            }
        }

        [XmlIgnore]
        public bool SecurityPinSpecified { get; set; }

        private bool _allowUniqueIdentifier;

        [XmlElement(ElementName = "allowUniqueIdentifier", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
        public bool AllowUniqueIdentifier
        {
            get => _allowUniqueIdentifier;
            set
            {
                AllowUniqueIdentifierSpecified = true;
                _allowUniqueIdentifier = value;
            }
        }

        [XmlIgnore]
        public bool AllowUniqueIdentifierSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceAttendeeNotification _attendeeNotification;

        [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool AttendeeNotificationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceSchedule _conferenceSchedule;

        [XmlElement(ElementName = "conferenceSchedule", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool ConferenceScheduleSpecified { get; set; }

        private string _moderatorPin;

        [XmlElement(ElementName = "moderatorPin", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32777")]
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
        public bool ModeratorPinSpecified { get; set; }

    }
}
