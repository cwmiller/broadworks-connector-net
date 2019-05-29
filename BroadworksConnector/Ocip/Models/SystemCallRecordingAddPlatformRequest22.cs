using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallRecordingAddPlatformRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    public BroadworksConnector.Ocip.Models.ExtendedTransportProtocol TransportType { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "schemaVersion", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion SchemaVersion { get; set; }
    [XmlElement(ElementName = "supportVideoRecording", IsNullable = false)]
    public bool SupportVideoRecording { get; set; }
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "route", IsNullable = false)]
    public string Route { get; set; }
 }
}
