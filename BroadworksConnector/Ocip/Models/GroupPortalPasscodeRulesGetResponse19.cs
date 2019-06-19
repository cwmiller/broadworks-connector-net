using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPortalPasscodeRulesGetRequest19.
    /// Contains the group's passcode rules setting.
    /// 
    /// The following elements are only used in AS data mode:
    /// numberOfRepeatedDigits
    /// disallowRepeatedPatterns
    /// disallowContiguousSequences
    /// numberOfAscendingDigits
    /// numberOfDescendingDigits
    /// numberOfPreviousPasscodes
    /// <see cref="GroupPortalPasscodeRulesGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6063""}]")]
    public class GroupPortalPasscodeRulesGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupPasscodeRulesLevel _useRuleLevel;

        [XmlElement(ElementName = "useRuleLevel", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
        public BroadWorksConnector.Ocip.Models.GroupPasscodeRulesLevel UseRuleLevel
        {
            get => _useRuleLevel;
            set
            {
                UseRuleLevelSpecified = true;
                _useRuleLevel = value;
            }
        }

        [XmlIgnore]
        public bool UseRuleLevelSpecified { get; set; }

        private bool _disallowRepeatedDigits;

        [XmlElement(ElementName = "disallowRepeatedDigits", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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

        private int _numberOfRepeatedDigits;

        [XmlElement(ElementName = "numberOfRepeatedDigits", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
        [MinInclusive(1)]
        [MaxInclusive(6)]
        public int NumberOfRepeatedDigits
        {
            get => _numberOfRepeatedDigits;
            set
            {
                NumberOfRepeatedDigitsSpecified = true;
                _numberOfRepeatedDigits = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfRepeatedDigitsSpecified { get; set; }

        private bool _disallowRepeatedPatterns;

        [XmlElement(ElementName = "disallowRepeatedPatterns", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
        public bool DisallowRepeatedPatterns
        {
            get => _disallowRepeatedPatterns;
            set
            {
                DisallowRepeatedPatternsSpecified = true;
                _disallowRepeatedPatterns = value;
            }
        }

        [XmlIgnore]
        public bool DisallowRepeatedPatternsSpecified { get; set; }

        private bool _disallowContiguousSequences;

        [XmlElement(ElementName = "disallowContiguousSequences", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
        public bool DisallowContiguousSequences
        {
            get => _disallowContiguousSequences;
            set
            {
                DisallowContiguousSequencesSpecified = true;
                _disallowContiguousSequences = value;
            }
        }

        [XmlIgnore]
        public bool DisallowContiguousSequencesSpecified { get; set; }

        private int _numberOfAscendingDigits;

        [XmlElement(ElementName = "numberOfAscendingDigits", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
        [MinInclusive(2)]
        [MaxInclusive(5)]
        public int NumberOfAscendingDigits
        {
            get => _numberOfAscendingDigits;
            set
            {
                NumberOfAscendingDigitsSpecified = true;
                _numberOfAscendingDigits = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfAscendingDigitsSpecified { get; set; }

        private int _numberOfDescendingDigits;

        [XmlElement(ElementName = "numberOfDescendingDigits", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
        [MinInclusive(2)]
        [MaxInclusive(5)]
        public int NumberOfDescendingDigits
        {
            get => _numberOfDescendingDigits;
            set
            {
                NumberOfDescendingDigitsSpecified = true;
                _numberOfDescendingDigits = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfDescendingDigitsSpecified { get; set; }

        private bool _disallowUserNumber;

        [XmlElement(ElementName = "disallowUserNumber", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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

        private int _numberOfPreviousPasscodes;

        [XmlElement(ElementName = "numberOfPreviousPasscodes", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int NumberOfPreviousPasscodes
        {
            get => _numberOfPreviousPasscodes;
            set
            {
                NumberOfPreviousPasscodesSpecified = true;
                _numberOfPreviousPasscodes = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfPreviousPasscodesSpecified { get; set; }

        private bool _disallowReversedOldPasscode;

        [XmlElement(ElementName = "disallowReversedOldPasscode", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6063")]
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

    }
}
