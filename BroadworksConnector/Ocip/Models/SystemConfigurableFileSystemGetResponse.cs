using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mediaDirectory", IsNullable = false)]
    public string MediaDirectory { get; set; }
    [XmlElement(ElementName = "protocolFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolFile ProtocolFile { get; set; }
    [XmlElement(ElementName = "protocolWebDAV", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolWebDAV ProtocolWebDAV { get; set; }
 }
}
