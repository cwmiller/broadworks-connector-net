using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum GroupDepartmentAdminUserAccess{
    Full,
    ReadOnlyProfile,
    NoProfile,
    None,
 }
}
