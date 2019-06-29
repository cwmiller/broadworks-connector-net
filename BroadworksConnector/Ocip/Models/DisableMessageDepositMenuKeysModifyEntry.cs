using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal disable message deposit menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2595""}]")]
    public class DisableMessageDepositMenuKeysModifyEntry
    {

        private string _disconnectAfterGreeting;

        [XmlElement(ElementName = "disconnectAfterGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2595")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DisconnectAfterGreeting
        {
            get => _disconnectAfterGreeting;
            set
            {
                DisconnectAfterGreetingSpecified = true;
                _disconnectAfterGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool DisconnectAfterGreetingSpecified { get; set; }

        private string _forwardAfterGreeting;

        [XmlElement(ElementName = "forwardAfterGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2595")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ForwardAfterGreeting
        {
            get => _forwardAfterGreeting;
            set
            {
                ForwardAfterGreetingSpecified = true;
                _forwardAfterGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardAfterGreetingSpecified { get; set; }

        private string _changeForwardingDestination;

        [XmlElement(ElementName = "changeForwardingDestination", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2595")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeForwardingDestination
        {
            get => _changeForwardingDestination;
            set
            {
                ChangeForwardingDestinationSpecified = true;
                _changeForwardingDestination = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeForwardingDestinationSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2595")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2595")]
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
