using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ServiceCategory{
    CallTransfer,
    CallWaiting,
    CallingNameRetrieval,
    ChargeNumber,
    ExternalCallingLineIDDelivery,
    GroupNightForwarding,
    IntegratedIMP,
    InterceptGroup,
    InternalCallingLineIDDelivery,
    MusicOnHold,
    OMAPresence,
    Prepaid,
    SharedCallAppearance,
    ThirdPartyVoiceMailSupport,
    User,
    VoicePortalCalling,
 }
}
