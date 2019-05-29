using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum HoldNormalizationMode{
    UnspecifiedAddress,
    Inactive,
    Rfc3264,
 }
}
