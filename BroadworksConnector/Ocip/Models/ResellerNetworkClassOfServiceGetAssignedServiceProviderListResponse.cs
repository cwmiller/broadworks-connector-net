using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "spTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SpTable { get; set; }
 }
}
