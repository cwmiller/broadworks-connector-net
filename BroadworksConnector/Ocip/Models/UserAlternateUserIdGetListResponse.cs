using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateUserIdGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _userIdTable;

    [XmlElement(ElementName = "userIdTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserIdTable {
        get => _userIdTable;
        set {
            UserIdTableSpecified = true;
            _userIdTable = value;
        }
    }

    [XmlIgnore]
    public bool UserIdTableSpecified { get; set; }
}
}
