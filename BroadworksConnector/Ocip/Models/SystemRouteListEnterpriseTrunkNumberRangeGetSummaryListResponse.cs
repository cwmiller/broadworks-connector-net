using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "numberRangeSummaryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable NumberRangeSummaryTable { get; set; }
 }
}
