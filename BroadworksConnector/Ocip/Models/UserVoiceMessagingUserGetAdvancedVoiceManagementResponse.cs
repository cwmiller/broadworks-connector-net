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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47850"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47855""}]}]")]
    public class UserVoiceMessagingUserGetAdvancedVoiceManagementResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection _mailServerSelection;

        [XmlElement(ElementName = "mailServerSelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool MailServerSelectionSpecified { get; set; }

        protected string _groupMailServerEmailAddress;

        [XmlElement(ElementName = "groupMailServerEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool GroupMailServerEmailAddressSpecified { get; set; }

        protected string _groupMailServerUserId;

        [XmlElement(ElementName = "groupMailServerUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool GroupMailServerUserIdSpecified { get; set; }

        protected string _groupMailServerPassword;

        [XmlElement(ElementName = "groupMailServerPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool GroupMailServerPasswordSpecified { get; set; }

        protected bool _useGroupDefaultMailServerFullMailboxLimit;

        [XmlElement(ElementName = "useGroupDefaultMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47855")]
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
        protected bool UseGroupDefaultMailServerFullMailboxLimitSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _groupMailServerFullMailboxLimit;

        [XmlElement(ElementName = "groupMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47855")]
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
        protected bool GroupMailServerFullMailboxLimitSpecified { get; set; }

        protected string _personalMailServerNetAddress;

        [XmlElement(ElementName = "personalMailServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool PersonalMailServerNetAddressSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol _personalMailServerProtocol;

        [XmlElement(ElementName = "personalMailServerProtocol", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool PersonalMailServerProtocolSpecified { get; set; }

        protected bool _personalMailServerRealDeleteForImap;

        [XmlElement(ElementName = "personalMailServerRealDeleteForImap", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool PersonalMailServerRealDeleteForImapSpecified { get; set; }

        protected string _personalMailServerEmailAddress;

        [XmlElement(ElementName = "personalMailServerEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool PersonalMailServerEmailAddressSpecified { get; set; }

        protected string _personalMailServerUserId;

        [XmlElement(ElementName = "personalMailServerUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool PersonalMailServerUserIdSpecified { get; set; }

        protected string _personalMailServerPassword;

        [XmlElement(ElementName = "personalMailServerPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47850")]
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
        protected bool PersonalMailServerPasswordSpecified { get; set; }

    }
}
