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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35243""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20AnnouncementRecordingMenuKeys
    {

        private string _acceptRecording;

        [XmlElement(ElementName = "acceptRecording", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35243")]
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
        protected bool AcceptRecordingSpecified { get; set; }

        private string _rejectRerecord;

        [XmlElement(ElementName = "rejectRerecord", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35243")]
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
        protected bool RejectRerecordSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35243")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35243")]
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

        private string _end;

        [XmlElement(ElementName = "end", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35243")]
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
        protected bool EndSpecified { get; set; }

    }
}
