using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterReportingServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _reportingServerTable;

    [XmlElement(ElementName = "reportingServerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ReportingServerTable {
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
