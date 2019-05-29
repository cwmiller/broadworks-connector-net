using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum PhysicalLocationIndicator{
    CI,
    LACCI,
    PANI,
    DisregardZones,
 }
}
