using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCustomRingbackUserGetCriteriaRequest16.
    /// 
    /// Replaced by: UserCustomRingbackUserGetCriteriaResponse20 in AS data mode
    /// <see cref="UserCustomRingbackUserGetCriteriaRequest16"/>
    /// <see cref="UserCustomRingbackUserGetCriteriaResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9bff48d8661ff401ea11b6e32b924f02:346""}]")]
    public class UserCustomRingbackUserGetCriteriaResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected bool _blacklisted;

        [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioFileDescription
        {
            get => _audioFileDescription;
            set
            {
                AudioFileDescriptionSpecified = true;
                _audioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _audioMediaType;

        [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        public BroadWorksConnector.Ocip.Models.MediaFileType AudioMediaType
        {
            get => _audioMediaType;
            set
            {
                AudioMediaTypeSpecified = true;
                _audioMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMediaTypeSpecified { get; set; }

        protected string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoFileDescription
        {
            get => _videoFileDescription;
            set
            {
                VideoFileDescriptionSpecified = true;
                _videoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _videoMediaType;

        [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        public BroadWorksConnector.Ocip.Models.MediaFileType VideoMediaType
        {
            get => _videoMediaType;
            set
            {
                VideoMediaTypeSpecified = true;
                _videoMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMediaTypeSpecified { get; set; }

        protected string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingAudioSelection;

        [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected string _callWaitingAudioFileDescription;

        [XmlElement(ElementName = "callWaitingAudioFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CallWaitingAudioFileDescription
        {
            get => _callWaitingAudioFileDescription;
            set
            {
                CallWaitingAudioFileDescriptionSpecified = true;
                _callWaitingAudioFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingAudioFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _callWaitingAudioMediaType;

        [XmlElement(ElementName = "callWaitingAudioMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        public BroadWorksConnector.Ocip.Models.MediaFileType CallWaitingAudioMediaType
        {
            get => _callWaitingAudioMediaType;
            set
            {
                CallWaitingAudioMediaTypeSpecified = true;
                _callWaitingAudioMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingAudioMediaTypeSpecified { get; set; }

        protected string _callWaitingAudioFileUrl;

        [XmlElement(ElementName = "callWaitingAudioFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingVideoSelection;

        [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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

        protected string _callWaitingVideoFileDescription;

        [XmlElement(ElementName = "callWaitingVideoFileDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CallWaitingVideoFileDescription
        {
            get => _callWaitingVideoFileDescription;
            set
            {
                CallWaitingVideoFileDescriptionSpecified = true;
                _callWaitingVideoFileDescription = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingVideoFileDescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType _callWaitingVideoMediaType;

        [XmlElement(ElementName = "callWaitingVideoMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
        public BroadWorksConnector.Ocip.Models.MediaFileType CallWaitingVideoMediaType
        {
            get => _callWaitingVideoMediaType;
            set
            {
                CallWaitingVideoMediaTypeSpecified = true;
                _callWaitingVideoMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool CallWaitingVideoMediaTypeSpecified { get; set; }

        protected string _callWaitingVideoFileUrl;

        [XmlElement(ElementName = "callWaitingVideoFileUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:346")]
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
