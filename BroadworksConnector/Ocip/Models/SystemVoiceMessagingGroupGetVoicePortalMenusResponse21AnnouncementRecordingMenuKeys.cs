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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:719""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21AnnouncementRecordingMenuKeys
    {

        private string _acceptRecording;

        [XmlElement(ElementName = "acceptRecording", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:719")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:719")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:719")]
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
        public bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:719")]
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
        public bool RepeatMenuSpecified { get; set; }

        private string _end;

        [XmlElement(ElementName = "end", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:719")]
        [MinLength(1)]
        [MaxLength(3)]
        [RegularExpression(@"([0-9]|\*|#){0,3}")]
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
