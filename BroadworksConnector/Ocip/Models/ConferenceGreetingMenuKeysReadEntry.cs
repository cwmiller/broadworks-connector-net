using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class ConferenceGreetingMenuKeysReadEntry
    {
        private string _activateConfGreeting;

        [XmlElement(ElementName = "activateConfGreeting", IsNullable = false, Namespace = "")]
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
        public bool ActivateConfGreetingSpecified { get; set; }
        private string _deactivateConfGreeting;

        [XmlElement(ElementName = "deactivateConfGreeting", IsNullable = false, Namespace = "")]
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
        public bool DeactivateConfGreetingSpecified { get; set; }
        private string _recordNewConfGreeting;

        [XmlElement(ElementName = "recordNewConfGreeting", IsNullable = false, Namespace = "")]
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
        public bool RecordNewConfGreetingSpecified { get; set; }
        private string _listenToCurrentConfGreeting;

        [XmlElement(ElementName = "listenToCurrentConfGreeting", IsNullable = false, Namespace = "")]
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
        public bool ListenToCurrentConfGreetingSpecified { get; set; }
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
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
