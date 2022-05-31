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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1427""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PlayMessagesMenuKeys
    {

        protected string _saveMessage;

        [XmlElement(ElementName = "saveMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SaveMessage
        {
            get => _saveMessage;
            set
            {
                SaveMessageSpecified = true;
                _saveMessage = value;
            }
        }

        [XmlIgnore]
        protected bool SaveMessageSpecified { get; set; }

        protected string _deleteMessage;

        [XmlElement(ElementName = "deleteMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeleteMessage
        {
            get => _deleteMessage;
            set
            {
                DeleteMessageSpecified = true;
                _deleteMessage = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteMessageSpecified { get; set; }

        protected string _playMessage;

        [XmlElement(ElementName = "playMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PlayMessage
        {
            get => _playMessage;
            set
            {
                PlayMessageSpecified = true;
                _playMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMessageSpecified { get; set; }

        protected string _previousMessage;

        [XmlElement(ElementName = "previousMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PreviousMessage
        {
            get => _previousMessage;
            set
            {
                PreviousMessageSpecified = true;
                _previousMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PreviousMessageSpecified { get; set; }

        protected string _playEnvelope;

        [XmlElement(ElementName = "playEnvelope", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PlayEnvelope
        {
            get => _playEnvelope;
            set
            {
                PlayEnvelopeSpecified = true;
                _playEnvelope = value;
            }
        }

        [XmlIgnore]
        protected bool PlayEnvelopeSpecified { get; set; }

        protected string _nextMessage;

        [XmlElement(ElementName = "nextMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string NextMessage
        {
            get => _nextMessage;
            set
            {
                NextMessageSpecified = true;
                _nextMessage = value;
            }
        }

        [XmlIgnore]
        protected bool NextMessageSpecified { get; set; }

        protected string _callbackCaller;

        [XmlElement(ElementName = "callbackCaller", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CallbackCaller
        {
            get => _callbackCaller;
            set
            {
                CallbackCallerSpecified = true;
                _callbackCaller = value;
            }
        }

        [XmlIgnore]
        protected bool CallbackCallerSpecified { get; set; }

        protected string _composeMessage;

        [XmlElement(ElementName = "composeMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ComposeMessage
        {
            get => _composeMessage;
            set
            {
                ComposeMessageSpecified = true;
                _composeMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ComposeMessageSpecified { get; set; }

        protected string _replyMessage;

        [XmlElement(ElementName = "replyMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReplyMessage
        {
            get => _replyMessage;
            set
            {
                ReplyMessageSpecified = true;
                _replyMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ReplyMessageSpecified { get; set; }

        protected string _forwardMessage;

        [XmlElement(ElementName = "forwardMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ForwardMessage
        {
            get => _forwardMessage;
            set
            {
                ForwardMessageSpecified = true;
                _forwardMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardMessageSpecified { get; set; }

        protected string _additionalMessageOptions;

        [XmlElement(ElementName = "additionalMessageOptions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string AdditionalMessageOptions
        {
            get => _additionalMessageOptions;
            set
            {
                AdditionalMessageOptionsSpecified = true;
                _additionalMessageOptions = value;
            }
        }

        [XmlIgnore]
        protected bool AdditionalMessageOptionsSpecified { get; set; }

        protected string _personalizedName;

        [XmlElement(ElementName = "personalizedName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PersonalizedName
        {
            get => _personalizedName;
            set
            {
                PersonalizedNameSpecified = true;
                _personalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameSpecified { get; set; }

        protected string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1427")]
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
