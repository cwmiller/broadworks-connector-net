using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPasswordRulesModifyRequest14sp3 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "rulesApplyTo", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemPasswordRulesApplyTo RulesApplyTo { get; set; }
    [XmlElement(ElementName = "allowWebAddExternalAuthenticationUsers", IsNullable = false)]
    public bool AllowWebAddExternalAuthenticationUsers { get; set; }
    [XmlElement(ElementName = "disallowUserId", IsNullable = false)]
    public bool DisallowUserId { get; set; }
    [XmlElement(ElementName = "disallowOldPassword", IsNullable = false)]
    public bool DisallowOldPassword { get; set; }
    [XmlElement(ElementName = "disallowReversedOldPassword", IsNullable = false)]
    public bool DisallowReversedOldPassword { get; set; }
    [XmlElement(ElementName = "restrictMinDigits", IsNullable = false)]
    public bool RestrictMinDigits { get; set; }
    [XmlElement(ElementName = "minDigits", IsNullable = false)]
    public int MinDigits { get; set; }
    [XmlElement(ElementName = "restrictMinUpperCaseLetters", IsNullable = false)]
    public bool RestrictMinUpperCaseLetters { get; set; }
    [XmlElement(ElementName = "minUpperCaseLetters", IsNullable = false)]
    public int MinUpperCaseLetters { get; set; }
    [XmlElement(ElementName = "restrictMinLowerCaseLetters", IsNullable = false)]
    public bool RestrictMinLowerCaseLetters { get; set; }
    [XmlElement(ElementName = "minLowerCaseLetters", IsNullable = false)]
    public int MinLowerCaseLetters { get; set; }
    [XmlElement(ElementName = "restrictMinNonAlphanumericCharacters", IsNullable = false)]
    public bool RestrictMinNonAlphanumericCharacters { get; set; }
    [XmlElement(ElementName = "minNonAlphanumericCharacters", IsNullable = false)]
    public int MinNonAlphanumericCharacters { get; set; }
    [XmlElement(ElementName = "minLength", IsNullable = false)]
    public int MinLength { get; set; }
    [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false)]
    public int MaxFailedLoginAttempts { get; set; }
    [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false)]
    public int PasswordExpiresDays { get; set; }
    [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false)]
    public bool SendLoginDisabledNotifyEmail { get; set; }
    [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = true)]
    public string LoginDisabledNotifyEmailAddress { get; set; }
    [XmlElement(ElementName = "disallowPreviousPasswords", IsNullable = false)]
    public bool DisallowPreviousPasswords { get; set; }
    [XmlElement(ElementName = "numberOfPreviousPasswords", IsNullable = false)]
    public int NumberOfPreviousPasswords { get; set; }
    [XmlElement(ElementName = "forcePasswordChangeAfterReset", IsNullable = false)]
    public bool ForcePasswordChangeAfterReset { get; set; }
 }
}
