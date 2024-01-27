using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal send to all group memeber menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:3078""}]")]
    public class SendToAllGroupMembersMenuKeysModifyEntry
    {

        protected string _confirmSendingToEntireGroup;

        [XmlElement(ElementName = "confirmSendingToEntireGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:3078")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ConfirmSendingToEntireGroup
        {
            get => _confirmSendingToEntireGroup;
            set
            {
                ConfirmSendingToEntireGroupSpecified = true;
                _confirmSendingToEntireGroup = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmSendingToEntireGroupSpecified { get; set; }

        protected string _cancelSendingToEntireGroup;

        [XmlElement(ElementName = "cancelSendingToEntireGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:3078")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CancelSendingToEntireGroup
        {
            get => _cancelSendingToEntireGroup;
            set
            {
                CancelSendingToEntireGroupSpecified = true;
                _cancelSendingToEntireGroup = value;
            }
        }

        [XmlIgnore]
        protected bool CancelSendingToEntireGroupSpecified { get; set; }

    }
}
