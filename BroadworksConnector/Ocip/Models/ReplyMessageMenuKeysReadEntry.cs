using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal reply message menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:3056""}]")]
    public class ReplyMessageMenuKeysReadEntry
    {

        private string _sendReplyToCaller;

        [XmlElement(ElementName = "sendReplyToCaller", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3056")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendReplyToCaller
        {
            get => _sendReplyToCaller;
            set
            {
                SendReplyToCallerSpecified = true;
                _sendReplyToCaller = value;
            }
        }

        [XmlIgnore]
        public bool SendReplyToCallerSpecified { get; set; }

        private string _changeCurrentReply;

        [XmlElement(ElementName = "changeCurrentReply", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3056")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeCurrentReply
        {
            get => _changeCurrentReply;
            set
            {
                ChangeCurrentReplySpecified = true;
                _changeCurrentReply = value;
            }
        }

        [XmlIgnore]
        public bool ChangeCurrentReplySpecified { get; set; }

        private string _listenToCurrentReply;

        [XmlElement(ElementName = "listenToCurrentReply", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3056")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCurrentReply
        {
            get => _listenToCurrentReply;
            set
            {
                ListenToCurrentReplySpecified = true;
                _listenToCurrentReply = value;
            }
        }

        [XmlIgnore]
        public bool ListenToCurrentReplySpecified { get; set; }

        private string _setOrClearUrgentIndicator;

        [XmlElement(ElementName = "setOrClearUrgentIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3056")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetOrClearUrgentIndicator
        {
            get => _setOrClearUrgentIndicator;
            set
            {
                SetOrClearUrgentIndicatorSpecified = true;
                _setOrClearUrgentIndicator = value;
            }
        }

        [XmlIgnore]
        public bool SetOrClearUrgentIndicatorSpecified { get; set; }

        private string _setOrClearConfidentialIndicator;

        [XmlElement(ElementName = "setOrClearConfidentialIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3056")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetOrClearConfidentialIndicator
        {
            get => _setOrClearConfidentialIndicator;
            set
            {
                SetOrClearConfidentialIndicatorSpecified = true;
                _setOrClearConfidentialIndicator = value;
            }
        }

        [XmlIgnore]
        public bool SetOrClearConfidentialIndicatorSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3056")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3056")]
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

    }
}
