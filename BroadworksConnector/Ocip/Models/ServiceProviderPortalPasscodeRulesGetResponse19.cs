using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderPortalPasscodeRulesGetRequest19.
    /// Contains the service provider's passcode rules setting.
    /// 
    /// The following elements are only used in AS data mode:
    /// numberOfRepeatedDigits
    /// disallowRepeatedPatterns
    /// disallowContiguousSequences
    /// numberOfAscendingDigits
    /// numberOfDescendingDigits
    /// numberOfPreviousPasscodes
    /// 
    /// Replaced by: ServiceProviderPortalPasscodeRulesGetResponse22 in AS data mode.
    /// <see cref="ServiceProviderPortalPasscodeRulesGetRequest19"/>
    /// <see cref="ServiceProviderPortalPasscodeRulesGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:7163""}]")]
    public class ServiceProviderPortalPasscodeRulesGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _disallowRepeatedDigits;

        [XmlElement(ElementName = "disallowRepeatedDigits", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisallowRepeatedDigitsSpecified { get; set; }

        protected int _numberOfRepeatedDigits;

        [XmlElement(ElementName = "numberOfRepeatedDigits", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool NumberOfRepeatedDigitsSpecified { get; set; }

        protected bool _disallowRepeatedPatterns;

        [XmlElement(ElementName = "disallowRepeatedPatterns", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisallowRepeatedPatternsSpecified { get; set; }

        protected bool _disallowContiguousSequences;

        [XmlElement(ElementName = "disallowContiguousSequences", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisallowContiguousSequencesSpecified { get; set; }

        protected int _numberOfAscendingDigits;

        [XmlElement(ElementName = "numberOfAscendingDigits", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool NumberOfAscendingDigitsSpecified { get; set; }

        protected int _numberOfDescendingDigits;

        [XmlElement(ElementName = "numberOfDescendingDigits", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool NumberOfDescendingDigitsSpecified { get; set; }

        protected bool _disallowUserNumber;

        [XmlElement(ElementName = "disallowUserNumber", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisallowUserNumberSpecified { get; set; }

        protected bool _disallowReversedUserNumber;

        [XmlElement(ElementName = "disallowReversedUserNumber", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisallowReversedUserNumberSpecified { get; set; }

        protected bool _disallowOldPasscode;

        [XmlElement(ElementName = "disallowOldPasscode", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisallowOldPasscodeSpecified { get; set; }

        protected int _numberOfPreviousPasscodes;

        [XmlElement(ElementName = "numberOfPreviousPasscodes", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool NumberOfPreviousPasscodesSpecified { get; set; }

        protected bool _disallowReversedOldPasscode;

        [XmlElement(ElementName = "disallowReversedOldPasscode", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisallowReversedOldPasscodeSpecified { get; set; }

        protected int _minCodeLength;

        [XmlElement(ElementName = "minCodeLength", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool MinCodeLengthSpecified { get; set; }

        protected int _maxCodeLength;

        [XmlElement(ElementName = "maxCodeLength", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool MaxCodeLengthSpecified { get; set; }

        protected bool _disableLoginAfterMaxFailedLoginAttempts;

        [XmlElement(ElementName = "disableLoginAfterMaxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool DisableLoginAfterMaxFailedLoginAttemptsSpecified { get; set; }

        protected int _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool MaxFailedLoginAttemptsSpecified { get; set; }

        protected bool _expirePassword;

        [XmlElement(ElementName = "expirePassword", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool ExpirePasswordSpecified { get; set; }

        protected int _passcodeExpiresDays;

        [XmlElement(ElementName = "passcodeExpiresDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool PasscodeExpiresDaysSpecified { get; set; }

        protected bool _sendLoginDisabledNotifyEmail;

        [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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
        protected bool SendLoginDisabledNotifyEmailSpecified { get; set; }

        protected string _loginDisabledNotifyEmailAddress;

        [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7163")]
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

    }
}
