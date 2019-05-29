using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum FileRepositoryProtocol22{
    WebDAV,
    FTP,
    FTPS,
    SFTP,
 }
}
