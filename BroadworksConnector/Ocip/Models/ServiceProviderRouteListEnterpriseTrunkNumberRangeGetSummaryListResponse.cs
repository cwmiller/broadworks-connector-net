using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _numberRangeSummaryTable;

    [XmlElement(ElementName = "numberRangeSummaryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable NumberRangeSummaryTable {
        get => _numberRangeSummaryTable;
        set {
            NumberRangeSummaryTableSpecified = true;
            _numberRangeSummaryTable = value;
        }
    }

    [XmlIgnore]
    public bool NumberRangeSummaryTableSpecified { get; set; }
}
}
