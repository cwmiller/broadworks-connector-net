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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28570""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToDistributionListMenuKeys
    {

        private string _sendMessageToSelectedDistributionList;

        [XmlElement(ElementName = "sendMessageToSelectedDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28570")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendMessageToSelectedDistributionList
        {
            get => _sendMessageToSelectedDistributionList;
            set
            {
                SendMessageToSelectedDistributionListSpecified = true;
                _sendMessageToSelectedDistributionList = value;
            }
        }

        [XmlIgnore]
        public bool SendMessageToSelectedDistributionListSpecified { get; set; }

        private string _selectDistributionList;

        [XmlElement(ElementName = "selectDistributionList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28570")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SelectDistributionList
        {
            get => _selectDistributionList;
            set
            {
                SelectDistributionListSpecified = true;
                _selectDistributionList = value;
            }
        }

        [XmlIgnore]
        public bool SelectDistributionListSpecified { get; set; }

        private string _reviewSelectedDistributionList;

        [XmlElement(ElementName = "reviewSelectedDistributionList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28570")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReviewSelectedDistributionList
        {
            get => _reviewSelectedDistributionList;
            set
            {
                ReviewSelectedDistributionListSpecified = true;
                _reviewSelectedDistributionList = value;
            }
        }

        [XmlIgnore]
        public bool ReviewSelectedDistributionListSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28570")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28570")]
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
