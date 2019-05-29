using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceProfileAuthenticationPasswordRulesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "disallowAuthenticationName", IsNullable = false)]
    public bool DisallowAuthenticationName { get; set; }
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
    [XmlElement(ElementName = "sendPermanentLockoutNotification", IsNullable = false)]
    public bool SendPermanentLockoutNotification { get; set; }
    [XmlElement(ElementName = "permanentLockoutNotifyEmailAddress", IsNullable = true)]
    public string PermanentLockoutNotifyEmailAddress { get; set; }
    [XmlElement(ElementName = "deviceProfileAuthenticationLockoutType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutType DeviceProfileAuthenticationLockoutType { get; set; }
    [XmlElement(ElementName = "deviceProfileTemporaryLockoutThreshold", IsNullable = false)]
    public int DeviceProfileTemporaryLockoutThreshold { get; set; }
    [XmlElement(ElementName = "deviceProfileWaitAlgorithm", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType DeviceProfileWaitAlgorithm { get; set; }
    [XmlElement(ElementName = "deviceProfileLockoutFixedMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes DeviceProfileLockoutFixedMinutes { get; set; }
    [XmlElement(ElementName = "deviceProfilePermanentLockoutThreshold", IsNullable = false)]
    public int DeviceProfilePermanentLockoutThreshold { get; set; }
 }
}
