using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// List of supported Service Categories that have configurable default attributes entries.
    /// The following elements are ignored in AS data mode:
    /// Basic Call Logs
    /// OMA Presence
    /// Push to Talk
    /// The following elements are ignored in XS data mode:
    /// ChargeNumber
    /// Integrated IMP
    /// Voice Portal Calling
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceCategory
    {
        [XmlEnum(Name = "Basic Call Logs")]
        BasicCallLogs,
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
        [XmlEnum(Name = "Push to Talk")]
        PushtoTalk,
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
