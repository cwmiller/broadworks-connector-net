using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPortalPasscodeRulesGetRequest.
    /// Contains the system passcode rules setting.
    /// 
    /// Replaced by: SystemPortalPasscodeRulesGetResponse19
    /// <see cref="SystemPortalPasscodeRulesGetRequest"/>
    /// <see cref="SystemPortalPasscodeRulesGetResponse19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26347""}]")]
    public class SystemPortalPasscodeRulesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _disallowRepeatedDigits;

        [XmlElement(ElementName = "disallowRepeatedDigits", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool DisallowRepeatedDigits
        {
            get => _disallowRepeatedDigits;
            set
            {
                DisallowRepeatedDigitsSpecified = true;
                _disallowRepeatedDigits = value;
            }
        }

        [XmlIgnore]
        public bool DisallowRepeatedDigitsSpecified { get; set; }

        private bool _disallowUserNumber;

        [XmlElement(ElementName = "disallowUserNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool DisallowUserNumber
        {
            get => _disallowUserNumber;
            set
            {
                DisallowUserNumberSpecified = true;
                _disallowUserNumber = value;
            }
        }

        [XmlIgnore]
        public bool DisallowUserNumberSpecified { get; set; }

        private bool _disallowReversedUserNumber;

        [XmlElement(ElementName = "disallowReversedUserNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool DisallowReversedUserNumber
        {
            get => _disallowReversedUserNumber;
            set
            {
                DisallowReversedUserNumberSpecified = true;
                _disallowReversedUserNumber = value;
            }
        }

        [XmlIgnore]
        public bool DisallowReversedUserNumberSpecified { get; set; }

        private bool _disallowOldPasscode;

        [XmlElement(ElementName = "disallowOldPasscode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool DisallowOldPasscode
        {
            get => _disallowOldPasscode;
            set
            {
                DisallowOldPasscodeSpecified = true;
                _disallowOldPasscode = value;
            }
        }

        [XmlIgnore]
        public bool DisallowOldPasscodeSpecified { get; set; }

        private bool _disallowReversedOldPasscode;

        [XmlElement(ElementName = "disallowReversedOldPasscode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool DisallowReversedOldPasscode
        {
            get => _disallowReversedOldPasscode;
            set
            {
                DisallowReversedOldPasscodeSpecified = true;
                _disallowReversedOldPasscode = value;
            }
        }

        [XmlIgnore]
        public bool DisallowReversedOldPasscodeSpecified { get; set; }

        private int _minCodeLength;

        [XmlElement(ElementName = "minCodeLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        [MinInclusive(2)]
        [MaxInclusive(15)]
        public int MinCodeLength
        {
            get => _minCodeLength;
            set
            {
                MinCodeLengthSpecified = true;
                _minCodeLength = value;
            }
        }

        [XmlIgnore]
        public bool MinCodeLengthSpecified { get; set; }

        private int _maxCodeLength;

        [XmlElement(ElementName = "maxCodeLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        [MinInclusive(3)]
        [MaxInclusive(30)]
        public int MaxCodeLength
        {
            get => _maxCodeLength;
            set
            {
                MaxCodeLengthSpecified = true;
                _maxCodeLength = value;
            }
        }

        [XmlIgnore]
        public bool MaxCodeLengthSpecified { get; set; }

        private bool _disableLoginAfterMaxFailedLoginAttempts;

        [XmlElement(ElementName = "disableLoginAfterMaxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool DisableLoginAfterMaxFailedLoginAttempts
        {
            get => _disableLoginAfterMaxFailedLoginAttempts;
            set
            {
                DisableLoginAfterMaxFailedLoginAttemptsSpecified = true;
                _disableLoginAfterMaxFailedLoginAttempts = value;
            }
        }

        [XmlIgnore]
        public bool DisableLoginAfterMaxFailedLoginAttemptsSpecified { get; set; }

        private int _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        [MinInclusive(2)]
        [MaxInclusive(10)]
        public int MaxFailedLoginAttempts
        {
            get => _maxFailedLoginAttempts;
            set
            {
                MaxFailedLoginAttemptsSpecified = true;
                _maxFailedLoginAttempts = value;
            }
        }

        [XmlIgnore]
        public bool MaxFailedLoginAttemptsSpecified { get; set; }

        private bool _expirePassword;

        [XmlElement(ElementName = "expirePassword", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool ExpirePassword
        {
            get => _expirePassword;
            set
            {
                ExpirePasswordSpecified = true;
                _expirePassword = value;
            }
        }

        [XmlIgnore]
        public bool ExpirePasswordSpecified { get; set; }

        private int _passcodeExpiresDays;

        [XmlElement(ElementName = "passcodeExpiresDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        [MinInclusive(15)]
        [MaxInclusive(180)]
        public int PasscodeExpiresDays
        {
            get => _passcodeExpiresDays;
            set
            {
                PasscodeExpiresDaysSpecified = true;
                _passcodeExpiresDays = value;
            }
        }

        [XmlIgnore]
        public bool PasscodeExpiresDaysSpecified { get; set; }

        private bool _sendLoginDisabledNotifyEmail;

        [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        public bool SendLoginDisabledNotifyEmail
        {
            get => _sendLoginDisabledNotifyEmail;
            set
            {
                SendLoginDisabledNotifyEmailSpecified = true;
                _sendLoginDisabledNotifyEmail = value;
            }
        }

        [XmlIgnore]
        public bool SendLoginDisabledNotifyEmailSpecified { get; set; }

        private string _loginDisabledNotifyEmailAddress;

        [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
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
        public bool LoginDisabledNotifyEmailAddressSpecified { get; set; }

        private string _defaultPassword;

        [XmlElement(ElementName = "defaultPassword", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26347")]
        [MinLength(1)]
        [MaxLength(60)]
        public string DefaultPassword
        {
            get => _defaultPassword;
            set
            {
                DefaultPasswordSpecified = true;
                _defaultPassword = value;
            }
        }

        [XmlIgnore]
        public bool DefaultPasswordSpecified { get; set; }

    }
}
