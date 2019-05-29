using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum AudioFileCodecExtended{
    None,
    G711,
    G722,
    G729,
    G726,
    AMR,
    AMRWB,
    EVRC0,
    EVRCNW,
    EVRCNW0,
 }
}
