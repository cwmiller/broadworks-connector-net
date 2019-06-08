using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskModifyGroupListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _migrateAllGroups;

    [XmlElement(ElementName = "migrateAllGroups", IsNullable = false, Namespace = "")]
    public bool MigrateAllGroups {
        get => _migrateAllGroups;
        set {
            MigrateAllGroupsSpecified = true;
            _migrateAllGroups = value;
        }
    }

    [XmlIgnore]
    public bool MigrateAllGroupsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList _groupIdList;

    [XmlElement(ElementName = "groupIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList GroupIdList {
        get => _groupIdList;
        set {
            GroupIdListSpecified = true;
            _groupIdList = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdListSpecified { get; set; }
}
}
