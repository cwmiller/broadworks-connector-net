using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterSupervisorReportingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _reportingServerName;

    [XmlElement(ElementName = "reportingServerName", IsNullable = false, Namespace = "")]
    public string ReportingServerName {
        get => _reportingServerName;
        set {
            ReportingServerNameSpecified = true;
            _reportingServerName = value;
        }
    }

    [XmlIgnore]
    public bool ReportingServerNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _supervisorTable;

    [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SupervisorTable {
        get => _supervisorTable;
        set {
            SupervisorTableSpecified = true;
            _supervisorTable = value;
        }
    }

    [XmlIgnore]
    public bool SupervisorTableSpecified { get; set; }
}
}
