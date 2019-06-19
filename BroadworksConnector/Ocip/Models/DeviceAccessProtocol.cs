using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Protocols that an access device can use to fetch files from BroadWorks.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceAccessProtocol
    {
        [XmlEnum(Name = "Http")]
        Http,
        [XmlEnum(Name = "Https")]
        Https,
        [XmlEnum(Name = "FTP")]
        FTP,
    }
}
