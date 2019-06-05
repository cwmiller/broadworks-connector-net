using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterReportingServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _reportingServerTable;

    [XmlElement(ElementName = "reportingServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ReportingServerTable {
        get => _reportingServerTable;
        set {
            ReportingServerTableSpecified = true;
            _reportingServerTable = value;
        }
    }

    [XmlIgnore]
    public bool ReportingServerTableSpecified { get; set; }
}
}
