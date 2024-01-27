using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal disable message deposit menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:2545""}]")]
    public class DisableMessageDepositMenuKeysReadEntry
    {

        protected string _disconnectAfterGreeting;

        [XmlElement(ElementName = "disconnectAfterGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2545")]
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

        protected string _forwardAfterGreeting;

        [XmlElement(ElementName = "forwardAfterGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2545")]
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

        protected string _changeForwardingDestination;

        [XmlElement(ElementName = "changeForwardingDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2545")]
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

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2545")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2545")]
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
