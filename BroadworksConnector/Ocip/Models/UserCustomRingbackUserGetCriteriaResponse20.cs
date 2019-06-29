using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCustomRingbackUserGetCriteriaRequest20.
    /// Replaced by: UserCustomRingbackUserGetCriteriaResponse21
    /// <see cref="UserCustomRingbackUserGetCriteriaRequest20"/>
    /// <see cref="UserCustomRingbackUserGetCriteriaResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35664""}]")]
    public class UserCustomRingbackUserGetCriteriaResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

        private bool _blacklisted;

        [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public bool Blacklisted
        {
            get => _blacklisted;
            set
            {
                BlacklistedSpecified = true;
                _blacklisted = value;
            }
        }

        [XmlIgnore]
        protected bool BlacklistedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria
        {
            get => _fromDnCriteria;
            set
            {
                FromDnCriteriaSpecified = true;
                _fromDnCriteria = value;
            }
        }

        [XmlIgnore]
        protected bool FromDnCriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection
        {
            get => _audioSelection;
            set
            {
                AudioSelectionSpecified = true;
                _audioSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AudioSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileSpecified { get; set; }

        private string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileUrl
        {
            get => _audioFileUrl;
            set
            {
                AudioFileUrlSpecified = true;
                _audioFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileUrlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection
        {
            get => _videoSelection;
            set
            {
                VideoSelectionSpecified = true;
                _videoSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VideoSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileSpecified { get; set; }

        private string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileUrl
        {
            get => _videoFileUrl;
            set
            {
                VideoFileUrlSpecified = true;
                _videoFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileUrlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingAudioSelection;

        [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingAudioSelection
        {
            get => _callWaitingAudioSelection;
            set
            {
                CallWaitingAudioSelectionSpecified = true;
                _callWaitingAudioSelection = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingAudioSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _callWaitingAudioFile;

        [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingAudioFile
        {
            get => _callWaitingAudioFile;
            set
            {
                CallWaitingAudioFileSpecified = true;
                _callWaitingAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingAudioFileSpecified { get; set; }

        private string _callWaitingAudioFileUrl;

        [XmlElement(ElementName = "callWaitingAudioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CallWaitingAudioFileUrl
        {
            get => _callWaitingAudioFileUrl;
            set
            {
                CallWaitingAudioFileUrlSpecified = true;
                _callWaitingAudioFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingAudioFileUrlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingVideoSelection;

        [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingVideoSelection
        {
            get => _callWaitingVideoSelection;
            set
            {
                CallWaitingVideoSelectionSpecified = true;
                _callWaitingVideoSelection = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingVideoSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _callWaitingVideoFile;

        [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingVideoFile
        {
            get => _callWaitingVideoFile;
            set
            {
                CallWaitingVideoFileSpecified = true;
                _callWaitingVideoFile = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingVideoFileSpecified { get; set; }

        private string _callWaitingVideoFileUrl;

        [XmlElement(ElementName = "callWaitingVideoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35664")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CallWaitingVideoFileUrl
        {
            get => _callWaitingVideoFileUrl;
            set
            {
                CallWaitingVideoFileUrlSpecified = true;
                _callWaitingVideoFileUrl = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingVideoFileUrlSpecified { get; set; }

    }
}
