using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DeviceAccessProtocol16{
    Http,
    Https,
    FTP,
    FTPS,
    SFTP,
    TFTP,
 }
}
