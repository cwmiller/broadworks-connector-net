using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum UserType{
    Normal,
    AutoAttendant,
    BroadWorksAnywhere,
    CallCenter,
    CollaborateBridge,
    FindmeFollowme,
    FlexibleSeatingHost,
    GroupPaging,
    HuntGroup,
    InstantGroupCall,
    MeetMeConferencing,
    MusicOnHold,
    RoutePoint,
    VoiceMessaging,
    VoiceXML,
 }
}
