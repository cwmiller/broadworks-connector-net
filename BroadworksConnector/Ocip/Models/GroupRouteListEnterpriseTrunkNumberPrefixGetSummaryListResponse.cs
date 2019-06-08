using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _numberPrefixSummaryTable;

    [XmlElement(ElementName = "numberPrefixSummaryTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable NumberPrefixSummaryTable {
        get => _numberPrefixSummaryTable;
        set {
            NumberPrefixSummaryTableSpecified = true;
            _numberPrefixSummaryTable = value;
        }
    }

    [XmlIgnore]
    public bool NumberPrefixSummaryTableSpecified { get; set; }
}
}
