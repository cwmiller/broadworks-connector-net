using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _unreachableFromPrimaryUserTable;

    [XmlElement(ElementName = "unreachableFromPrimaryUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UnreachableFromPrimaryUserTable {
        get => _unreachableFromPrimaryUserTable;
        set {
            UnreachableFromPrimaryUserTableSpecified = true;
            _unreachableFromPrimaryUserTable = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableFromPrimaryUserTableSpecified { get; set; }
    private int _totalNumberOfUnreachableFromPrimaryUsers;

    [XmlElement(ElementName = "totalNumberOfUnreachableFromPrimaryUsers", IsNullable = false, Namespace = "")]
    public int TotalNumberOfUnreachableFromPrimaryUsers {
        get => _totalNumberOfUnreachableFromPrimaryUsers;
        set {
            TotalNumberOfUnreachableFromPrimaryUsersSpecified = true;
            _totalNumberOfUnreachableFromPrimaryUsers = value;
        }
    }

    [XmlIgnore]
    public bool TotalNumberOfUnreachableFromPrimaryUsersSpecified { get; set; }
}
}
