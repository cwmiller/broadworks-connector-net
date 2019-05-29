using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkSynchingServerModifyRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "becomePreferred", IsNullable = false)]
    public bool BecomePreferred { get; set; }
    [XmlElement(ElementName = "order", IsNullable = false)]
    public int Order { get; set; }
    [XmlElement(ElementName = "secure", IsNullable = false)]
    public bool Secure { get; set; }
 }
}
