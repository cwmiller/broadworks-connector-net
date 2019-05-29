using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum TrunkGroupUserLookupPolicy{
    Basic,
    Extended,
    BasicLookupPreferFrom,
 }
}
