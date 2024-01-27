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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:37407""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse14VoicePortalLoginMenuKeys
    {

        protected string _accessUsingOtherMailboxId;

        [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:37407")]
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
