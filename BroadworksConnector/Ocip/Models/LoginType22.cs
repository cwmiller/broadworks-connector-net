using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum LoginType22{
    System,
    Provisioning,
    Reseller,
    ServiceProvider,
    Group,
    GroupDepartment,
    User,
    LawfulIntercept,
 }
}
