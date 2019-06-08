using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemServiceDnGetSummaryListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _dnSummaryTable;

    [XmlElement(ElementName = "dnSummaryTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DnSummaryTable {
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
