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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28341""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestChangeBusyOrNoAnswerGreetingMenuKeys
    {

        private string _recordNewGreeting;

        [XmlElement(ElementName = "recordNewGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28341")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28341")]
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

        private string _revertToSystemDefaultGreeting;

        [XmlElement(ElementName = "revertToSystemDefaultGreeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28341")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RevertToSystemDefaultGreeting
        {
            get => _revertToSystemDefaultGreeting;
            set
            {
                RevertToSystemDefaultGreetingSpecified = true;
                _revertToSystemDefaultGreeting = value;
            }
        }

        [XmlIgnore]
        public bool RevertToSystemDefaultGreetingSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28341")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28341")]
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
