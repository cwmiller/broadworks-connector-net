using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum FileRepositoryProtocol
    {
        [XmlEnum(Name = "WebDAV")]
        WebDAV,
        [XmlEnum(Name = "FTP")]
        FTP,
    }
}
