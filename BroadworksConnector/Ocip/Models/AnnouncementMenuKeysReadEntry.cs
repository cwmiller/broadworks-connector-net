using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AnnouncementMenuKeysReadEntry
    {
        private string _recordAudio;

        [XmlElement(ElementName = "recordAudio", IsNullable = false, Namespace = "")]
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
        public bool RecordAudioSpecified { get; set; }
        private string _recordAudioVideo;

        [XmlElement(ElementName = "recordAudioVideo", IsNullable = false, Namespace = "")]
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
        public bool RecordAudioVideoSpecified { get; set; }
        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
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
        public bool ReturnToPreviousMenuSpecified { get; set; }
        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
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
        public bool RepeatMenuSpecified { get; set; }
    }
}
