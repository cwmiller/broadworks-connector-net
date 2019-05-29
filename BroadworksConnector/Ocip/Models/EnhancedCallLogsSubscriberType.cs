using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EnhancedCallLogsSubscriberType{
    AutoAttendant,
    BroadWorksAnywherePortal,
    CallCenter,
    HuntGroup,
    RoutePoint,
    User,
    FindmeFollowme,
 }
}
