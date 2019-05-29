using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutePointExternalSystemGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "externalSystemTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ExternalSystemTable { get; set; }
 }
}
