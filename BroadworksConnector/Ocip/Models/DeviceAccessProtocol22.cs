using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DeviceAccessProtocol22{
    Http,
    Https,
    FTP,
    FTPS,
    SFTP,
    TFTP,
 }
}
