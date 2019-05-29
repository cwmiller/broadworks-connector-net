using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeAddRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    [XmlElement(ElementName = "holdNormalization", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HoldNormalizationMode HoldNormalization { get; set; }
    [XmlElement(ElementName = "holdAnnouncementMethod", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HoldAnnouncementMethodMode HoldAnnouncementMethod { get; set; }
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
    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false)]
    public bool StaticRegistrationCapable { get; set; }
    [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CPEDeviceOptions16sp1 CpeDeviceOptions { get; set; }
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
    [XmlElement(ElementName = "resetEvent", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceResetEvent ResetEvent { get; set; }
    [XmlElement(ElementName = "supportCallCenterMIMEType", IsNullable = false)]
    public bool SupportCallCenterMIMEType { get; set; }
    [XmlElement(ElementName = "trunkMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkMode TrunkMode { get; set; }
    [XmlElement(ElementName = "addPCalledPartyId", IsNullable = false)]
    public bool AddPCalledPartyId { get; set; }
    [XmlElement(ElementName = "supportIdentityInUpdateAndReInvite", IsNullable = false)]
    public bool SupportIdentityInUpdateAndReInvite { get; set; }
    [XmlElement(ElementName = "unscreenedPresentationIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnscreenedPresentationIdentityPolicy UnscreenedPresentationIdentityPolicy { get; set; }
    [XmlElement(ElementName = "enhancedForICS", IsNullable = false)]
    public bool EnhancedForICS { get; set; }
    [XmlElement(ElementName = "supportEmergencyDisconnectControl", IsNullable = false)]
    public bool SupportEmergencyDisconnectControl { get; set; }
    [XmlElement(ElementName = "deviceTypeConfigurationOption", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceTypeConfigurationOptionType DeviceTypeConfigurationOption { get; set; }
    [XmlElement(ElementName = "supportRFC3398", IsNullable = false)]
    public bool SupportRFC3398 { get; set; }
    [XmlElement(ElementName = "staticLineOrdering", IsNullable = false)]
    public bool StaticLineOrdering { get; set; }
    [XmlElement(ElementName = "supportClientSessionInfo", IsNullable = false)]
    public bool SupportClientSessionInfo { get; set; }
    [XmlElement(ElementName = "supportCallInfoConferenceSubscriptionURI", IsNullable = false)]
    public bool SupportCallInfoConferenceSubscriptionURI { get; set; }
    [XmlElement(ElementName = "supportRemotePartyInfo", IsNullable = false)]
    public bool SupportRemotePartyInfo { get; set; }
    [XmlElement(ElementName = "supportVisualDeviceManagement", IsNullable = false)]
    public bool SupportVisualDeviceManagement { get; set; }
    [XmlElement(ElementName = "bypassMediaTreatment", IsNullable = false)]
    public bool BypassMediaTreatment { get; set; }
    [XmlElement(ElementName = "supports3G4GContinuity", IsNullable = false)]
    public bool Supports3G4GContinuity { get; set; }
    [XmlElement(ElementName = "publishesOwnPresence", IsNullable = false)]
    public bool PublishesOwnPresence { get; set; }
    [XmlElement(ElementName = "supportCauseParameter", IsNullable = false)]
    public bool SupportCauseParameter { get; set; }
    [XmlElement(ElementName = "locationNetwork", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LocationNetworkType LocationNetwork { get; set; }
 }
}
