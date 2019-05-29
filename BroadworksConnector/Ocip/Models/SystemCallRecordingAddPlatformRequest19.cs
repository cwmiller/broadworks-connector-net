using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallRecordingAddPlatformRequest19 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "mediaStream", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaStream MediaStream { get; set; }
    [XmlElement(ElementName = "transportType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportType { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "schemaVersion", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion SchemaVersion { get; set; }
 }
}
