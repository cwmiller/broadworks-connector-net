using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterPeerAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "instance", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterPeerInstance Instance { get; set; }
    [XmlElement(ElementName = "identity", IsNullable = false)]
    public string Identity { get; set; }
    [XmlElement(ElementName = "ipAddress", IsNullable = false)]
    public string IpAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "enabled", IsNullable = false)]
    public bool Enabled { get; set; }
 }
}
