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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1556""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToPersonMenuKeys
    {

        protected string _confirmSendingMessage;

        [XmlElement(ElementName = "confirmSendingMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1556")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ConfirmSendingMessage
        {
            get => _confirmSendingMessage;
            set
            {
                ConfirmSendingMessageSpecified = true;
                _confirmSendingMessage = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmSendingMessageSpecified { get; set; }

        protected string _cancelSendingMessage;

        [XmlElement(ElementName = "cancelSendingMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1556")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CancelSendingMessage
        {
            get => _cancelSendingMessage;
            set
            {
                CancelSendingMessageSpecified = true;
                _cancelSendingMessage = value;
            }
        }

        [XmlIgnore]
        protected bool CancelSendingMessageSpecified { get; set; }

        protected string _finishEnteringNumberWhereToSendMessageTo;

        [XmlElement(ElementName = "finishEnteringNumberWhereToSendMessageTo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1556")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string FinishEnteringNumberWhereToSendMessageTo
        {
            get => _finishEnteringNumberWhereToSendMessageTo;
            set
            {
                FinishEnteringNumberWhereToSendMessageToSpecified = true;
                _finishEnteringNumberWhereToSendMessageTo = value;
            }
        }

        [XmlIgnore]
        protected bool FinishEnteringNumberWhereToSendMessageToSpecified { get; set; }

        protected string _finishForwardingOrSendingMessage;

        [XmlElement(ElementName = "finishForwardingOrSendingMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1556")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string FinishForwardingOrSendingMessage
        {
            get => _finishForwardingOrSendingMessage;
            set
            {
                FinishForwardingOrSendingMessageSpecified = true;
                _finishForwardingOrSendingMessage = value;
            }
        }

        [XmlIgnore]
        protected bool FinishForwardingOrSendingMessageSpecified { get; set; }

    }
}
