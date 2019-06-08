using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceListRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private string _groupDepartmentName;

    [XmlElement(ElementName = "groupDepartmentName", IsNullable = false, Namespace = "")]
    public string GroupDepartmentName {
        get => _groupDepartmentName;
        set {
            GroupDepartmentNameSpecified = true;
            _groupDepartmentName = value;
        }
    }

    [XmlIgnore]
    public bool GroupDepartmentNameSpecified { get; set; }
    private bool _includeEnterpriseTrunkGroups;

    [XmlElement(ElementName = "includeEnterpriseTrunkGroups", IsNullable = false, Namespace = "")]
    public bool IncludeEnterpriseTrunkGroups {
        get => _includeEnterpriseTrunkGroups;
        set {
            IncludeEnterpriseTrunkGroupsSpecified = true;
            _includeEnterpriseTrunkGroups = value;
        }
    }

    [XmlIgnore]
    public bool IncludeEnterpriseTrunkGroupsSpecified { get; set; }
    private bool _onlyTrunkGroupsWithDevice;

    [XmlElement(ElementName = "onlyTrunkGroupsWithDevice", IsNullable = false, Namespace = "")]
    public bool OnlyTrunkGroupsWithDevice {
        get => _onlyTrunkGroupsWithDevice;
        set {
            OnlyTrunkGroupsWithDeviceSpecified = true;
            _onlyTrunkGroupsWithDevice = value;
        }
    }

    [XmlIgnore]
    public bool OnlyTrunkGroupsWithDeviceSpecified { get; set; }
}
}
