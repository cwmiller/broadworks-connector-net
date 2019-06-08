using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingTargetsCapacityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _maximumTargetUsersFromServiceProvider;

    [XmlElement(ElementName = "maximumTargetUsersFromServiceProvider", IsNullable = false, Namespace = "")]
    public int MaximumTargetUsersFromServiceProvider {
        get => _maximumTargetUsersFromServiceProvider;
        set {
            MaximumTargetUsersFromServiceProviderSpecified = true;
            _maximumTargetUsersFromServiceProvider = value;
        }
    }

    [XmlIgnore]
    public bool MaximumTargetUsersFromServiceProviderSpecified { get; set; }
    private int _maximumTargetUsers;

    [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false, Namespace = "")]
    public int MaximumTargetUsers {
        get => _maximumTargetUsers;
        set {
            MaximumTargetUsersSpecified = true;
            _maximumTargetUsers = value;
        }
    }

    [XmlIgnore]
    public bool MaximumTargetUsersSpecified { get; set; }
}
}
