using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceModifyRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "rootDirectory", IsNullable = true)]
    public string RootDirectory { get; set; }
    [XmlElement(ElementName = "secure", IsNullable = false)]
    public bool Secure { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "ftpPassive", IsNullable = false)]
    public bool FtpPassive { get; set; }
    [XmlElement(ElementName = "protocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileRepositoryProtocol22 Protocol { get; set; }
    [XmlElement(ElementName = "port", IsNullable = true)]
    public int? Port { get; set; }
    [XmlElement(ElementName = "ftpRemoteVerification", IsNullable = false)]
    public bool FtpRemoteVerification { get; set; }
 }
}
