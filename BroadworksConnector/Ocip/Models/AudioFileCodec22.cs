using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum AudioFileCodec22{
    None,
    G711,
    G722,
    G729,
    G726,
    AMR,
    AMRWB,
    OPUS,
    EVRC0,
    EVRCNW,
    EVRCNW0,
 }
}
