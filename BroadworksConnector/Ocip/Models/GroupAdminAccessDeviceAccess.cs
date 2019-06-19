using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to access devices.
    /// "Full" indicates full access to access devices.
    /// "Associate User With Device" indicates
    /// 1) read-only access to devices, but
    /// 2) the group administrator may associate users with devices
    /// "Read-Only" indicates read-only access to devices and user-device associations
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminAccessDeviceAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Associate User With Device")]
        AssociateUserWithDevice,
        [XmlEnum(Name = "Read-Only")]
        ReadOnly,
    }
}
