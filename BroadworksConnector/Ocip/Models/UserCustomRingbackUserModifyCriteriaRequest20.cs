using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a criteria for the user's custom ringback service.
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2e482dcb2fc2f9ef31621d21b9816a42:268""}]")]
    public class UserCustomRingbackUserModifyCriteriaRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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

        protected string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        [MinLength(1)]
        [MaxLength(50)]
        public string CriteriaName
        {
            get => _criteriaName;
            set
            {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaNameSpecified { get; set; }

        protected string _newCriteriaName;

        [XmlElement(ElementName = "newCriteriaName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        [MinLength(1)]
        [MaxLength(50)]
        public string NewCriteriaName
        {
            get => _newCriteriaName;
            set
            {
                NewCriteriaNameSpecified = true;
                _newCriteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool NewCriteriaNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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

        [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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

        protected BroadWorksConnector.Ocip.Models.CriteriaFromDnModify _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDnModify FromDnCriteria
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

        protected BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList _callToNumberList;

        [XmlElement(ElementName = "callToNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        public BroadWorksConnector.Ocip.Models.ReplacementCallToNumberList CallToNumberList
        {
            get => _callToNumberList;
            set
            {
                CallToNumberListSpecified = true;
                _callToNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool CallToNumberListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 AudioFile
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 VideoFile
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingAudioSelection;

        [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _callWaitingAudioFile;

        [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 CallWaitingAudioFile
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

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingVideoSelection;

        [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
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

        protected BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _callWaitingVideoFile;

        [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2e482dcb2fc2f9ef31621d21b9816a42:268")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 CallWaitingVideoFile
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

    }
}
