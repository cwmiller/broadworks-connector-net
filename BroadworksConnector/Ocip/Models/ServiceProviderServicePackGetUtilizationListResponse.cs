using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackGetUtilizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public List<string> ServicePackName { get; set; }
    [XmlElement(ElementName = "serviceUtilizationTable", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.C.OCITable> ServiceUtilizationTable { get; set; }
 }
}
