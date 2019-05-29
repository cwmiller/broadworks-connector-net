using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallCenterStrandedCallUnavailableProcessingAction{
    None,
    Busy,
    Transfer,
    NightService,
    Ringing,
    Announcement,
 }
}
