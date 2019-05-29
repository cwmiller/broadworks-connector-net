using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceCategory ServiceName { get; set; }
    [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ServiceAttributeEntry> ServiceAttributeEntry { get; set; }
 }
}
