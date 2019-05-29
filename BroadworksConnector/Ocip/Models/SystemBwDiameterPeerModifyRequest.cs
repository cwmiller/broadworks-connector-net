using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterPeerModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "instance", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterPeerInstance Instance { get; set; }
    [XmlElement(ElementName = "identity", IsNullable = false)]
    public string Identity { get; set; }
    [XmlElement(ElementName = "ipAddress", IsNullable = true)]
    public string IpAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "enabled", IsNullable = false)]
    public bool Enabled { get; set; }
    [XmlElement(ElementName = "secure", IsNullable = false)]
    public bool Secure { get; set; }
 }
}
