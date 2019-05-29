using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterPeerDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "instance", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterPeerInstance Instance { get; set; }
    [XmlElement(ElementName = "identity", IsNullable = false)]
    public string Identity { get; set; }
 }
}
