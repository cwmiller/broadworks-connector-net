using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the type of rebuild requested.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CPEDeviceConfigRebuildType    {
            [XmlEnum(Name = "Device Type")]
        DeviceType,
            [XmlEnum(Name = "Device Profiles")]
        DeviceProfiles,
     }
}
