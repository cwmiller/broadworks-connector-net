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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37869""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ConferenceGreetingMenuKeys
    {

        protected string _activateConfGreeting;

        [XmlElement(ElementName = "activateConfGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37869")]
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

        protected string _deactivateConfGreeting;

        [XmlElement(ElementName = "deactivateConfGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37869")]
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

        protected string _recordNewConfGreeting;

        [XmlElement(ElementName = "recordNewConfGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37869")]
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

        protected string _listenToCurrentConfGreeting;

        [XmlElement(ElementName = "listenToCurrentConfGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37869")]
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

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37869")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37869")]
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
