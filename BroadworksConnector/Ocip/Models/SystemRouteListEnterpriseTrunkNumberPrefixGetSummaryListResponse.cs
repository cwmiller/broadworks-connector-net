using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _prefixSummaryTable;

    [XmlElement(ElementName = "prefixSummaryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PrefixSummaryTable {
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
