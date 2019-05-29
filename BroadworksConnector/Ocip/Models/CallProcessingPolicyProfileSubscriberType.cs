using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallProcessingPolicyProfileSubscriberType{
    User,
    TrunkGroupPilotUser,
    AutoAttendant,
    BroadWorksAnywhere,
    CallCenter,
    FindmeFollowme,
    GroupPaging,
    HuntGroup,
    InstantGroupCall,
    MeetMeConferencing,
    RoutePoint,
    VoicePortal,
    VoiceXML,
 }
}
