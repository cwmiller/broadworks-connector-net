using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum GroupPasscodeRulesLevel{
    System,
    ServiceProvider,
    Group,
 }
}
