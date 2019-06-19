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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28355""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeExtendedAwayGreetingMenuKeys
    {

        private string _activateExtendedAwayGreeting;

        [XmlElement(ElementName = "activateExtendedAwayGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateExtendedAwayGreeting
        {
            get => _activateExtendedAwayGreeting;
            set
            {
                ActivateExtendedAwayGreetingSpecified = true;
                _activateExtendedAwayGreeting = value;
            }
        }

        [XmlIgnore]
        public bool ActivateExtendedAwayGreetingSpecified { get; set; }

        private string _deactivateExtendedAwayGreeting;

        [XmlElement(ElementName = "deactivateExtendedAwayGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeactivateExtendedAwayGreeting
        {
            get => _deactivateExtendedAwayGreeting;
            set
            {
                DeactivateExtendedAwayGreetingSpecified = true;
                _deactivateExtendedAwayGreeting = value;
            }
        }

        [XmlIgnore]
        public bool DeactivateExtendedAwayGreetingSpecified { get; set; }

        private string _recordNewGreeting;

        [XmlElement(ElementName = "recordNewGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RecordNewGreeting
        {
            get => _recordNewGreeting;
            set
            {
                RecordNewGreetingSpecified = true;
                _recordNewGreeting = value;
            }
        }

        [XmlIgnore]
        public bool RecordNewGreetingSpecified { get; set; }

        private string _listenToCurrentGreeting;

        [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCurrentGreeting
        {
            get => _listenToCurrentGreeting;
            set
            {
                ListenToCurrentGreetingSpecified = true;
                _listenToCurrentGreeting = value;
            }
        }

        [XmlIgnore]
        public bool ListenToCurrentGreetingSpecified { get; set; }

        private string _enableMessageDeposit;

        [XmlElement(ElementName = "enableMessageDeposit", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
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
        public bool EnableMessageDepositSpecified { get; set; }

        private string _disableMessageDeposit;

        [XmlElement(ElementName = "disableMessageDeposit", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
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
        public bool DisableMessageDepositSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28355")]
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
