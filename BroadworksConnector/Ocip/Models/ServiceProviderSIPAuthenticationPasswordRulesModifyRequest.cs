using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSIPAuthenticationPasswordRulesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "useServiceProviderSettings", IsNullable = false)]
    public bool UseServiceProviderSettings { get; set; }
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
    [XmlElement(ElementName = "endpointAuthenticationLockoutType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutType EndpointAuthenticationLockoutType { get; set; }
    [XmlElement(ElementName = "endpointTemporaryLockoutThreshold", IsNullable = false)]
    public int EndpointTemporaryLockoutThreshold { get; set; }
    [XmlElement(ElementName = "endpointWaitAlgorithm", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType EndpointWaitAlgorithm { get; set; }
    [XmlElement(ElementName = "endpointLockoutFixedMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes EndpointLockoutFixedMinutes { get; set; }
    [XmlElement(ElementName = "endpointPermanentLockoutThreshold", IsNullable = false)]
    public int EndpointPermanentLockoutThreshold { get; set; }
    [XmlElement(ElementName = "trunkGroupAuthenticationLockoutType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutType TrunkGroupAuthenticationLockoutType { get; set; }
    [XmlElement(ElementName = "trunkGroupTemporaryLockoutThreshold", IsNullable = false)]
    public int TrunkGroupTemporaryLockoutThreshold { get; set; }
    [XmlElement(ElementName = "trunkGroupWaitAlgorithm", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutWaitAlgorithmType TrunkGroupWaitAlgorithm { get; set; }
    [XmlElement(ElementName = "trunkGroupLockoutFixedMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationLockoutFixedWaitTimeMinutes TrunkGroupLockoutFixedMinutes { get; set; }
    [XmlElement(ElementName = "trunkGroupPermanentLockoutThreshold", IsNullable = false)]
    public int TrunkGroupPermanentLockoutThreshold { get; set; }
 }
}
