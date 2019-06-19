using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Third Party Voice Mail Support settings for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3c311aa5c89c0cf5b46e1cdefd5bc387:282""}]")]
    public class UserThirdPartyVoiceMailSupportModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private bool _busyRedirectToVoiceMail;

        [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public bool BusyRedirectToVoiceMail
        {
            get => _busyRedirectToVoiceMail;
            set
            {
                BusyRedirectToVoiceMailSpecified = true;
                _busyRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        public bool BusyRedirectToVoiceMailSpecified { get; set; }

        private bool _noAnswerRedirectToVoiceMail;

        [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public bool NoAnswerRedirectToVoiceMail
        {
            get => _noAnswerRedirectToVoiceMail;
            set
            {
                NoAnswerRedirectToVoiceMailSpecified = true;
                _noAnswerRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        public bool NoAnswerRedirectToVoiceMailSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection _serverSelection;

        [XmlElement(ElementName = "serverSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection ServerSelection
        {
            get => _serverSelection;
            set
            {
                ServerSelectionSpecified = true;
                _serverSelection = value;
            }
        }

        [XmlIgnore]
        public bool ServerSelectionSpecified { get; set; }

        private string _userServer;

        [XmlElement(ElementName = "userServer", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserServer
        {
            get => _userServer;
            set
            {
                UserServerSpecified = true;
                _userServer = value;
            }
        }

        [XmlIgnore]
        public bool UserServerSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType _mailboxIdType;

        [XmlElement(ElementName = "mailboxIdType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType MailboxIdType
        {
            get => _mailboxIdType;
            set
            {
                MailboxIdTypeSpecified = true;
                _mailboxIdType = value;
            }
        }

        [XmlIgnore]
        public bool MailboxIdTypeSpecified { get; set; }

        private string _mailboxURL;

        [XmlElement(ElementName = "mailboxURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        [MinLength(1)]
        [MaxLength(161)]
        public string MailboxURL
        {
            get => _mailboxURL;
            set
            {
                MailboxURLSpecified = true;
                _mailboxURL = value;
            }
        }

        [XmlIgnore]
        public bool MailboxURLSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportNumberOfRings _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportNumberOfRings NoAnswerNumberOfRings
        {
            get => _noAnswerNumberOfRings;
            set
            {
                NoAnswerNumberOfRingsSpecified = true;
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool NoAnswerNumberOfRingsSpecified { get; set; }

        private bool _alwaysRedirectToVoiceMail;

        [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public bool AlwaysRedirectToVoiceMail
        {
            get => _alwaysRedirectToVoiceMail;
            set
            {
                AlwaysRedirectToVoiceMailSpecified = true;
                _alwaysRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        public bool AlwaysRedirectToVoiceMailSpecified { get; set; }

        private bool _outOfPrimaryZoneRedirectToVoiceMail;

        [XmlElement(ElementName = "outOfPrimaryZoneRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:282")]
        public bool OutOfPrimaryZoneRedirectToVoiceMail
        {
            get => _outOfPrimaryZoneRedirectToVoiceMail;
            set
            {
                OutOfPrimaryZoneRedirectToVoiceMailSpecified = true;
                _outOfPrimaryZoneRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        public bool OutOfPrimaryZoneRedirectToVoiceMailSpecified { get; set; }

    }
}
