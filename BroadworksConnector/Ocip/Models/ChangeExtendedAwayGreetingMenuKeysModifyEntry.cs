using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class ChangeExtendedAwayGreetingMenuKeysModifyEntry
    {
        private string _activateExtendedAwayGreeting;

        [XmlElement(ElementName = "activateExtendedAwayGreeting", IsNullable = true, Namespace = "")]
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
