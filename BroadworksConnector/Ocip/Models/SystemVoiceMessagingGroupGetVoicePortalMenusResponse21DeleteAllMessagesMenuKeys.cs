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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:822""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21DeleteAllMessagesMenuKeys
    {

        protected string _confirmDeletion;

        [XmlElement(ElementName = "confirmDeletion", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:822")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ConfirmDeletion
        {
            get => _confirmDeletion;
            set
            {
                ConfirmDeletionSpecified = true;
                _confirmDeletion = value;
            }
        }

        [XmlIgnore]
        protected bool ConfirmDeletionSpecified { get; set; }

        protected string _cancelDeletion;

        [XmlElement(ElementName = "cancelDeletion", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:822")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CancelDeletion
        {
            get => _cancelDeletion;
            set
            {
                CancelDeletionSpecified = true;
                _cancelDeletion = value;
            }
        }

        [XmlIgnore]
        protected bool CancelDeletionSpecified { get; set; }

    }
}
