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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1057""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoicePortalLoginMenuKeys
    {

        protected string _accessUsingOtherMailboxId;

        [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1057")]
        [MinLength(1)]
        [MaxLength(3)]
        [RegularExpression(@"([0-9]|\*|#){0,3}")]
        public string AccessUsingOtherMailboxId
        {
            get => _accessUsingOtherMailboxId;
            set
            {
                AccessUsingOtherMailboxIdSpecified = true;
                _accessUsingOtherMailboxId = value;
            }
        }

        [XmlIgnore]
        protected bool AccessUsingOtherMailboxIdSpecified { get; set; }

    }
}
