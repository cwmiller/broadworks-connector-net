using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCustomRingbackUserGetCriteriaRequest.
        /// <see cref="UserCustomRingbackUserGetCriteriaRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCustomRingbackUserGetCriteriaResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private string _audioFileDescription;

        [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
        public string AudioFileDescription {
            get => _audioFileDescription;
            set {
                AudioFileDescriptionSpecified = true;
                _audioFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileDescriptionSpecified { get; set; }
        
        private string _audioFileUrl;

        [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
        public string AudioFileUrl {
            get => _audioFileUrl;
            set {
                AudioFileUrlSpecified = true;
                _audioFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileUrlSpecified { get; set; }
        
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
        
        private string _videoFileDescription;

        [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
        public string VideoFileDescription {
            get => _videoFileDescription;
            set {
                VideoFileDescriptionSpecified = true;
                _videoFileDescription = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileDescriptionSpecified { get; set; }
        
        private string _videoFileUrl;

        [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
        public string VideoFileUrl {
            get => _videoFileUrl;
            set {
                VideoFileUrlSpecified = true;
                _videoFileUrl = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileUrlSpecified { get; set; }
        
    }
}
