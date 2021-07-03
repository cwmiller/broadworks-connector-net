using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal forward or compose message menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2607""}]")]
    public class ForwardOrComposeMessageMenuKeysReadEntry
    {

        private string _sendToPerson;

        [XmlElement(ElementName = "sendToPerson", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendToPerson
        {
            get => _sendToPerson;
            set
            {
                SendToPersonSpecified = true;
                _sendToPerson = value;
            }
        }

        [XmlIgnore]
        protected bool SendToPersonSpecified { get; set; }

        private string _sendToAllGroupMembers;

        [XmlElement(ElementName = "sendToAllGroupMembers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendToAllGroupMembers
        {
            get => _sendToAllGroupMembers;
            set
            {
                SendToAllGroupMembersSpecified = true;
                _sendToAllGroupMembers = value;
            }
        }

        [XmlIgnore]
        protected bool SendToAllGroupMembersSpecified { get; set; }

        private string _sendToDistributionList;

        [XmlElement(ElementName = "sendToDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendToDistributionList
        {
            get => _sendToDistributionList;
            set
            {
                SendToDistributionListSpecified = true;
                _sendToDistributionList = value;
            }
        }

        [XmlIgnore]
        protected bool SendToDistributionListSpecified { get; set; }

        private string _changeCurrentIntroductionOrMessage;

        [XmlElement(ElementName = "changeCurrentIntroductionOrMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeCurrentIntroductionOrMessage
        {
            get => _changeCurrentIntroductionOrMessage;
            set
            {
                ChangeCurrentIntroductionOrMessageSpecified = true;
                _changeCurrentIntroductionOrMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCurrentIntroductionOrMessageSpecified { get; set; }

        private string _listenToCurrentIntroductionOrMessage;

        [XmlElement(ElementName = "listenToCurrentIntroductionOrMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCurrentIntroductionOrMessage
        {
            get => _listenToCurrentIntroductionOrMessage;
            set
            {
                ListenToCurrentIntroductionOrMessageSpecified = true;
                _listenToCurrentIntroductionOrMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ListenToCurrentIntroductionOrMessageSpecified { get; set; }

        private string _setOrClearUrgentIndicator;

        [XmlElement(ElementName = "setOrClearUrgentIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
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
        protected bool SetOrClearUrgentIndicatorSpecified { get; set; }

        private string _setOrClearConfidentialIndicator;

        [XmlElement(ElementName = "setOrClearConfidentialIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
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
        protected bool SetOrClearConfidentialIndicatorSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2607")]
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
