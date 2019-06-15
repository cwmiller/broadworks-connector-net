using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a criteria to the user's custom ringback service.
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCustomRingbackUserAddCriteriaRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        public string CriteriaName {
            get => _criteriaName;
            set {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule {
            get => _timeSchedule;
            set {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
            get => _holidaySchedule;
            set {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }
        
        private bool _blacklisted;

        [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
        public bool Blacklisted {
            get => _blacklisted;
            set {
                BlacklistedSpecified = true;
                _blacklisted = value;
            }
        }

        [XmlIgnore]
        public bool BlacklistedSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

        [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria {
            get => _fromDnCriteria;
            set {
                FromDnCriteriaSpecified = true;
                _fromDnCriteria = value;
            }
        }

        [XmlIgnore]
        public bool FromDnCriteriaSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallToNumber> _callToNumber;

        [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallToNumber> CallToNumber {
            get => _callToNumber;
            set {
                CallToNumberSpecified = true;
                _callToNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallToNumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

        [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection {
            get => _audioSelection;
            set {
                AudioSelectionSpecified = true;
                _audioSelection = value;
            }
        }

        [XmlIgnore]
        public bool AudioSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 AudioFile {
            get => _audioFile;
            set {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

        [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection {
            get => _videoSelection;
            set {
                VideoSelectionSpecified = true;
                _videoSelection = value;
            }
        }

        [XmlIgnore]
        public bool VideoSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 VideoFile {
            get => _videoFile;
            set {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingAudioSelection;

        [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingAudioSelection {
            get => _callWaitingAudioSelection;
            set {
                CallWaitingAudioSelectionSpecified = true;
                _callWaitingAudioSelection = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingAudioSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _callWaitingAudioFile;

        [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 CallWaitingAudioFile {
            get => _callWaitingAudioFile;
            set {
                CallWaitingAudioFileSpecified = true;
                _callWaitingAudioFile = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingAudioFileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingVideoSelection;

        [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingVideoSelection {
            get => _callWaitingVideoSelection;
            set {
                CallWaitingVideoSelectionSpecified = true;
                _callWaitingVideoSelection = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingVideoSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 _callWaitingVideoFile;

        [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedMediaFileLevelResource20 CallWaitingVideoFile {
            get => _callWaitingVideoFile;
            set {
                CallWaitingVideoFileSpecified = true;
                _callWaitingVideoFile = value;
            }
        }

        [XmlIgnore]
        public bool CallWaitingVideoFileSpecified { get; set; }
        
    }
}
