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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1299""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayGreetingMenuKeys
    {

        protected string _skipBackward;

        [XmlElement(ElementName = "skipBackward", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1299")]
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

        protected string _pauseOrResume;

        [XmlElement(ElementName = "pauseOrResume", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1299")]
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

        protected string _skipForward;

        [XmlElement(ElementName = "skipForward", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1299")]
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

        protected string _jumpToBegin;

        [XmlElement(ElementName = "jumpToBegin", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1299")]
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

        protected string _jumpToEnd;

        [XmlElement(ElementName = "jumpToEnd", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1299")]
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
