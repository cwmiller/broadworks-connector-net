using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3.
        /// <see cref="UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection _mailServerSelection;

        [XmlElement(ElementName = "mailServerSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection MailServerSelection {
            get => _mailServerSelection;
            set {
                MailServerSelectionSpecified = true;
                _mailServerSelection = value;
            }
        }

        [XmlIgnore]
        public bool MailServerSelectionSpecified { get; set; }
        
        private string _groupMailServerEmailAddress;

        [XmlElement(ElementName = "groupMailServerEmailAddress", IsNullable = false, Namespace = "")]
        public string GroupMailServerEmailAddress {
            get => _groupMailServerEmailAddress;
            set {
                GroupMailServerEmailAddressSpecified = true;
                _groupMailServerEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool GroupMailServerEmailAddressSpecified { get; set; }
        
        private string _groupMailServerUserId;

        [XmlElement(ElementName = "groupMailServerUserId", IsNullable = false, Namespace = "")]
        public string GroupMailServerUserId {
            get => _groupMailServerUserId;
            set {
                GroupMailServerUserIdSpecified = true;
                _groupMailServerUserId = value;
            }
        }

        [XmlIgnore]
        public bool GroupMailServerUserIdSpecified { get; set; }
        
        private bool _useGroupDefaultMailServerFullMailboxLimit;

        [XmlElement(ElementName = "useGroupDefaultMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        public bool UseGroupDefaultMailServerFullMailboxLimit {
            get => _useGroupDefaultMailServerFullMailboxLimit;
            set {
                UseGroupDefaultMailServerFullMailboxLimitSpecified = true;
                _useGroupDefaultMailServerFullMailboxLimit = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupDefaultMailServerFullMailboxLimitSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _groupMailServerFullMailboxLimit;

        [XmlElement(ElementName = "groupMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes GroupMailServerFullMailboxLimit {
            get => _groupMailServerFullMailboxLimit;
            set {
                GroupMailServerFullMailboxLimitSpecified = true;
                _groupMailServerFullMailboxLimit = value;
            }
        }

        [XmlIgnore]
        public bool GroupMailServerFullMailboxLimitSpecified { get; set; }
        
        private string _personalMailServerNetAddress;

        [XmlElement(ElementName = "personalMailServerNetAddress", IsNullable = false, Namespace = "")]
        public string PersonalMailServerNetAddress {
            get => _personalMailServerNetAddress;
            set {
                PersonalMailServerNetAddressSpecified = true;
                _personalMailServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerNetAddressSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol _personalMailServerProtocol;

        [XmlElement(ElementName = "personalMailServerProtocol", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol PersonalMailServerProtocol {
            get => _personalMailServerProtocol;
            set {
                PersonalMailServerProtocolSpecified = true;
                _personalMailServerProtocol = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerProtocolSpecified { get; set; }
        
        private bool _personalMailServerRealDeleteForImap;

        [XmlElement(ElementName = "personalMailServerRealDeleteForImap", IsNullable = false, Namespace = "")]
        public bool PersonalMailServerRealDeleteForImap {
            get => _personalMailServerRealDeleteForImap;
            set {
                PersonalMailServerRealDeleteForImapSpecified = true;
                _personalMailServerRealDeleteForImap = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerRealDeleteForImapSpecified { get; set; }
        
        private string _personalMailServerEmailAddress;

        [XmlElement(ElementName = "personalMailServerEmailAddress", IsNullable = false, Namespace = "")]
        public string PersonalMailServerEmailAddress {
            get => _personalMailServerEmailAddress;
            set {
                PersonalMailServerEmailAddressSpecified = true;
                _personalMailServerEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerEmailAddressSpecified { get; set; }
        
        private string _personalMailServerUserId;

        [XmlElement(ElementName = "personalMailServerUserId", IsNullable = false, Namespace = "")]
        public string PersonalMailServerUserId {
            get => _personalMailServerUserId;
            set {
                PersonalMailServerUserIdSpecified = true;
                _personalMailServerUserId = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerUserIdSpecified { get; set; }
        
    }
}
