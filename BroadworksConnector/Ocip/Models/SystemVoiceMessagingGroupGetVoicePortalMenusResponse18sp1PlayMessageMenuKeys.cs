using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37248""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1PlayMessageMenuKeys
    {

        private string _skipBackward;

        [XmlElement(ElementName = "skipBackward", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37248")]
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
        protected bool SkipBackwardSpecified { get; set; }

        private string _pauseOrResume;

        [XmlElement(ElementName = "pauseOrResume", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37248")]
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
        protected bool PauseOrResumeSpecified { get; set; }

        private string _skipForward;

        [XmlElement(ElementName = "skipForward", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37248")]
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
        protected bool SkipForwardSpecified { get; set; }

        private string _jumpToBegin;

        [XmlElement(ElementName = "jumpToBegin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37248")]
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
        protected bool JumpToBeginSpecified { get; set; }

        private string _jumpToEnd;

        [XmlElement(ElementName = "jumpToEnd", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37248")]
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
        protected bool JumpToEndSpecified { get; set; }

    }
}
