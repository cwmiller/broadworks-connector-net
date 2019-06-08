using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterSupervisorReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private string _reportingServerName;

    [XmlElement(ElementName = "reportingServerName", IsNullable = true, Namespace = "")]
    public string ReportingServerName {
        get => _reportingServerName;
        set {
            ReportingServerNameSpecified = true;
            _reportingServerName = value;
        }
    }

    [XmlIgnore]
    public bool ReportingServerNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _supervisorUserIdList;

    [XmlElement(ElementName = "supervisorUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SupervisorUserIdList {
        get => _supervisorUserIdList;
        set {
            SupervisorUserIdListSpecified = true;
            _supervisorUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool SupervisorUserIdListSpecified { get; set; }
}
}
