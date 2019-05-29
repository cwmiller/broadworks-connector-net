using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "prefixSummaryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PrefixSummaryTable { get; set; }
 }
}
