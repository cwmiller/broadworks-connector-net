using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal announcement menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2325""}]")]
    public class AnnouncementMenuKeysReadEntry
    {

        private string _recordAudio;

        [XmlElement(ElementName = "recordAudio", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2325")]
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

        private string _recordAudioVideo;

        [XmlElement(ElementName = "recordAudioVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2325")]
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

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2325")]
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

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2325")]
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
