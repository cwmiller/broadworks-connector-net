using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal voice messaging menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:3208""}]")]
    public class VoiceMessagingMenuKeysModifyEntry
    {

        protected string _playMessages;

        [XmlElement(ElementName = "playMessages", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PlayMessages
        {
            get => _playMessages;
            set
            {
                PlayMessagesSpecified = true;
                _playMessages = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMessagesSpecified { get; set; }

        protected string _changeBusyGreeting;

        [XmlElement(ElementName = "changeBusyGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeBusyGreeting
        {
            get => _changeBusyGreeting;
            set
            {
                ChangeBusyGreetingSpecified = true;
                _changeBusyGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeBusyGreetingSpecified { get; set; }

        protected string _changeNoAnswerGreeting;

        [XmlElement(ElementName = "changeNoAnswerGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeNoAnswerGreeting
        {
            get => _changeNoAnswerGreeting;
            set
            {
                ChangeNoAnswerGreetingSpecified = true;
                _changeNoAnswerGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeNoAnswerGreetingSpecified { get; set; }

        protected string _changeExtendedAwayGreeting;

        [XmlElement(ElementName = "changeExtendedAwayGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeExtendedAwayGreeting
        {
            get => _changeExtendedAwayGreeting;
            set
            {
                ChangeExtendedAwayGreetingSpecified = true;
                _changeExtendedAwayGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeExtendedAwayGreetingSpecified { get; set; }

        protected string _composeMessage;

        [XmlElement(ElementName = "composeMessage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
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

        protected string _deleteAllMessages;

        [XmlElement(ElementName = "deleteAllMessages", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeleteAllMessages
        {
            get => _deleteAllMessages;
            set
            {
                DeleteAllMessagesSpecified = true;
                _deleteAllMessages = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteAllMessagesSpecified { get; set; }

        protected string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
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

        protected string _personalizedName;

        [XmlElement(ElementName = "personalizedName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
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

        protected string _messageDeposit;

        [XmlElement(ElementName = "messageDeposit", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string MessageDeposit
        {
            get => _messageDeposit;
            set
            {
                MessageDepositSpecified = true;
                _messageDeposit = value;
            }
        }

        [XmlIgnore]
        protected bool MessageDepositSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3208")]
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
