using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallCenterStrandedCallProcessingAction{
    None,
    Busy,
    Transfer,
    NightService,
    Ringing,
    Announcement,
 }
}
