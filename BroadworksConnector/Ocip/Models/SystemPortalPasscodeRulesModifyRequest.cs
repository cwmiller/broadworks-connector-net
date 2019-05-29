using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPortalPasscodeRulesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "disallowRepeatedDigits", IsNullable = false)]
    public bool DisallowRepeatedDigits { get; set; }
    [XmlElement(ElementName = "numberOfRepeatedDigits", IsNullable = false)]
    public int NumberOfRepeatedDigits { get; set; }
    [XmlElement(ElementName = "disallowRepeatedPatterns", IsNullable = false)]
    public bool DisallowRepeatedPatterns { get; set; }
    [XmlElement(ElementName = "disallowContiguousSequences", IsNullable = false)]
    public bool DisallowContiguousSequences { get; set; }
    [XmlElement(ElementName = "numberOfAscendingDigits", IsNullable = false)]
    public int NumberOfAscendingDigits { get; set; }
    [XmlElement(ElementName = "numberOfDescendingDigits", IsNullable = false)]
    public int NumberOfDescendingDigits { get; set; }
    [XmlElement(ElementName = "disallowUserNumber", IsNullable = false)]
    public bool DisallowUserNumber { get; set; }
    [XmlElement(ElementName = "disallowReversedUserNumber", IsNullable = false)]
    public bool DisallowReversedUserNumber { get; set; }
    [XmlElement(ElementName = "disallowOldPasscode", IsNullable = false)]
    public bool DisallowOldPasscode { get; set; }
    [XmlElement(ElementName = "numberOfPreviousPasscodes", IsNullable = false)]
    public int NumberOfPreviousPasscodes { get; set; }
    [XmlElement(ElementName = "disallowReversedOldPasscode", IsNullable = false)]
    public bool DisallowReversedOldPasscode { get; set; }
    [XmlElement(ElementName = "minCodeLength", IsNullable = false)]
    public int MinCodeLength { get; set; }
    [XmlElement(ElementName = "maxCodeLength", IsNullable = false)]
    public int MaxCodeLength { get; set; }
    [XmlElement(ElementName = "disableLoginAfterMaxFailedLoginAttempts", IsNullable = false)]
    public bool DisableLoginAfterMaxFailedLoginAttempts { get; set; }
    [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false)]
    public int MaxFailedLoginAttempts { get; set; }
    [XmlElement(ElementName = "expirePassword", IsNullable = false)]
    public bool ExpirePassword { get; set; }
    [XmlElement(ElementName = "passcodeExpiresDays", IsNullable = false)]
    public int PasscodeExpiresDays { get; set; }
    [XmlElement(ElementName = "sendLoginDisabledNotifyEmail", IsNullable = false)]
    public bool SendLoginDisabledNotifyEmail { get; set; }
    [XmlElement(ElementName = "loginDisabledNotifyEmailAddress", IsNullable = true)]
    public string LoginDisabledNotifyEmailAddress { get; set; }
    [XmlElement(ElementName = "defaultPassword", IsNullable = false)]
    public string DefaultPassword { get; set; }
 }
}
