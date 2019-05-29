using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum MediaBandwidthEnforcementType{
    AllowAll,
    AllowUnspecified,
    EnforceAll,
 }
}
