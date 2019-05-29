using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "numberPrefixSummaryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable NumberPrefixSummaryTable { get; set; }
 }
}
