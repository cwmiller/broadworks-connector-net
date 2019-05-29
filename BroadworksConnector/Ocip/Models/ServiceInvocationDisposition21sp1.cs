using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ServiceInvocationDisposition21sp1{
    AutomaticHoldRetrieve,
    CallForwardAlways,
    CallForwardAlwaysSecondary,
    CallForwardBusy,
    CallForwardNoAnswer,
    CallForwardNotReachable,
    CallForwardSelective,
    CallPark,
    CallPickup,
    Deflection,
    DirectedCallPickup,
    DistributionfromCallCenter,
    DistributionfromHuntGroup,
    DistributionfromRoutePoint,
    DoNotDisturb,
    FaxDeposit,
    GroupNightForwarding,
    SequentialRing,
    SeriesCompletion,
    SimultaneousRing,
    ThirdPartyDeflection,
    ThirdPartyVoiceMailSupport,
    TransferConsult,
    TrunkGroupForwardCapacityExceeded,
    TrunkGroupForwardUnreachable,
    TrunkGroupForwardUnconditional,
    VoiceMailTransfer,
    VoiceMessaging,
    FindmeFollowme,
    PersonalAssistant,
 }
}
