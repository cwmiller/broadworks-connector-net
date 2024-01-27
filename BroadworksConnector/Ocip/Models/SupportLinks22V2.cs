using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Define the support links values.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SupportLinks22V2
    {
        [XmlEnum(Name = "Not Supported")]
        NotSupported,
        [XmlEnum(Name = "Support Links from Devices")]
        SupportLinksfromDevices,
        [XmlEnum(Name = "Support Link to Device")]
        SupportLinktoDevice,
        [XmlEnum(Name = "Support Link to Device and User")]
        SupportLinktoDeviceandUser,
    }
}
