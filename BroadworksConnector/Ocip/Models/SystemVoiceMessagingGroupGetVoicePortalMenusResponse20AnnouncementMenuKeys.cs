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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:38267""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20AnnouncementMenuKeys
    {

        protected string _recordAudio;

        [XmlElement(ElementName = "recordAudio", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38267")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RecordAudio
        {
            get => _recordAudio;
            set
            {
                RecordAudioSpecified = true;
                _recordAudio = value;
            }
        }

        [XmlIgnore]
        protected bool RecordAudioSpecified { get; set; }

        protected string _recordAudioVideo;

        [XmlElement(ElementName = "recordAudioVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38267")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RecordAudioVideo
        {
            get => _recordAudioVideo;
            set
            {
                RecordAudioVideoSpecified = true;
                _recordAudioVideo = value;
            }
        }

        [XmlIgnore]
        protected bool RecordAudioVideoSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38267")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReturnToPreviousMenu
        {
            get => _returnToPreviousMenu;
            set
            {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        protected bool ReturnToPreviousMenuSpecified { get; set; }

        protected string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38267")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

    }
}
