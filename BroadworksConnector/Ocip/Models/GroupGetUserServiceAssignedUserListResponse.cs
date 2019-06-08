using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetUserServiceAssignedUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _userListTable;

    [XmlElement(ElementName = "userListTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserListTable {
        get => _userListTable;
        set {
            UserListTableSpecified = true;
            _userListTable = value;
        }
    }

    [XmlIgnore]
    public bool UserListTableSpecified { get; set; }
}
}
