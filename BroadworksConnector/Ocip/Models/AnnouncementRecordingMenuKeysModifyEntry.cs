using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AnnouncementRecordingMenuKeysModifyEntry
    {
        private string _acceptRecording;

        [XmlElement(ElementName = "acceptRecording", IsNullable = false, Namespace = "")]
        public string AcceptRecording
        {
            get => _acceptRecording;
            set
            {
                AcceptRecordingSpecified = true;
                _acceptRecording = value;
            }
        }

        [XmlIgnore]
        public bool AcceptRecordingSpecified { get; set; }
        private string _rejectRerecord;

        [XmlElement(ElementName = "rejectRerecord", IsNullable = false, Namespace = "")]
        public string RejectRerecord
        {
            get => _rejectRerecord;
            set
            {
                RejectRerecordSpecified = true;
                _rejectRerecord = value;
            }
        }

        [XmlIgnore]
        public bool RejectRerecordSpecified { get; set; }
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
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
        private string _end;

        [XmlElement(ElementName = "end", IsNullable = false, Namespace = "")]
        public string End
        {
            get => _end;
            set
            {
                EndSpecified = true;
                _end = value;
            }
        }

        [XmlIgnore]
        public bool EndSpecified { get; set; }
    }
}
