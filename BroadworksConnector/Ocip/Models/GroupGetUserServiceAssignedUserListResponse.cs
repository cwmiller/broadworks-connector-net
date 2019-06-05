using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetUserServiceAssignedUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _userListTable;

    [XmlElement(ElementName = "userListTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserListTable {
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
