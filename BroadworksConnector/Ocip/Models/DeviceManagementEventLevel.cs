using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The level of a device management event.
    /// It can affect one device, all devices linked to a user, all devices
    /// linked to a group, all devices
    /// linked to a service provider, all devices linked to a device type, all devices
    /// linked to a device type and group or all devices
    /// linked to a device type and service provider.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementEventLevel
    {
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
