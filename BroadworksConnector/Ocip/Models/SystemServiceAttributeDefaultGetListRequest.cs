using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceCategory ServiceName { get; set; }
 }
}
