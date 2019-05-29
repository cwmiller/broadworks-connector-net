using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum TrunkMode{
    Pilot,
    Proxy,
    User,
 }
}
