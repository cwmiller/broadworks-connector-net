using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPasswordRulesGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _disallowUserId;

    [XmlElement(ElementName = "disallowUserId", IsNullable = false, Namespace = "")]
    public bool DisallowUserId {
        get => _disallowUserId;
        set {
            DisallowUserIdSpecified = true;
            _disallowUserId = value;
        }
    }

    [XmlIgnore]
    public bool DisallowUserIdSpecified { get; set; }
    private bool _disallowOldPassword;

    [XmlElement(ElementName = "disallowOldPassword", IsNullable = false, Namespace = "")]
    public bool DisallowOldPassword {
        get => _disallowOldPassword;
        set {
            DisallowOldPasswordSpecified = true;
            _disallowOldPassword = value;
        }
    }

    [XmlIgnore]
    public bool DisallowOldPasswordSpecified { get; set; }
    private bool _disallowReversedOldPassword;

    [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false, Namespace = "")]
    public bool DisallowReversedOldPassword {
        get => _disallowReversedOldPassword;
        set {
            DisallowReversedOldPasswordSpecified = true;
            _disallowReversedOldPassword = value;
        }
    }

    [XmlIgnore]
    public bool DisallowReversedOldPasswordSpecified { get; set; }
    private bool _restrictMinDigits;

    [XmlElement(ElementName = "restrictMinDigits", IsNullable = false, Namespace = "")]
    public bool RestrictMinDigits {
        get => _restrictMinDigits;
        set {
            RestrictMinDigitsSpecified = true;
            _restrictMinDigits = value;
        }
    }

    [XmlIgnore]
    public bool RestrictMinDigitsSpecified { get; set; }
    private int _minDigits;

    [XmlElement(ElementName = "minDigits", IsNullable = false, Namespace = "")]
    public int MinDigits {
        get => _minDigits;
        set {
            MinDigitsSpecified = true;
            _minDigits = value;
        }
    }

    [XmlIgnore]
    public bool MinDigitsSpecified { get; set; }
    private bool _restrictMinUpperCaseLetters;

    [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false, Namespace = "")]
    public bool RestrictMinUpperCaseLetters {
        get => _restrictMinUpperCaseLetters;
        set {
            RestrictMinUpperCaseLettersSpecified = true;
            _restrictMinUpperCaseLetters = value;
        }
    }

    [XmlIgnore]
    public bool RestrictMinUpperCaseLettersSpecified { get; set; }
    private int _minUpperCaseLetters;

    [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false, Namespace = "")]
    public int MinUpperCaseLetters {
        get => _minUpperCaseLetters;
        set {
            MinUpperCaseLettersSpecified = true;
            _minUpperCaseLetters = value;
        }
    }

    [XmlIgnore]
    public bool MinUpperCaseLettersSpecified { get; set; }
    private bool _restrictMinLowerCaseLetters;

    [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false, Namespace = "")]
    public bool RestrictMinLowerCaseLetters {
        get => _restrictMinLowerCaseLetters;
        set {
            RestrictMinLowerCaseLettersSpecified = true;
            _restrictMinLowerCaseLetters = value;
        }
    }

    [XmlIgnore]
    public bool RestrictMinLowerCaseLettersSpecified { get; set; }
    private int _minLowerCaseLetters;

    [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false, Namespace = "")]
    public int MinLowerCaseLetters {
        get => _minLowerCaseLetters;
        set {
            MinLowerCaseLettersSpecified = true;
            _minLowerCaseLetters = value;
        }
    }

    [XmlIgnore]
    public bool MinLowerCaseLettersSpecified { get; set; }
    private bool _restrictMinNonAlphanumericCharacters;

    [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
    public bool RestrictMinNonAlphanumericCharacters {
        get => _restrictMinNonAlphanumericCharacters;
        set {
            RestrictMinNonAlphanumericCharactersSpecified = true;
            _restrictMinNonAlphanumericCharacters = value;
        }
    }

    [XmlIgnore]
    public bool RestrictMinNonAlphanumericCharactersSpecified { get; set; }
    private int _minNonAlphanumericCharacters;

    [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false, Namespace = "")]
    public int MinNonAlphanumericCharacters {
        get => _minNonAlphanumericCharacters;
        set {
            MinNonAlphanumericCharactersSpecified = true;
            _minNonAlphanumericCharacters = value;
        }
    }

    [XmlIgnore]
    public bool MinNonAlphanumericCharactersSpecified { get; set; }
    private int _minLength;

    [XmlElement(ElementName = "minLength", IsNullable = false, Namespace = "")]
    public int MinLength {
        get => _minLength;
        set {
            MinLengthSpecified = true;
            _minLength = value;
        }
    }

    [XmlIgnore]
    public bool MinLengthSpecified { get; set; }
    private int _maxFailedLoginAttempts;

    [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
    public int MaxFailedLoginAttempts {
        get => _maxFailedLoginAttempts;
        set {
            MaxFailedLoginAttemptsSpecified = true;
            _maxFailedLoginAttempts = value;
        }
    }

    [XmlIgnore]
    public bool MaxFailedLoginAttemptsSpecified { get; set; }
    private int _passwordExpiresDays;

    [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false, Namespace = "")]
    public int PasswordExpiresDays {
        get => _passwordExpiresDays;
        set {
            PasswordExpiresDaysSpecified = true;
            _passwordExpiresDays = value;
        }
    }

    [XmlIgnore]
    public bool PasswordExpiresDaysSpecified { get; set; }
    private bool _sendLoginDisabledNotifyEmail;

    [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false, Namespace = "")]
    public bool SendLoginDisabledNotifyEmail {
        get => _sendLoginDisabledNotifyEmail;
        set {
            SendLoginDisabledNotifyEmailSpecified = true;
            _sendLoginDisabledNotifyEmail = value;
        }
    }

    [XmlIgnore]
    public bool SendLoginDisabledNotifyEmailSpecified { get; set; }
    private string _loginDisabledNotifyEmailAddress;

    [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = false, Namespace = "")]
    public string LoginDisabledNotifyEmailAddress {
        get => _loginDisabledNotifyEmailAddress;
        set {
            LoginDisabledNotifyEmailAddressSpecified = true;
            _loginDisabledNotifyEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool LoginDisabledNotifyEmailAddressSpecified { get; set; }
    private bool _disallowRulesModification;

    [XmlElement(ElementName = "disallowRulesModification", IsNullable = false, Namespace = "")]
    public bool DisallowRulesModification {
        get => _disallowRulesModification;
        set {
            DisallowRulesModificationSpecified = true;
            _disallowRulesModification = value;
        }
    }

    [XmlIgnore]
    public bool DisallowRulesModificationSpecified { get; set; }
    private bool _disallowPreviousPasswords;

    [XmlElement(ElementName = "disallowPreviousPasswords", IsNullable = false, Namespace = "")]
    public bool DisallowPreviousPasswords {
        get => _disallowPreviousPasswords;
        set {
            DisallowPreviousPasswordsSpecified = true;
            _disallowPreviousPasswords = value;
        }
    }

    [XmlIgnore]
    public bool DisallowPreviousPasswordsSpecified { get; set; }
    private int _numberOfPreviousPasswords;

    [XmlElement(ElementName = "numberOfPreviousPasswords", IsNullable = false, Namespace = "")]
    public int NumberOfPreviousPasswords {
        get => _numberOfPreviousPasswords;
        set {
            NumberOfPreviousPasswordsSpecified = true;
            _numberOfPreviousPasswords = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfPreviousPasswordsSpecified { get; set; }
}
}
