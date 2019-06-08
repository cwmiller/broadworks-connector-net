using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceCategory{
    [XmlEnum(Name = "Call Transfer")]
    CallTransfer,
    [XmlEnum(Name = "Call Waiting")]
    CallWaiting,
    [XmlEnum(Name = "Calling Name Retrieval")]
    CallingNameRetrieval,
    [XmlEnum(Name = "Charge Number")]
    ChargeNumber,
    [XmlEnum(Name = "External Calling Line ID Delivery")]
    ExternalCallingLineIDDelivery,
    [XmlEnum(Name = "Group Night Forwarding")]
    GroupNightForwarding,
    [XmlEnum(Name = "Integrated IMP")]
    IntegratedIMP,
    [XmlEnum(Name = "Intercept Group")]
    InterceptGroup,
    [XmlEnum(Name = "Internal Calling Line ID Delivery")]
    InternalCallingLineIDDelivery,
    [XmlEnum(Name = "Music On Hold")]
    MusicOnHold,
    [XmlEnum(Name = "OMA Presence")]
    OMAPresence,
    [XmlEnum(Name = "Prepaid")]
    Prepaid,
    [XmlEnum(Name = "Shared Call Appearance")]
    SharedCallAppearance,
    [XmlEnum(Name = "Third-Party Voice Mail Support")]
    ThirdPartyVoiceMailSupport,
    [XmlEnum(Name = "User")]
    User,
    [XmlEnum(Name = "Voice Portal Calling")]
    VoicePortalCalling,
 }
}
