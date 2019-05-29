using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum RingPattern{
    Normal,
    LongLong,
    ShortShortLong,
    ShortLongShort,
 }
}
