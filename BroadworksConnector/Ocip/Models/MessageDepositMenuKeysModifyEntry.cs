using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal message deposit menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2708""}]")]
    public class MessageDepositMenuKeysModifyEntry
    {

        private string _enableMessageDeposit;

        [XmlElement(ElementName = "enableMessageDeposit", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2708")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string EnableMessageDeposit
        {
            get => _enableMessageDeposit;
            set
            {
                EnableMessageDepositSpecified = true;
                _enableMessageDeposit = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMessageDepositSpecified { get; set; }

        private string _disableMessageDeposit;

        [XmlElement(ElementName = "disableMessageDeposit", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2708")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DisableMessageDeposit
        {
            get => _disableMessageDeposit;
            set
            {
                DisableMessageDepositSpecified = true;
                _disableMessageDeposit = value;
            }
        }

        [XmlIgnore]
        protected bool DisableMessageDepositSpecified { get; set; }

        private string _listenToMessageDepositStatus;

        [XmlElement(ElementName = "listenToMessageDepositStatus", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2708")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToMessageDepositStatus
        {
            get => _listenToMessageDepositStatus;
            set
            {
                ListenToMessageDepositStatusSpecified = true;
                _listenToMessageDepositStatus = value;
            }
        }

        [XmlIgnore]
        protected bool ListenToMessageDepositStatusSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2708")]
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2708")]
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
