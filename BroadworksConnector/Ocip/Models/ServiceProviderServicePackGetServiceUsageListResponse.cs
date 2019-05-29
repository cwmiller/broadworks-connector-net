using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackGetServiceUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceUsageTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceUsageTable { get; set; }
 }
}
