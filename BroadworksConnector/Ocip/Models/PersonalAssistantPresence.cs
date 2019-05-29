using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum PersonalAssistantPresence{
    None,
    BusinessTrip,
    GonefortheDay,
    Lunch,
    Meeting,
    OutOfOffice,
    TemporarilyOut,
    Training,
    Unavailable,
    Vacation,
 }
}
