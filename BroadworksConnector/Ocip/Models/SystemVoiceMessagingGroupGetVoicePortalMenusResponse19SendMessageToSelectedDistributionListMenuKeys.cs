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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37733""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendMessageToSelectedDistributionListMenuKeys
    {

        private string _confirmSendingToDistributionList;

        [XmlElement(ElementName = "confirmSendingToDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37733")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string ConfirmSendingToDistributionList
        {
            get => _confirmSendingToDistributionList;
            set
            {
                ConfirmSendingToDistributionListSpecified = true;
                _confirmSendingToDistributionList = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmSendingToDistributionListSpecified { get; set; }

        private string _cancelSendingToDistributionList;

        [XmlElement(ElementName = "cancelSendingToDistributionList", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37733")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string CancelSendingToDistributionList
        {
            get => _cancelSendingToDistributionList;
            set
            {
                CancelSendingToDistributionListSpecified = true;
                _cancelSendingToDistributionList = value;
            }
        }

        [XmlIgnore]
        protected bool CancelSendingToDistributionListSpecified { get; set; }

    }
}
