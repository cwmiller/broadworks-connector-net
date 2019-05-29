using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum LoginType{
    System,
    Provisioning,
    ServiceProvider,
    Group,
    GroupDepartment,
    User,
    LawfulIntercept,
 }
}
