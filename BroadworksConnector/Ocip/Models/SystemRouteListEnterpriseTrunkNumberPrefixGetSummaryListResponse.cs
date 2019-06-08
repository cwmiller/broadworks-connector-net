using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _prefixSummaryTable;

    [XmlElement(ElementName = "prefixSummaryTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable PrefixSummaryTable {
        get => _prefixSummaryTable;
        set {
            PrefixSummaryTableSpecified = true;
            _prefixSummaryTable = value;
        }
    }

    [XmlIgnore]
    public bool PrefixSummaryTableSpecified { get; set; }
}
}
