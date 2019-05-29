using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mediaDirectory", IsNullable = false)]
    public string MediaDirectory { get; set; }
    [XmlElement(ElementName = "protocolFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolFile ProtocolFile { get; set; }
    [XmlElement(ElementName = "protocolWebDAV", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolWebDAV ProtocolWebDAV { get; set; }
 }
}
