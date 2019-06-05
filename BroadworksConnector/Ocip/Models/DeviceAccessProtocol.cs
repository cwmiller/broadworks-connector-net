using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
