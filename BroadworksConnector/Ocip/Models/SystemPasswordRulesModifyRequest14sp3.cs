using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system providers password rule
    /// setting applicable to System Adminstrator, Provisioning Administrator,
    /// and/or Service Provider Administrator, Group Administrator, Department Administrator, User.
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:11089""}]")]
    public class SystemPasswordRulesModifyRequest14sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.SystemPasswordRulesApplyTo? _rulesApplyTo;

        [XmlElement(ElementName = "rulesApplyTo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public BroadWorksConnector.Ocip.Models.SystemPasswordRulesApplyTo? RulesApplyTo
        {
            get => _rulesApplyTo;
            set
            {
                RulesApplyToSpecified = (value != null);
                _rulesApplyTo = value;
            }
        }

        [XmlIgnore]
        protected bool RulesApplyToSpecified { get; set; }

        protected bool? _allowWebAddExternalAuthenticationUsers;

        [XmlElement(ElementName = "allowWebAddExternalAuthenticationUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? AllowWebAddExternalAuthenticationUsers
        {
            get => _allowWebAddExternalAuthenticationUsers;
            set
            {
                AllowWebAddExternalAuthenticationUsersSpecified = (value != null);
                _allowWebAddExternalAuthenticationUsers = value;
            }
        }

        [XmlIgnore]
        protected bool AllowWebAddExternalAuthenticationUsersSpecified { get; set; }

        protected bool? _disallowUserId;

        [XmlElement(ElementName = "disallowUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? DisallowUserId
        {
            get => _disallowUserId;
            set
            {
                DisallowUserIdSpecified = (value != null);
                _disallowUserId = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowUserIdSpecified { get; set; }

        protected bool? _disallowOldPassword;

        [XmlElement(ElementName = "disallowOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? DisallowOldPassword
        {
            get => _disallowOldPassword;
            set
            {
                DisallowOldPasswordSpecified = (value != null);
                _disallowOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowOldPasswordSpecified { get; set; }

        protected bool? _disallowReversedOldPassword;

        [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? DisallowReversedOldPassword
        {
            get => _disallowReversedOldPassword;
            set
            {
                DisallowReversedOldPasswordSpecified = (value != null);
                _disallowReversedOldPassword = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowReversedOldPasswordSpecified { get; set; }

        protected bool? _restrictMinDigits;

        [XmlElement(ElementName = "restrictMinDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? RestrictMinDigits
        {
            get => _restrictMinDigits;
            set
            {
                RestrictMinDigitsSpecified = (value != null);
                _restrictMinDigits = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinDigitsSpecified { get; set; }

        protected int? _minDigits;

        [XmlElement(ElementName = "minDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinDigits
        {
            get => _minDigits;
            set
            {
                MinDigitsSpecified = (value != null);
                _minDigits = value;
            }
        }

        [XmlIgnore]
        protected bool MinDigitsSpecified { get; set; }

        protected bool? _restrictMinUpperCaseLetters;

        [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? RestrictMinUpperCaseLetters
        {
            get => _restrictMinUpperCaseLetters;
            set
            {
                RestrictMinUpperCaseLettersSpecified = (value != null);
                _restrictMinUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinUpperCaseLettersSpecified { get; set; }

        protected int? _minUpperCaseLetters;

        [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinUpperCaseLetters
        {
            get => _minUpperCaseLetters;
            set
            {
                MinUpperCaseLettersSpecified = (value != null);
                _minUpperCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinUpperCaseLettersSpecified { get; set; }

        protected bool? _restrictMinLowerCaseLetters;

        [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? RestrictMinLowerCaseLetters
        {
            get => _restrictMinLowerCaseLetters;
            set
            {
                RestrictMinLowerCaseLettersSpecified = (value != null);
                _restrictMinLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinLowerCaseLettersSpecified { get; set; }

        protected int? _minLowerCaseLetters;

        [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinLowerCaseLetters
        {
            get => _minLowerCaseLetters;
            set
            {
                MinLowerCaseLettersSpecified = (value != null);
                _minLowerCaseLetters = value;
            }
        }

        [XmlIgnore]
        protected bool MinLowerCaseLettersSpecified { get; set; }

        protected bool? _restrictMinNonAlphanumericCharacters;

        [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? RestrictMinNonAlphanumericCharacters
        {
            get => _restrictMinNonAlphanumericCharacters;
            set
            {
                RestrictMinNonAlphanumericCharactersSpecified = (value != null);
                _restrictMinNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictMinNonAlphanumericCharactersSpecified { get; set; }

        protected int? _minNonAlphanumericCharacters;

        [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MinNonAlphanumericCharacters
        {
            get => _minNonAlphanumericCharacters;
            set
            {
                MinNonAlphanumericCharactersSpecified = (value != null);
                _minNonAlphanumericCharacters = value;
            }
        }

        [XmlIgnore]
        protected bool MinNonAlphanumericCharactersSpecified { get; set; }

        protected int? _minLength;

        [XmlElement(ElementName = "minLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(3)]
        [MaxInclusive(40)]
        public int? MinLength
        {
            get => _minLength;
            set
            {
                MinLengthSpecified = (value != null);
                _minLength = value;
            }
        }

        [XmlIgnore]
        protected bool MinLengthSpecified { get; set; }

        protected int? _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(0)]
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

        protected int? _passwordExpiresDays;

        [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(0)]
        [MaxInclusive(199)]
        public int? PasswordExpiresDays
        {
            get => _passwordExpiresDays;
            set
            {
                PasswordExpiresDaysSpecified = (value != null);
                _passwordExpiresDays = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordExpiresDaysSpecified { get; set; }

        protected bool? _sendLoginDisabledNotifyEmail;

        [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
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

        protected bool? _disallowPreviousPasswords;

        [XmlElement(ElementName = "disallowPreviousPasswords", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? DisallowPreviousPasswords
        {
            get => _disallowPreviousPasswords;
            set
            {
                DisallowPreviousPasswordsSpecified = (value != null);
                _disallowPreviousPasswords = value;
            }
        }

        [XmlIgnore]
        protected bool DisallowPreviousPasswordsSpecified { get; set; }

        protected int? _numberOfPreviousPasswords;

        [XmlElement(ElementName = "numberOfPreviousPasswords", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? NumberOfPreviousPasswords
        {
            get => _numberOfPreviousPasswords;
            set
            {
                NumberOfPreviousPasswordsSpecified = (value != null);
                _numberOfPreviousPasswords = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfPreviousPasswordsSpecified { get; set; }

        protected bool? _forcePasswordChangeAfterReset;

        [XmlElement(ElementName = "forcePasswordChangeAfterReset", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? ForcePasswordChangeAfterReset
        {
            get => _forcePasswordChangeAfterReset;
            set
            {
                ForcePasswordChangeAfterResetSpecified = (value != null);
                _forcePasswordChangeAfterReset = value;
            }
        }

        [XmlIgnore]
        protected bool ForcePasswordChangeAfterResetSpecified { get; set; }

        protected bool? _enforceExternalAuthForRoutePoint;

        [XmlElement(ElementName = "enforceExternalAuthForRoutePoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11089")]
        public bool? EnforceExternalAuthForRoutePoint
        {
            get => _enforceExternalAuthForRoutePoint;
            set
            {
                EnforceExternalAuthForRoutePointSpecified = (value != null);
                _enforceExternalAuthForRoutePoint = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceExternalAuthForRoutePointSpecified { get; set; }

    }
}
