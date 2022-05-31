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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1017""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendMessageToSelectedDistributionListMenuKeys
    {

        protected string _confirmSendingToDistributionList;

        [XmlElement(ElementName = "confirmSendingToDistributionList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1017")]
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

        protected string _cancelSendingToDistributionList;

        [XmlElement(ElementName = "cancelSendingToDistributionList", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1017")]
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
