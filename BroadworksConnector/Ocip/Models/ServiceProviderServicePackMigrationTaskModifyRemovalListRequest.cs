using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskModifyRemovalListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _taskName;

    [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
    public string TaskName {
        get => _taskName;
        set {
            TaskNameSpecified = true;
            _taskName = value;
        }
    }

    [XmlIgnore]
    public bool TaskNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementUserServiceList _userServiceNameList;

    [XmlElement(ElementName = "userServiceNameList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserServiceList UserServiceNameList {
        get => _userServiceNameList;
        set {
            UserServiceNameListSpecified = true;
            _userServiceNameList = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceNameListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementServicePackNameList _servicePackNameList;

    [XmlElement(ElementName = "servicePackNameList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementServicePackNameList ServicePackNameList {
        get => _servicePackNameList;
        set {
            ServicePackNameListSpecified = true;
            _servicePackNameList = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackNameListSpecified { get; set; }
}
}
