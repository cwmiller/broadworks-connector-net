using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEndpointGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "endpointTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable EndpointTable { get; set; }
 }
}
