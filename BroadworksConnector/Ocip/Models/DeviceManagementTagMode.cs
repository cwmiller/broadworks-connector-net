using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DeviceManagementTagMode{
    None,
    System,
    SystemAndCustom,
 }
}
