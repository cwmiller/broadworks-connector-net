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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:38103""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToAllGroupMembersMenuKeys
    {

        protected string _confirmSendingToEntireGroup;

        [XmlElement(ElementName = "confirmSendingToEntireGroup", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:38103")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:38103")]
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
