using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Meet-Me Conferencing.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:491""}]")]
    public class SystemMeetMeConferencingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _conferenceIdLength;

        [XmlElement(ElementName = "conferenceIdLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private int _moderatorPinLength;

        [XmlElement(ElementName = "moderatorPinLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private bool _enableConferenceEndDateRestriction;

        [XmlElement(ElementName = "enableConferenceEndDateRestriction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private int _conferenceEndDateRestrictionMonths;

        [XmlElement(ElementName = "conferenceEndDateRestrictionMonths", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private bool _deleteExpiredConferencesAfterHoldPeriod;

        [XmlElement(ElementName = "deleteExpiredConferencesAfterHoldPeriod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays _expiredConferenceHoldPeriodDays;

        [XmlElement(ElementName = "expiredConferenceHoldPeriodDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private string _recordingWebAppURL;

        [XmlElement(ElementName = "recordingWebAppURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingRecordingFileFormat _recordingFileFormat;

        [XmlElement(ElementName = "recordingFileFormat", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private bool _terminateAfterGracePeriod;

        [XmlElement(ElementName = "terminateAfterGracePeriod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _conferenceGracePeriodMinutes;

        [XmlElement(ElementName = "conferenceGracePeriodMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private int _conferenceParticipantEarlyEntryMinutes;

        [XmlElement(ElementName = "conferenceParticipantEarlyEntryMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private bool _enableConferenceExpiryNotification;

        [XmlElement(ElementName = "enableConferenceExpiryNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private bool _enableActiveConferenceNotification;

        [XmlElement(ElementName = "enableActiveConferenceNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private string _conferenceFromAddress;

        [XmlElement(ElementName = "conferenceFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
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

        private int _conferenceActiveTalkerRefreshIntervalSeconds;

        [XmlElement(ElementName = "conferenceActiveTalkerRefreshIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:491")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int ConferenceActiveTalkerRefreshIntervalSeconds
        {
            get => _conferenceActiveTalkerRefreshIntervalSeconds;
            set
            {
                ConferenceActiveTalkerRefreshIntervalSecondsSpecified = true;
                _conferenceActiveTalkerRefreshIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceActiveTalkerRefreshIntervalSecondsSpecified { get; set; }

    }
}
