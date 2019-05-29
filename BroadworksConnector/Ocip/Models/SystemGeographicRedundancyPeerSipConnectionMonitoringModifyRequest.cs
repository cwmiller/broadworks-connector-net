using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyPeerSipConnectionMonitoringModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enabled", IsNullable = false)]
    public bool Enabled { get; set; }
    [XmlElement(ElementName = "heartbeatInterval", IsNullable = false)]
    public int HeartbeatInterval { get; set; }
    [XmlElement(ElementName = "heartbeatTimeout", IsNullable = false)]
    public int HeartbeatTimeout { get; set; }
 }
}
