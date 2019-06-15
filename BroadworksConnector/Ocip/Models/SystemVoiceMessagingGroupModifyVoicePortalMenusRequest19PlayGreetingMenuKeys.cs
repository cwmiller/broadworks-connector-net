using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayGreetingMenuKeys 
    {

        
        private string _skipBackward;

        [XmlElement(ElementName = "skipBackward", IsNullable = true, Namespace = "")]
        public string SkipBackward {
            get => _skipBackward;
            set {
                SkipBackwardSpecified = true;
                _skipBackward = value;
            }
        }

        [XmlIgnore]
        public bool SkipBackwardSpecified { get; set; }
        
        private string _pauseOrResume;

        [XmlElement(ElementName = "pauseOrResume", IsNullable = true, Namespace = "")]
        public string PauseOrResume {
            get => _pauseOrResume;
            set {
                PauseOrResumeSpecified = true;
                _pauseOrResume = value;
            }
        }

        [XmlIgnore]
        public bool PauseOrResumeSpecified { get; set; }
        
        private string _skipForward;

        [XmlElement(ElementName = "skipForward", IsNullable = true, Namespace = "")]
        public string SkipForward {
            get => _skipForward;
            set {
                SkipForwardSpecified = true;
                _skipForward = value;
            }
        }

        [XmlIgnore]
        public bool SkipForwardSpecified { get; set; }
        
        private string _jumpToBegin;

        [XmlElement(ElementName = "jumpToBegin", IsNullable = true, Namespace = "")]
        public string JumpToBegin {
            get => _jumpToBegin;
            set {
                JumpToBeginSpecified = true;
                _jumpToBegin = value;
            }
        }

        [XmlIgnore]
        public bool JumpToBeginSpecified { get; set; }
        
        private string _jumpToEnd;

        [XmlElement(ElementName = "jumpToEnd", IsNullable = true, Namespace = "")]
        public string JumpToEnd {
            get => _jumpToEnd;
            set {
                JumpToEndSpecified = true;
                _jumpToEnd = value;
            }
        }

        [XmlIgnore]
        public bool JumpToEndSpecified { get; set; }
        
    }
}
