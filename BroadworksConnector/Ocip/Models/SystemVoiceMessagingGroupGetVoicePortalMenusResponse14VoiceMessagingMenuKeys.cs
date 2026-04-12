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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:37137""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse14VoiceMessagingMenuKeys
    {

        protected string _playMessages;

        [XmlElement(ElementName = "playMessages", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PlayMessages
        {
            get => _playMessages;
            set
            {
                PlayMessagesSpecified = (value != null);
                _playMessages = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMessagesSpecified { get; set; }

        protected string _changeBusyGreeting;

        [XmlElement(ElementName = "changeBusyGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeBusyGreeting
        {
            get => _changeBusyGreeting;
            set
            {
                ChangeBusyGreetingSpecified = (value != null);
                _changeBusyGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeBusyGreetingSpecified { get; set; }

        protected string _changeNoAnswerGreeting;

        [XmlElement(ElementName = "changeNoAnswerGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeNoAnswerGreeting
        {
            get => _changeNoAnswerGreeting;
            set
            {
                ChangeNoAnswerGreetingSpecified = (value != null);
                _changeNoAnswerGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeNoAnswerGreetingSpecified { get; set; }

        protected string _composeMessage;

        [XmlElement(ElementName = "composeMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ComposeMessage
        {
            get => _composeMessage;
            set
            {
                ComposeMessageSpecified = (value != null);
                _composeMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ComposeMessageSpecified { get; set; }

        protected string _deleteAllMessages;

        [XmlElement(ElementName = "deleteAllMessages", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeleteAllMessages
        {
            get => _deleteAllMessages;
            set
            {
                DeleteAllMessagesSpecified = (value != null);
                _deleteAllMessages = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteAllMessagesSpecified { get; set; }

        protected string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = (value != null);
                _passcode = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeSpecified { get; set; }

        protected string _personalizedName;

        [XmlElement(ElementName = "personalizedName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string PersonalizedName
        {
            get => _personalizedName;
            set
            {
                PersonalizedNameSpecified = (value != null);
                _personalizedName = value;
            }
        }

        [XmlIgnore]
        protected bool PersonalizedNameSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:37137")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = (value != null);
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

    }
}
