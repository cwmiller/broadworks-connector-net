using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterEnhancedReportingScheduledReportDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _supervisorUserId;

    [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
    public string SupervisorUserId {
        get => _supervisorUserId;
        set {
            SupervisorUserIdSpecified = true;
            _supervisorUserId = value;
        }
    }

    [XmlIgnore]
    public bool SupervisorUserIdSpecified { get; set; }
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
}
}
