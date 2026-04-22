using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system voice portal passcode rules setting.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced By: SystemPortalPasscodeRulesModifyRequest
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemPortalPasscodeRulesModifyRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39435""}]")]
    public class SystemVoiceMessagingGroupModifyPasscodeRulesRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _disallowRepeatedDigits;

        [XmlElement(ElementName = "disallowRepeatedDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? DisallowRepeatedDigits
        {
            get => _disallowRepeatedDigits;
            set
            {
                DisallowRepeatedDigitsSpecified = (value != null);
                _disallowRepeatedDigits = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowRepeatedDigitsSpecified { get; set; }

        protected bool? _disallowUserNumber;

        [XmlElement(ElementName = "disallowUserNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? DisallowUserNumber
        {
            get => _disallowUserNumber;
            set
            {
                DisallowUserNumberSpecified = (value != null);
                _disallowUserNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowUserNumberSpecified { get; set; }

        protected bool? _disallowReversedUserNumber;

        [XmlElement(ElementName = "disallowReversedUserNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? DisallowReversedUserNumber
        {
            get => _disallowReversedUserNumber;
            set
            {
                DisallowReversedUserNumberSpecified = (value != null);
                _disallowReversedUserNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowReversedUserNumberSpecified { get; set; }

        protected bool? _disallowOldPasscode;

        [XmlElement(ElementName = "disallowOldPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? DisallowOldPasscode
        {
            get => _disallowOldPasscode;
            set
            {
                DisallowOldPasscodeSpecified = (value != null);
                _disallowOldPasscode = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowOldPasscodeSpecified { get; set; }

        protected bool? _disallowReversedOldPasscode;

        [XmlElement(ElementName = "disallowReversedOldPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? DisallowReversedOldPasscode
        {
            get => _disallowReversedOldPasscode;
            set
            {
                DisallowReversedOldPasscodeSpecified = (value != null);
                _disallowReversedOldPasscode = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowReversedOldPasscodeSpecified { get; set; }

        protected int? _minCodeLength;

        [XmlElement(ElementName = "minCodeLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        [MinInclusive(2)]
        [MaxInclusive(15)]
        public int? MinCodeLength
        {
            get => _minCodeLength;
            set
            {
                MinCodeLengthSpecified = (value != null);
                _minCodeLength = value;
            }
        }

        [XmlIgnore]
        protected bool MinCodeLengthSpecified { get; set; }

        protected int? _maxCodeLength;

        [XmlElement(ElementName = "maxCodeLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        [MinInclusive(3)]
        [MaxInclusive(30)]
        public int? MaxCodeLength
        {
            get => _maxCodeLength;
            set
            {
                MaxCodeLengthSpecified = (value != null);
                _maxCodeLength = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCodeLengthSpecified { get; set; }

        protected bool? _disableLoginAfterMaxFailedLoginAttempts;

        [XmlElement(ElementName = "disableLoginAfterMaxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? DisableLoginAfterMaxFailedLoginAttempts
        {
            get => _disableLoginAfterMaxFailedLoginAttempts;
            set
            {
                DisableLoginAfterMaxFailedLoginAttemptsSpecified = (value != null);
                _disableLoginAfterMaxFailedLoginAttempts = value;
            }
        }

        [XmlIgnore]
        protected bool DisableLoginAfterMaxFailedLoginAttemptsSpecified { get; set; }

        protected int? _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int? MaxFailedLoginAttempts
        {
            get => _maxFailedLoginAttempts;
            set
            {
                MaxFailedLoginAttemptsSpecified = (value != null);
                _maxFailedLoginAttempts = value;
            }
        }

        [XmlIgnore]
        protected bool MaxFailedLoginAttemptsSpecified { get; set; }

        protected bool? _expirePassword;

        [XmlElement(ElementName = "expirePassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? ExpirePassword
        {
            get => _expirePassword;
            set
            {
                ExpirePasswordSpecified = (value != null);
                _expirePassword = value;
            }
        }

        [XmlIgnore]
        protected bool ExpirePasswordSpecified { get; set; }

        protected int? _passcodeExpiresDays;

        [XmlElement(ElementName = "passcodeExpiresDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        [MinInclusive(15)]
        [MaxInclusive(180)]
        public int? PasscodeExpiresDays
        {
            get => _passcodeExpiresDays;
            set
            {
                PasscodeExpiresDaysSpecified = (value != null);
                _passcodeExpiresDays = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeExpiresDaysSpecified { get; set; }

        protected bool? _sendLoginDisabledNotifyEmail;

        [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        public bool? SendLoginDisabledNotifyEmail
        {
            get => _sendLoginDisabledNotifyEmail;
            set
            {
                SendLoginDisabledNotifyEmailSpecified = (value != null);
                _sendLoginDisabledNotifyEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendLoginDisabledNotifyEmailSpecified { get; set; }

        protected string _loginDisabledNotifyEmailAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        [MinLength(1)]
        [MaxLength(80)]
        public string LoginDisabledNotifyEmailAddress
        {
            get => _loginDisabledNotifyEmailAddress;
            set
            {
                LoginDisabledNotifyEmailAddressSpecified = true;
                _loginDisabledNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool LoginDisabledNotifyEmailAddressSpecified { get; set; }

        protected string _defaultPassword;

        [XmlElement(ElementName = "defaultPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39435")]
        [MinLength(1)]
        [MaxLength(60)]
        public string DefaultPassword
        {
            get => _defaultPassword;
            set
            {
                DefaultPasswordSpecified = (value != null);
                _defaultPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultPasswordSpecified { get; set; }

    }
}
