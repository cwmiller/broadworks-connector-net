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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27792""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1SendToAllGroupMembersMenuKeys
    {

        private string _confirmSendingToEntireGroup;

        [XmlElement(ElementName = "confirmSendingToEntireGroup", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27792")]
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
        public bool ConfirmSendingToEntireGroupSpecified { get; set; }

        private string _cancelSendingToEntireGroup;

        [XmlElement(ElementName = "cancelSendingToEntireGroup", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27792")]
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
        public bool CancelSendingToEntireGroupSpecified { get; set; }

    }
}
