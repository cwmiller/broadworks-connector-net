using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ServiceType{
    AutoAttendant,
    AutoAttendantStandard,
    BroadWorksAnywherePortal,
    CallCenter,
    CollaborateBridge,
    FindmeFollowme,
    FlexibleSeatingHost,
    GroupPaging,
    HuntGroup,
    InstantGroupCall,
    InstantConferenceBridge,
    MeetMeConferenceBridge,
    RoutePoint,
    VoiceXML,
 }
}
