using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum GroupService{
    AccountAuthorizationCodes,
    AutoAttendant,
    AutoAttendantVideo,
    AutoAttendantStandard,
    CallCapacityManagement,
    CallPark,
    CallPickup,
    CityWideCentrex,
    CustomRingbackGroup,
    CustomRingbackGroupVideo,
    EmergencyZones,
    EnhancedOutgoingCallingPlan,
    FindmeFollowme,
    GroupPaging,
    HuntGroup,
    IncomingCallingPlan,
    InstantGroupCall,
    InterceptGroup,
    InventoryReport,
    LDAPIntegration,
    MeetMeConferencing,
    MusicOnHold,
    MusicOnHoldVideo,
    OutgoingCallingPlan,
    PreferredCarrierGroup,
    RoutePoint,
    SeriesCompletion,
    ServiceScriptsGroup,
    TrunkGroup,
    VoiceMessagingGroup,
    VoiceXML,
 }
}
