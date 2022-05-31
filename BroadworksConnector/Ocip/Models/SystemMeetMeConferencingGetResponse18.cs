using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMeetMeConferencingGetRequest18.
    /// <see cref="SystemMeetMeConferencingGetRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27719""}]")]
    public class SystemMeetMeConferencingGetResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _conferenceIdLength;

        [XmlElement(ElementName = "conferenceIdLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        [MinInclusive(6)]
        [MaxInclusive(12)]
        public int ConferenceIdLength
        {
            get => _conferenceIdLength;
            set
            {
                ConferenceIdLengthSpecified = true;
                _conferenceIdLength = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceIdLengthSpecified { get; set; }

        protected int _moderatorPinLength;

        [XmlElement(ElementName = "moderatorPinLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        [MinInclusive(6)]
        [MaxInclusive(12)]
        public int ModeratorPinLength
        {
            get => _moderatorPinLength;
            set
            {
                ModeratorPinLengthSpecified = true;
                _moderatorPinLength = value;
            }
        }

        [XmlIgnore]
        protected bool ModeratorPinLengthSpecified { get; set; }

        protected bool _enableConferenceEndDateRestriction;

        [XmlElement(ElementName = "enableConferenceEndDateRestriction", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public bool EnableConferenceEndDateRestriction
        {
            get => _enableConferenceEndDateRestriction;
            set
            {
                EnableConferenceEndDateRestrictionSpecified = true;
                _enableConferenceEndDateRestriction = value;
            }
        }

        [XmlIgnore]
        protected bool EnableConferenceEndDateRestrictionSpecified { get; set; }

        protected int _conferenceEndDateRestrictionMonths;

        [XmlElement(ElementName = "conferenceEndDateRestrictionMonths", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        [MinInclusive(1)]
        [MaxInclusive(99)]
        public int ConferenceEndDateRestrictionMonths
        {
            get => _conferenceEndDateRestrictionMonths;
            set
            {
                ConferenceEndDateRestrictionMonthsSpecified = true;
                _conferenceEndDateRestrictionMonths = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceEndDateRestrictionMonthsSpecified { get; set; }

        protected bool _deleteExpiredConferencesAfterHoldPeriod;

        [XmlElement(ElementName = "deleteExpiredConferencesAfterHoldPeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public bool DeleteExpiredConferencesAfterHoldPeriod
        {
            get => _deleteExpiredConferencesAfterHoldPeriod;
            set
            {
                DeleteExpiredConferencesAfterHoldPeriodSpecified = true;
                _deleteExpiredConferencesAfterHoldPeriod = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteExpiredConferencesAfterHoldPeriodSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays _expiredConferenceHoldPeriodDays;

        [XmlElement(ElementName = "expiredConferenceHoldPeriodDays", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays ExpiredConferenceHoldPeriodDays
        {
            get => _expiredConferenceHoldPeriodDays;
            set
            {
                ExpiredConferenceHoldPeriodDaysSpecified = true;
                _expiredConferenceHoldPeriodDays = value;
            }
        }

        [XmlIgnore]
        protected bool ExpiredConferenceHoldPeriodDaysSpecified { get; set; }

        protected string _recordingWebAppURL;

        [XmlElement(ElementName = "recordingWebAppURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RecordingWebAppURL
        {
            get => _recordingWebAppURL;
            set
            {
                RecordingWebAppURLSpecified = true;
                _recordingWebAppURL = value;
            }
        }

        [XmlIgnore]
        protected bool RecordingWebAppURLSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingRecordingFileFormat _recordingFileFormat;

        [XmlElement(ElementName = "recordingFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingRecordingFileFormat RecordingFileFormat
        {
            get => _recordingFileFormat;
            set
            {
                RecordingFileFormatSpecified = true;
                _recordingFileFormat = value;
            }
        }

        [XmlIgnore]
        protected bool RecordingFileFormatSpecified { get; set; }

        protected bool _terminateAfterGracePeriod;

        [XmlElement(ElementName = "terminateAfterGracePeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public bool TerminateAfterGracePeriod
        {
            get => _terminateAfterGracePeriod;
            set
            {
                TerminateAfterGracePeriodSpecified = true;
                _terminateAfterGracePeriod = value;
            }
        }

        [XmlIgnore]
        protected bool TerminateAfterGracePeriodSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _conferenceGracePeriodMinutes;

        [XmlElement(ElementName = "conferenceGracePeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration ConferenceGracePeriodMinutes
        {
            get => _conferenceGracePeriodMinutes;
            set
            {
                ConferenceGracePeriodMinutesSpecified = true;
                _conferenceGracePeriodMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceGracePeriodMinutesSpecified { get; set; }

        protected int _conferenceParticipantEarlyEntryMinutes;

        [XmlElement(ElementName = "conferenceParticipantEarlyEntryMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        [MinInclusive(0)]
        [MaxInclusive(15)]
        public int ConferenceParticipantEarlyEntryMinutes
        {
            get => _conferenceParticipantEarlyEntryMinutes;
            set
            {
                ConferenceParticipantEarlyEntryMinutesSpecified = true;
                _conferenceParticipantEarlyEntryMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceParticipantEarlyEntryMinutesSpecified { get; set; }

        protected bool _enableConferenceExpiryNotification;

        [XmlElement(ElementName = "enableConferenceExpiryNotification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public bool EnableConferenceExpiryNotification
        {
            get => _enableConferenceExpiryNotification;
            set
            {
                EnableConferenceExpiryNotificationSpecified = true;
                _enableConferenceExpiryNotification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableConferenceExpiryNotificationSpecified { get; set; }

        protected bool _enableActiveConferenceNotification;

        [XmlElement(ElementName = "enableActiveConferenceNotification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        public bool EnableActiveConferenceNotification
        {
            get => _enableActiveConferenceNotification;
            set
            {
                EnableActiveConferenceNotificationSpecified = true;
                _enableActiveConferenceNotification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableActiveConferenceNotificationSpecified { get; set; }

        protected string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27719")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ConferenceFromAddress
        {
            get => _conferenceFromAddress;
            set
            {
                ConferenceFromAddressSpecified = true;
                _conferenceFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceFromAddressSpecified { get; set; }

    }
}
