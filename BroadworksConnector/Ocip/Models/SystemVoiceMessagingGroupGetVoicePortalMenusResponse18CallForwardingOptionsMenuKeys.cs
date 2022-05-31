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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:36790""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18CallForwardingOptionsMenuKeys
    {

        protected string _activateCallForwarding;

        [XmlElement(ElementName = "activateCallForwarding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ActivateCallForwarding
        {
            get => _activateCallForwarding;
            set
            {
                ActivateCallForwardingSpecified = true;
                _activateCallForwarding = value;
            }
        }

        [XmlIgnore]
        protected bool ActivateCallForwardingSpecified { get; set; }

        protected string _deactivateCallForwarding;

        [XmlElement(ElementName = "deactivateCallForwarding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DeactivateCallForwarding
        {
            get => _deactivateCallForwarding;
            set
            {
                DeactivateCallForwardingSpecified = true;
                _deactivateCallForwarding = value;
            }
        }

        [XmlIgnore]
        protected bool DeactivateCallForwardingSpecified { get; set; }

        protected string _changeCallForwardingDestination;

        [XmlElement(ElementName = "changeCallForwardingDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeCallForwardingDestination
        {
            get => _changeCallForwardingDestination;
            set
            {
                ChangeCallForwardingDestinationSpecified = true;
                _changeCallForwardingDestination = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCallForwardingDestinationSpecified { get; set; }

        protected string _listenToCallForwardingStatus;

        [XmlElement(ElementName = "listenToCallForwardingStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCallForwardingStatus
        {
            get => _listenToCallForwardingStatus;
            set
            {
                ListenToCallForwardingStatusSpecified = true;
                _listenToCallForwardingStatus = value;
            }
        }

        [XmlIgnore]
        protected bool ListenToCallForwardingStatusSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36790")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36790")]
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
