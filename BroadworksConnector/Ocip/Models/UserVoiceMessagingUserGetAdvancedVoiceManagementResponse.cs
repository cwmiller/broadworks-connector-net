using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVoiceMessagingUserGetAdvancedVoiceManagementRequest.
    /// Replaced By: UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3
    /// <see cref="UserVoiceMessagingUserGetAdvancedVoiceManagementRequest"/>
    /// <see cref="UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7827"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7832""}]}]")]
    public class UserVoiceMessagingUserGetAdvancedVoiceManagementResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection _mailServerSelection;

        [XmlElement(ElementName = "mailServerSelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection MailServerSelection
        {
            get => _mailServerSelection;
            set
            {
                MailServerSelectionSpecified = true;
                _mailServerSelection = value;
            }
        }

        [XmlIgnore]
        public bool MailServerSelectionSpecified { get; set; }

        private string _groupMailServerEmailAddress;

        [XmlElement(ElementName = "groupMailServerEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GroupMailServerEmailAddress
        {
            get => _groupMailServerEmailAddress;
            set
            {
                GroupMailServerEmailAddressSpecified = true;
                _groupMailServerEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool GroupMailServerEmailAddressSpecified { get; set; }

        private string _groupMailServerUserId;

        [XmlElement(ElementName = "groupMailServerUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GroupMailServerUserId
        {
            get => _groupMailServerUserId;
            set
            {
                GroupMailServerUserIdSpecified = true;
                _groupMailServerUserId = value;
            }
        }

        [XmlIgnore]
        public bool GroupMailServerUserIdSpecified { get; set; }

        private string _groupMailServerPassword;

        [XmlElement(ElementName = "groupMailServerPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        [MinLength(1)]
        [MaxLength(60)]
        public string GroupMailServerPassword
        {
            get => _groupMailServerPassword;
            set
            {
                GroupMailServerPasswordSpecified = true;
                _groupMailServerPassword = value;
            }
        }

        [XmlIgnore]
        public bool GroupMailServerPasswordSpecified { get; set; }

        private bool _useGroupDefaultMailServerFullMailboxLimit;

        [XmlElement(ElementName = "useGroupDefaultMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7832")]
        public bool UseGroupDefaultMailServerFullMailboxLimit
        {
            get => _useGroupDefaultMailServerFullMailboxLimit;
            set
            {
                UseGroupDefaultMailServerFullMailboxLimitSpecified = true;
                _useGroupDefaultMailServerFullMailboxLimit = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupDefaultMailServerFullMailboxLimitSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _groupMailServerFullMailboxLimit;

        [XmlElement(ElementName = "groupMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7832")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes GroupMailServerFullMailboxLimit
        {
            get => _groupMailServerFullMailboxLimit;
            set
            {
                GroupMailServerFullMailboxLimitSpecified = true;
                _groupMailServerFullMailboxLimit = value;
            }
        }

        [XmlIgnore]
        public bool GroupMailServerFullMailboxLimitSpecified { get; set; }

        private string _personalMailServerNetAddress;

        [XmlElement(ElementName = "personalMailServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PersonalMailServerNetAddress
        {
            get => _personalMailServerNetAddress;
            set
            {
                PersonalMailServerNetAddressSpecified = true;
                _personalMailServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerNetAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol _personalMailServerProtocol;

        [XmlElement(ElementName = "personalMailServerProtocol", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol PersonalMailServerProtocol
        {
            get => _personalMailServerProtocol;
            set
            {
                PersonalMailServerProtocolSpecified = true;
                _personalMailServerProtocol = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerProtocolSpecified { get; set; }

        private bool _personalMailServerRealDeleteForImap;

        [XmlElement(ElementName = "personalMailServerRealDeleteForImap", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        public bool PersonalMailServerRealDeleteForImap
        {
            get => _personalMailServerRealDeleteForImap;
            set
            {
                PersonalMailServerRealDeleteForImapSpecified = true;
                _personalMailServerRealDeleteForImap = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerRealDeleteForImapSpecified { get; set; }

        private string _personalMailServerEmailAddress;

        [XmlElement(ElementName = "personalMailServerEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PersonalMailServerEmailAddress
        {
            get => _personalMailServerEmailAddress;
            set
            {
                PersonalMailServerEmailAddressSpecified = true;
                _personalMailServerEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerEmailAddressSpecified { get; set; }

        private string _personalMailServerUserId;

        [XmlElement(ElementName = "personalMailServerUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PersonalMailServerUserId
        {
            get => _personalMailServerUserId;
            set
            {
                PersonalMailServerUserIdSpecified = true;
                _personalMailServerUserId = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerUserIdSpecified { get; set; }

        private string _personalMailServerPassword;

        [XmlElement(ElementName = "personalMailServerPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7827")]
        [MinLength(1)]
        [MaxLength(60)]
        public string PersonalMailServerPassword
        {
            get => _personalMailServerPassword;
            set
            {
                PersonalMailServerPasswordSpecified = true;
                _personalMailServerPassword = value;
            }
        }

        [XmlIgnore]
        public bool PersonalMailServerPasswordSpecified { get; set; }

    }
}
