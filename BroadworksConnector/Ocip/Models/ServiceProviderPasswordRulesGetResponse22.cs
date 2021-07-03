using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderPasswordRulesGetRequest22.
    /// Contains the group, department administrator and/or user password
    /// rules setting.
    /// <see cref="ServiceProviderPasswordRulesGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5300""}]")]
    public class ServiceProviderPasswordRulesGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceProviderPasswordRulesApplyTo _rulesApplyTo;

        [XmlElement(ElementName = "rulesApplyTo", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderPasswordRulesApplyTo RulesApplyTo
        {
            get => _rulesApplyTo;
            set
            {
                RulesApplyToSpecified = true;
                _rulesApplyTo = value;
            }
        }

        [XmlIgnore]
        protected bool RulesApplyToSpecified { get; set; }

        private bool _allowWebAddExternalAuthenticationUsers;

        [XmlElement(ElementName = "allowWebAddExternalAuthenticationUsers", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool AllowWebAddExternalAuthenticationUsers
        {
            get => _allowWebAddExternalAuthenticationUsers;
            set
            {
                AllowWebAddExternalAuthenticationUsersSpecified = true;
                _allowWebAddExternalAuthenticationUsers = value;
            }
        }

        [XmlIgnore]
        protected bool AllowWebAddExternalAuthenticationUsersSpecified { get; set; }

        private bool _disallowUserId;

        [XmlElement(ElementName = "disallowUserId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool DisallowUserId
        {
            get => _disallowUserId;
            set
            {
                DisallowUserIdSpecified = true;
                _disallowUserId = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowUserIdSpecified { get; set; }

        private bool _disallowOldPassword;

        [XmlElement(ElementName = "disallowOldPassword", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool DisallowOldPassword
        {
            get => _disallowOldPassword;
            set
            {
                DisallowOldPasswordSpecified = true;
                _disallowOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowOldPasswordSpecified { get; set; }

        private bool _disallowReversedOldPassword;

        [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool DisallowReversedOldPassword
        {
            get => _disallowReversedOldPassword;
            set
            {
                DisallowReversedOldPasswordSpecified = true;
                _disallowReversedOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowReversedOldPasswordSpecified { get; set; }

        private bool _restrictMinDigits;

        [XmlElement(ElementName = "restrictMinDigits", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool RestrictMinDigits
        {
            get => _restrictMinDigits;
            set
            {
                RestrictMinDigitsSpecified = true;
                _restrictMinDigits = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinDigitsSpecified { get; set; }

        private int _minDigits;

        [XmlElement(ElementName = "minDigits", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinDigits
        {
            get => _minDigits;
            set
            {
                MinDigitsSpecified = true;
                _minDigits = value;
            }
        }

        [XmlIgnore]
        protected bool MinDigitsSpecified { get; set; }

        private bool _restrictMinUpperCaseLetters;

        [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool RestrictMinUpperCaseLetters
        {
            get => _restrictMinUpperCaseLetters;
            set
            {
                RestrictMinUpperCaseLettersSpecified = true;
                _restrictMinUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinUpperCaseLettersSpecified { get; set; }

        private int _minUpperCaseLetters;

        [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinUpperCaseLetters
        {
            get => _minUpperCaseLetters;
            set
            {
                MinUpperCaseLettersSpecified = true;
                _minUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinUpperCaseLettersSpecified { get; set; }

        private bool _restrictMinLowerCaseLetters;

        [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool RestrictMinLowerCaseLetters
        {
            get => _restrictMinLowerCaseLetters;
            set
            {
                RestrictMinLowerCaseLettersSpecified = true;
                _restrictMinLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinLowerCaseLettersSpecified { get; set; }

        private int _minLowerCaseLetters;

        [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinLowerCaseLetters
        {
            get => _minLowerCaseLetters;
            set
            {
                MinLowerCaseLettersSpecified = true;
                _minLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinLowerCaseLettersSpecified { get; set; }

        private bool _restrictMinNonAlphanumericCharacters;

        [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool RestrictMinNonAlphanumericCharacters
        {
            get => _restrictMinNonAlphanumericCharacters;
            set
            {
                RestrictMinNonAlphanumericCharactersSpecified = true;
                _restrictMinNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinNonAlphanumericCharactersSpecified { get; set; }

        private int _minNonAlphanumericCharacters;

        [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MinNonAlphanumericCharacters
        {
            get => _minNonAlphanumericCharacters;
            set
            {
                MinNonAlphanumericCharactersSpecified = true;
                _minNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool MinNonAlphanumericCharactersSpecified { get; set; }

        private int _minLength;

        [XmlElement(ElementName = "minLength", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(3)]
        [MaxInclusive(40)]
        public int MinLength
        {
            get => _minLength;
            set
            {
                MinLengthSpecified = true;
                _minLength = value;
            }
        }

        [XmlIgnore]
        protected bool MinLengthSpecified { get; set; }

        private int _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(0)]
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

        private int _passwordExpiresDays;

        [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(0)]
        [MaxInclusive(199)]
        public int PasswordExpiresDays
        {
            get => _passwordExpiresDays;
            set
            {
                PasswordExpiresDaysSpecified = true;
                _passwordExpiresDays = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordExpiresDaysSpecified { get; set; }

        private bool _sendLoginDisabledNotifyEmail;

        [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
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

        private string _loginDisabledNotifyEmailAddress;

        [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
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

        private bool _disallowRulesModification;

        [XmlElement(ElementName = "disallowRulesModification", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool DisallowRulesModification
        {
            get => _disallowRulesModification;
            set
            {
                DisallowRulesModificationSpecified = true;
                _disallowRulesModification = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowRulesModificationSpecified { get; set; }

        private bool _disallowPreviousPasswords;

        [XmlElement(ElementName = "disallowPreviousPasswords", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool DisallowPreviousPasswords
        {
            get => _disallowPreviousPasswords;
            set
            {
                DisallowPreviousPasswordsSpecified = true;
                _disallowPreviousPasswords = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowPreviousPasswordsSpecified { get; set; }

        private int _numberOfPreviousPasswords;

        [XmlElement(ElementName = "numberOfPreviousPasswords", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int NumberOfPreviousPasswords
        {
            get => _numberOfPreviousPasswords;
            set
            {
                NumberOfPreviousPasswordsSpecified = true;
                _numberOfPreviousPasswords = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfPreviousPasswordsSpecified { get; set; }

        private bool _forcePasswordChangeAfterReset;

        [XmlElement(ElementName = "forcePasswordChangeAfterReset", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5300")]
        public bool ForcePasswordChangeAfterReset
        {
            get => _forcePasswordChangeAfterReset;
            set
            {
                ForcePasswordChangeAfterResetSpecified = true;
                _forcePasswordChangeAfterReset = value;
            }
        }

        [XmlIgnore]
        protected bool ForcePasswordChangeAfterResetSpecified { get; set; }

    }
}
