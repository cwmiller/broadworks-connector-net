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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1034""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21SendToPersonMenuKeys
    {

        private string _confirmSendingMessage;

        [XmlElement(ElementName = "confirmSendingMessage", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1034")]
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
        public bool ConfirmSendingMessageSpecified { get; set; }

        private string _cancelSendingMessage;

        [XmlElement(ElementName = "cancelSendingMessage", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1034")]
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
        public bool CancelSendingMessageSpecified { get; set; }

        private string _finishEnteringNumberWhereToSendMessageTo;

        [XmlElement(ElementName = "finishEnteringNumberWhereToSendMessageTo", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1034")]
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
        public bool FinishEnteringNumberWhereToSendMessageToSpecified { get; set; }

        private string _finishForwardingOrSendingMessage;

        [XmlElement(ElementName = "finishForwardingOrSendingMessage", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1034")]
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
        public bool FinishForwardingOrSendingMessageSpecified { get; set; }

    }
}
