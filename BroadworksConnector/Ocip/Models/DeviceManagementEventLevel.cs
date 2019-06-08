using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DeviceManagementEventLevel{
    [XmlEnum(Name = "Device")]
    Device,
    [XmlEnum(Name = "Device Type")]
    DeviceType,
    [XmlEnum(Name = "Device Type Group")]
    DeviceTypeGroup,
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "User")]
    User,
    [XmlEnum(Name = "Device Type Service Provider")]
    DeviceTypeServiceProvider,
    [XmlEnum(Name = "Service Provider")]
    ServiceProvider,
 }
}
