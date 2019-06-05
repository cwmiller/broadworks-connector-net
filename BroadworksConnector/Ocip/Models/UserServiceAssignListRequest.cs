using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserServiceAssignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.UserService> _serviceName;

    [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.UserService> ServiceName {
        get => _serviceName;
        set {
            ServiceNameSpecified = true;
            _serviceName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceNameSpecified { get; set; }
    private List<string> _servicePackName;

    [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
    public List<string> ServicePackName {
        get => _servicePackName;
        set {
            ServicePackNameSpecified = true;
            _servicePackName = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackNameSpecified { get; set; }
}
}
