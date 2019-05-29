using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DeviceTypeConfigurationOptionType{
    NotSupported,
    DeviceManagement,
    Legacy,
 }
}
