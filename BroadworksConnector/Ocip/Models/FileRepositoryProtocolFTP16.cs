using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class FileRepositoryProtocolFTP16 
{
    [XmlElement(ElementName = "ftpPassive", IsNullable = false)]
    public bool FtpPassive { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "ftpRemoteVerification", IsNullable = false)]
    public bool FtpRemoteVerification { get; set; }
 }
}
