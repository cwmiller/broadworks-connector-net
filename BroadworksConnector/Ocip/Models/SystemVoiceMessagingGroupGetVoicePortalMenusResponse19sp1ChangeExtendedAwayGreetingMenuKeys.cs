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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37924""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeExtendedAwayGreetingMenuKeys
    {

        private string _activateExtendedAwayGreeting;

        [XmlElement(ElementName = "activateExtendedAwayGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37924")]
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
        protected bool ActivateExtendedAwayGreetingSpecified { get; set; }

        private string _deactivateExtendedAwayGreeting;

        [XmlElement(ElementName = "deactivateExtendedAwayGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37924")]
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
        protected bool DeactivateExtendedAwayGreetingSpecified { get; set; }

        private string _recordNewGreeting;

        [XmlElement(ElementName = "recordNewGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37924")]
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
        protected bool RecordNewGreetingSpecified { get; set; }

        private string _listenToCurrentGreeting;

        [XmlElement(ElementName = "listenToCurrentGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37924")]
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
        protected bool ListenToCurrentGreetingSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37924")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37924")]
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
