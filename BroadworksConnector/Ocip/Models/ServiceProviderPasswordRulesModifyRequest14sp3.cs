using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the service provider's password rules settings
    /// setting applicable to Administrators (Group and Department) and Users.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// forcePasswordChangeAfterReset
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4524""}]")]
    public class ServiceProviderPasswordRulesModifyRequest14sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderPasswordRulesApplyTo _rulesApplyTo;

        [XmlElement(ElementName = "rulesApplyTo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool RulesApplyToSpecified { get; set; }

        private bool _allowWebAddExternalAuthenticationUsers;

        [XmlElement(ElementName = "allowWebAddExternalAuthenticationUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool AllowWebAddExternalAuthenticationUsersSpecified { get; set; }

        private bool _disallowUserId;

        [XmlElement(ElementName = "disallowUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool DisallowUserIdSpecified { get; set; }

        private bool _disallowOldPassword;

        [XmlElement(ElementName = "disallowOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool DisallowOldPasswordSpecified { get; set; }

        private bool _disallowReversedOldPassword;

        [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool DisallowReversedOldPasswordSpecified { get; set; }

        private bool _restrictMinDigits;

        [XmlElement(ElementName = "restrictMinDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool RestrictMinDigitsSpecified { get; set; }

        private int _minDigits;

        [XmlElement(ElementName = "minDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool MinDigitsSpecified { get; set; }

        private bool _restrictMinUpperCaseLetters;

        [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool RestrictMinUpperCaseLettersSpecified { get; set; }

        private int _minUpperCaseLetters;

        [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool MinUpperCaseLettersSpecified { get; set; }

        private bool _restrictMinLowerCaseLetters;

        [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool RestrictMinLowerCaseLettersSpecified { get; set; }

        private int _minLowerCaseLetters;

        [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool MinLowerCaseLettersSpecified { get; set; }

        private bool _restrictMinNonAlphanumericCharacters;

        [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool RestrictMinNonAlphanumericCharactersSpecified { get; set; }

        private int _minNonAlphanumericCharacters;

        [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool MinNonAlphanumericCharactersSpecified { get; set; }

        private int _minLength;

        [XmlElement(ElementName = "minLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool MinLengthSpecified { get; set; }

        private int _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool MaxFailedLoginAttemptsSpecified { get; set; }

        private int _passwordExpiresDays;

        [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool PasswordExpiresDaysSpecified { get; set; }

        private bool _sendLoginDisabledNotifyEmail;

        [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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

        [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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

        private bool _disallowPreviousPasswords;

        [XmlElement(ElementName = "disallowPreviousPasswords", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool DisallowPreviousPasswordsSpecified { get; set; }

        private int _numberOfPreviousPasswords;

        [XmlElement(ElementName = "numberOfPreviousPasswords", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool NumberOfPreviousPasswordsSpecified { get; set; }

        private bool _forcePasswordChangeAfterReset;

        [XmlElement(ElementName = "forcePasswordChangeAfterReset", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4524")]
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
        public bool ForcePasswordChangeAfterResetSpecified { get; set; }

    }
}
