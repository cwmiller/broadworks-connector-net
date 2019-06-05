using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemServiceDnGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _dnSummaryTable;

    [XmlElement(ElementName = "dnSummaryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DnSummaryTable {
        get => _dnSummaryTable;
        set {
            DnSummaryTableSpecified = true;
            _dnSummaryTable = value;
        }
    }

    [XmlIgnore]
    public bool DnSummaryTableSpecified { get; set; }
}
}
