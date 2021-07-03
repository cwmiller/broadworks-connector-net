using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal greeting menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2468""}]")]
    public class ConferenceGreetingMenuKeysModifyEntry
    {

        private string _activateConfGreeting;

        [XmlElement(ElementName = "activateConfGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2468")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateConfGreeting
        {
            get => _activateConfGreeting;
            set
            {
                ActivateConfGreetingSpecified = true;
                _activateConfGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ActivateConfGreetingSpecified { get; set; }

        private string _deactivateConfGreeting;

        [XmlElement(ElementName = "deactivateConfGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2468")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeactivateConfGreeting
        {
            get => _deactivateConfGreeting;
            set
            {
                DeactivateConfGreetingSpecified = true;
                _deactivateConfGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool DeactivateConfGreetingSpecified { get; set; }

        private string _recordNewConfGreeting;

        [XmlElement(ElementName = "recordNewConfGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2468")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RecordNewConfGreeting
        {
            get => _recordNewConfGreeting;
            set
            {
                RecordNewConfGreetingSpecified = true;
                _recordNewConfGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool RecordNewConfGreetingSpecified { get; set; }

        private string _listenToCurrentConfGreeting;

        [XmlElement(ElementName = "listenToCurrentConfGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2468")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCurrentConfGreeting
        {
            get => _listenToCurrentConfGreeting;
            set
            {
                ListenToCurrentConfGreetingSpecified = true;
                _listenToCurrentConfGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool ListenToCurrentConfGreetingSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2468")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2468")]
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
