using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ServiceProviderAdminUserAccess{
    Full,
    FullProfile,
    ReadOnlyProfile,
    NoProfile,
    None,
 }
}
