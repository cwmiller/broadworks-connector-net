using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _numberRangeSummaryTable;

    [XmlElement(ElementName = "numberRangeSummaryTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable NumberRangeSummaryTable {
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
