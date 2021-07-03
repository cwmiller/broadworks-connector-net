using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Define the support links values.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SupportLinks
    {
        [XmlEnum(Name = "Not Supported")]
        NotSupported,
        [XmlEnum(Name = "Support Links from Devices")]
        SupportLinksfromDevices,
        [XmlEnum(Name = "Support Link to Device")]
        SupportLinktoDevice,
    }
}
