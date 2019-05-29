using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum SIPDiversionReason{
    Unknown,
    Userbusy,
    Noanswer,
    Unavailable,
    Unconditional,
    Deflection,
    Timeofday,
    Donotdisturb,
    Followme,
    Outofservice,
    Away,
    Transfer,
    Voicemail,
    Huntgroup,
    Callcenter,
    Routepoint,
    BWImplicitID,
    BWExplicitID,
 }
}
