using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGroupPagingTargetsCapacityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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