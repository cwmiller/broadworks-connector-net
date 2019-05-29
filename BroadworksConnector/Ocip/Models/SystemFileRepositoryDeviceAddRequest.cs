using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "rootDirectory", IsNullable = false)]
    public string RootDirectory { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "protocolWebDAV", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileRepositoryProtocolWebDAV ProtocolWebDAV { get; set; }
    [XmlElement(ElementName = "protocolFTP", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileRepositoryProtocolFTP ProtocolFTP { get; set; }
 }
}
