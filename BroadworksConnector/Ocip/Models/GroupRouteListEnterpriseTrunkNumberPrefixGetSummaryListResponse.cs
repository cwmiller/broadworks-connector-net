using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _numberPrefixSummaryTable;

    [XmlElement(ElementName = "numberPrefixSummaryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable NumberPrefixSummaryTable {
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
