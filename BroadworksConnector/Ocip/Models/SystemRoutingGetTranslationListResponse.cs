using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingGetTranslationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "routingTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RoutingTable { get; set; }
 }
}
