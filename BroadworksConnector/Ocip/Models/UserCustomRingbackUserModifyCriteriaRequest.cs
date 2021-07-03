using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a criteria for the user's custom ringback service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: UserCustomRingbackUserModifyCriteriaRequest16
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCustomRingbackUserModifyCriteriaRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:42177""}]")]
    public class UserCustomRingbackUserModifyCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private string _newCriteriaName;

        [XmlElement(ElementName = "newCriteriaName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private BroadWorksConnector.Ocip.Models.CriteriaFromDnModify _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResource AudioFile
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResource VideoFile
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingAudioSelection;

        [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResource _callWaitingAudioFile;

        [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResource CallWaitingAudioFile
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingVideoSelection;

        [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedFileResource _callWaitingVideoFile;

        [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42177")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResource CallWaitingVideoFile
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
