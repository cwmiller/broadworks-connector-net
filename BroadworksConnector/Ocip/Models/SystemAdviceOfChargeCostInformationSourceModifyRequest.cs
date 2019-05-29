using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeCostInformationSourceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "peerIdentity", IsNullable = false)]
    public string PeerIdentity { get; set; }
    [XmlElement(ElementName = "priority", IsNullable = false)]
    public int Priority { get; set; }
 }
}
