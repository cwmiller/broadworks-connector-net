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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:38508""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToPersonMenuKeys
    {

        protected string _confirmSendingMessage;

        [XmlElement(ElementName = "confirmSendingMessage", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:38508")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:38508")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:38508")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:38508")]
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
