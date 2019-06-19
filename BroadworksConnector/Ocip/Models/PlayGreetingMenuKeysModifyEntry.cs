using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal play greeting menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2907""}]")]
    public class PlayGreetingMenuKeysModifyEntry
    {

        private string _skipBackward;

        [XmlElement(ElementName = "skipBackward", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2907")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SkipBackward
        {
            get => _skipBackward;
            set
            {
                SkipBackwardSpecified = true;
                _skipBackward = value;
            }
        }

        [XmlIgnore]
        public bool SkipBackwardSpecified { get; set; }

        private string _pauseOrResume;

        [XmlElement(ElementName = "pauseOrResume", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2907")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PauseOrResume
        {
            get => _pauseOrResume;
            set
            {
                PauseOrResumeSpecified = true;
                _pauseOrResume = value;
            }
        }

        [XmlIgnore]
        public bool PauseOrResumeSpecified { get; set; }

        private string _skipForward;

        [XmlElement(ElementName = "skipForward", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2907")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SkipForward
        {
            get => _skipForward;
            set
            {
                SkipForwardSpecified = true;
                _skipForward = value;
            }
        }

        [XmlIgnore]
        public bool SkipForwardSpecified { get; set; }

        private string _jumpToBegin;

        [XmlElement(ElementName = "jumpToBegin", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2907")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string JumpToBegin
        {
            get => _jumpToBegin;
            set
            {
                JumpToBeginSpecified = true;
                _jumpToBegin = value;
            }
        }

        [XmlIgnore]
        public bool JumpToBeginSpecified { get; set; }

        private string _jumpToEnd;

        [XmlElement(ElementName = "jumpToEnd", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2907")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string JumpToEnd
        {
            get => _jumpToEnd;
            set
            {
                JumpToEndSpecified = true;
                _jumpToEnd = value;
            }
        }

        [XmlIgnore]
        public bool JumpToEndSpecified { get; set; }

    }
}
