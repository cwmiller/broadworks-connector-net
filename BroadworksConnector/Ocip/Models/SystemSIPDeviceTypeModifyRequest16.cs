using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeModifyRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "isObsolete", IsNullable = false)]
    public bool IsObsolete { get; set; }
    [XmlElement(ElementName = "registrationCapable", IsNullable = false)]
    public bool RegistrationCapable { get; set; }
    [XmlElement(ElementName = "RFC3264Hold", IsNullable = false)]
    public bool RFC3264Hold { get; set; }
    [XmlElement(ElementName = "isTrusted", IsNullable = false)]
    public bool IsTrusted { get; set; }
    [XmlElement(ElementName = "E164Capable", IsNullable = false)]
    public bool E164Capable { get; set; }
    [XmlElement(ElementName = "routeAdvance", IsNullable = false)]
    public bool RouteAdvance { get; set; }
    [XmlElement(ElementName = "forwardingOverride", IsNullable = false)]
    public bool ForwardingOverride { get; set; }
    [XmlElement(ElementName = "wirelessIntegration", IsNullable = false)]
    public bool WirelessIntegration { get; set; }
    [XmlElement(ElementName = "webBasedConfigURL", IsNullable = true)]
    public string WebBasedConfigURL { get; set; }
    [XmlElement(ElementName = "isVideoCapable", IsNullable = false)]
    public bool IsVideoCapable { get; set; }
    [XmlElement(ElementName = "PBXIntegration", IsNullable = false)]
    public bool PBXIntegration { get; set; }
    [XmlElement(ElementName = "useBusinessTrunkingContact", IsNullable = false)]
    public bool UseBusinessTrunkingContact { get; set; }
    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false)]
    public bool StaticRegistrationCapable { get; set; }
    [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CPEDeviceModifyOptions16 CpeDeviceOptions { get; set; }
    [XmlElement(ElementName = "earlyMediaSupport", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EarlyMediaSupportType EarlyMediaSupport { get; set; }
    [XmlElement(ElementName = "authenticateRefer", IsNullable = false)]
    public bool AuthenticateRefer { get; set; }
    [XmlElement(ElementName = "autoConfigSoftClient", IsNullable = false)]
    public bool AutoConfigSoftClient { get; set; }
    [XmlElement(ElementName = "authenticationMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationMode AuthenticationMode { get; set; }
    [XmlElement(ElementName = "requiresBroadWorksDigitCollection", IsNullable = false)]
    public bool RequiresBroadWorksDigitCollection { get; set; }
    [XmlElement(ElementName = "requiresBroadWorksCallWaitingTone", IsNullable = false)]
    public bool RequiresBroadWorksCallWaitingTone { get; set; }
    [XmlElement(ElementName = "requiresMWISubscription", IsNullable = false)]
    public bool RequiresMWISubscription { get; set; }
    [XmlElement(ElementName = "useHistoryInfoHeaderOnAccessSide", IsNullable = false)]
    public bool UseHistoryInfoHeaderOnAccessSide { get; set; }
    [XmlElement(ElementName = "adviceOfChargeCapable", IsNullable = false)]
    public bool AdviceOfChargeCapable { get; set; }
 }
}
