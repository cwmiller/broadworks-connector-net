using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallProcessingPolicyProfileSubscriberType20{
    User,
    TrunkGroupPilotUser,
    AutoAttendant,
    BroadWorksAnywhere,
    CallCenter,
    FindmeFollowme,
    GroupPaging,
    FlexibleSeatingHost,
    HuntGroup,
    InstantGroupCall,
    MeetMeConferencing,
    RoutePoint,
    VoicePortal,
    VoiceXML,
 }
}
