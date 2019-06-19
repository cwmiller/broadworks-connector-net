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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1574""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19VoicePortalLoginMenuKeys
    {

        private string _accessUsingOtherMailboxId;

        [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1574")]
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
        public bool AccessUsingOtherMailboxIdSpecified { get; set; }

    }
}
