using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3.
    /// <see cref="UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1714"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1718""}]}]")]
    public class UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection _mailServerSelection;

        [XmlElement(ElementName = "mailServerSelection", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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

        protected bool _useGroupDefaultMailServerFullMailboxLimit;

        [XmlElement(ElementName = "useGroupDefaultMailServerFullMailboxLimit", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1718")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1718")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1714")]
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

    }
}
