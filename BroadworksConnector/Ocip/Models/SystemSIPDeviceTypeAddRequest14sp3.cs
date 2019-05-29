using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeAddRequest14sp3 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "numberOfPorts", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts { get; set; }
    [XmlElement(ElementName = "profile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SignalingAddressType Profile { get; set; }
    [XmlElement(ElementName = "registrationCapable", IsNullable = false)]
    public bool RegistrationCapable { get; set; }
    [XmlElement(ElementName = "isConferenceDevice", IsNullable = false)]
    public bool IsConferenceDevice { get; set; }
    [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false)]
    public bool IsMobilityManagerDevice { get; set; }
    [XmlElement(ElementName = "isMusicOnHoldDevice", IsNullable = false)]
    public bool IsMusicOnHoldDevice { get; set; }
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
    [XmlElement(ElementName = "webBasedConfigURL", IsNullable = false)]
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
    public BroadworksConnector.Ocip.Models.CPEDeviceOptions CpeDeviceOptions { get; set; }
    [XmlElement(ElementName = "earlyMediaSupport", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EarlyMediaSupportType EarlyMediaSupport { get; set; }
    [XmlElement(ElementName = "authenticateRefer", IsNullable = false)]
    public bool AuthenticateRefer { get; set; }
    [XmlElement(ElementName = "autoConfigSoftClient", IsNullable = false)]
    public bool AutoConfigSoftClient { get; set; }
    [XmlElement(ElementName = "authenticationMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AuthenticationMode AuthenticationMode { get; set; }
    [XmlElement(ElementName = "tdmOverlay", IsNullable = false)]
    public bool TdmOverlay { get; set; }
    [XmlElement(ElementName = "supportsBroadWorksINFOForCallWaiting", IsNullable = false)]
    public bool SupportsBroadWorksINFOForCallWaiting { get; set; }
 }
}
