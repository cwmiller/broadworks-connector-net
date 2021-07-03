using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal send message to selected distribution list menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:3048""}]")]
    public class SendMessageToSelectedDistributionListMenuKeysModifyEntry
    {

        private string _confirmSendingToDistributionList;

        [XmlElement(ElementName = "confirmSendingToDistributionList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3048")]
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
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:3048")]
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
