using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum GroupAdminUserAccess{
    Full,
    FullProfile,
    ReadOnlyProfile,
    NoProfile,
    None,
 }
}
