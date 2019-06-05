using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMigratedUsersGetListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public List<string> UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private int _totalNumberOfMigratedUsers;

    [XmlElement(ElementName = "totalNumberOfMigratedUsers", IsNullable = false, Namespace = "")]
    public int TotalNumberOfMigratedUsers {
        get => _totalNumberOfMigratedUsers;
        set {
            TotalNumberOfMigratedUsersSpecified = true;
            _totalNumberOfMigratedUsers = value;
        }
    }

    [XmlIgnore]
    public bool TotalNumberOfMigratedUsersSpecified { get; set; }
}
}
