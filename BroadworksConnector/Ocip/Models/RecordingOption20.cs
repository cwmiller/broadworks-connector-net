using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum RecordingOption20{
    Always,
    Never,
    OnDemand,
    AlwayswithPauseResume,
    OnDemandwithUserInitiatedStart,
 }
}
