using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DeviceAccessProtocol16{
    [XmlEnum(Name = "Http")]
    Http,
    [XmlEnum(Name = "Https")]
    Https,
    [XmlEnum(Name = "FTP")]
    FTP,
    [XmlEnum(Name = "FTPS")]
    FTPS,
    [XmlEnum(Name = "SFTP")]
    SFTP,
    [XmlEnum(Name = "TFTP")]
    TFTP,
 }
}
