using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCLIDDeliveryPrefixDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "prefix", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CLIDDeliveryPrefix> Prefix { get; set; }
 }
}
