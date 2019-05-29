using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemGetResponse23 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mediaDirectory", IsNullable = false)]
    public string MediaDirectory { get; set; }
    [XmlElement(ElementName = "protocolFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolFile ProtocolFile { get; set; }
    [XmlElement(ElementName = "protocolWebDAV", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolWebDAV ProtocolWebDAV { get; set; }
 }
}
