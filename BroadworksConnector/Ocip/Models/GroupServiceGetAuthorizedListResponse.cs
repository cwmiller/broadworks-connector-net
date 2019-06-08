using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceGetAuthorizedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private List<BroadWorksConnector.Ocip.Models.GroupService> _groupServiceName;

    [XmlElement(ElementName = "groupServiceName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.GroupService> GroupServiceName {
        get => _groupServiceName;
        set {
            GroupServiceNameSpecified = true;
            _groupServiceName = value;
        }
    }

    [XmlIgnore]
    public bool GroupServiceNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.UserService> _userServiceName;

    [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.UserService> UserServiceName {
        get => _userServiceName;
        set {
            UserServiceNameSpecified = true;
            _userServiceName = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceNameSpecified { get; set; }
}
}
