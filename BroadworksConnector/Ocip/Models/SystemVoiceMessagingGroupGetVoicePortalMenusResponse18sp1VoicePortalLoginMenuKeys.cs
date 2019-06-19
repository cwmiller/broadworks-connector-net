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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27820""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalLoginMenuKeys
    {

        private string _accessUsingOtherMailboxId;

        [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27820")]
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
