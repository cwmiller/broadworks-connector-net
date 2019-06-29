using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMeetMeConferencingGetRequest17sp3.
    /// 
    /// Replaced by: SystemMeetMeConferencingGetResponse18
    /// <see cref="SystemMeetMeConferencingGetRequest17sp3"/>
    /// <see cref="SystemMeetMeConferencingGetResponse18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21808""}]")]
    public class SystemMeetMeConferencingGetResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _conferenceIdLength;

        [XmlElement(ElementName = "conferenceIdLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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

        [XmlElement(ElementName = "recordingWebAppURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21808")]
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

    }
}
