using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetDNISAgentListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "dnisKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DNISKey DnisKey { get; set; }
 }
}
