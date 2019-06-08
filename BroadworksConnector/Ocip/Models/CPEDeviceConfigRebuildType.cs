using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CPEDeviceConfigRebuildType{
    [XmlEnum(Name = "Device Type")]
    DeviceType,
    [XmlEnum(Name = "Device Profiles")]
    DeviceProfiles,
 }
}
