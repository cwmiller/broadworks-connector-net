using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DeviceManagementEventLevel{
    Device,
    DeviceType,
    DeviceTypeGroup,
    Group,
    User,
    DeviceTypeServiceProvider,
    ServiceProvider,
 }
}
