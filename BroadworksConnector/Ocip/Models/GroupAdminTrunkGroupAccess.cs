using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum GroupAdminTrunkGroupAccess{
    Full,
    FullResources,
    ReadOnlyResources,
    None,
 }
}
