using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1SendToAllGroupMembersMenuKeys 
    {

        
        private string _confirmSendingToEntireGroup;

        [XmlElement(ElementName = "confirmSendingToEntireGroup", IsNullable = false, Namespace = "")]
        public string ConfirmSendingToEntireGroup {
            get => _confirmSendingToEntireGroup;
            set {
                ConfirmSendingToEntireGroupSpecified = true;
                _confirmSendingToEntireGroup = value;
            }
        }

        [XmlIgnore]
        public bool ConfirmSendingToEntireGroupSpecified { get; set; }
        
        private string _cancelSendingToEntireGroup;

        [XmlElement(ElementName = "cancelSendingToEntireGroup", IsNullable = false, Namespace = "")]
        public string CancelSendingToEntireGroup {
            get => _cancelSendingToEntireGroup;
            set {
                CancelSendingToEntireGroupSpecified = true;
                _cancelSendingToEntireGroup = value;
            }
        }

        [XmlIgnore]
        public bool CancelSendingToEntireGroupSpecified { get; set; }
        
    }
}
