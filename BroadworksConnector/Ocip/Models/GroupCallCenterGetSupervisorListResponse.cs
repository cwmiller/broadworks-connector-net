using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetSupervisorListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _reportingServerURL;

    [XmlElement(ElementName = "reportingServerURL", IsNullable = false, Namespace = "")]
    public string ReportingServerURL {
        get => _reportingServerURL;
        set {
            ReportingServerURLSpecified = true;
            _reportingServerURL = value;
        }
    }

    [XmlIgnore]
    public bool ReportingServerURLSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _supervisorTable;

    [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SupervisorTable {
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
