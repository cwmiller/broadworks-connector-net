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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39753""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestSendToDistributionListMenuKeys
    {

        protected string _sendMessageToSelectedDistributionList;

        [XmlElement(ElementName = "sendMessageToSelectedDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39753")]
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
        protected bool SendMessageToSelectedDistributionListSpecified { get; set; }

        protected string _selectDistributionList;

        [XmlElement(ElementName = "selectDistributionList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39753")]
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
        protected bool SelectDistributionListSpecified { get; set; }

        protected string _reviewSelectedDistributionList;

        [XmlElement(ElementName = "reviewSelectedDistributionList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39753")]
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
        protected bool ReviewSelectedDistributionListSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39753")]
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

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39753")]
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
