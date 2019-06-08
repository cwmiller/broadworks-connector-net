using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _userIdTable;

    [XmlElement(ElementName = "userIdTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserIdTable {
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
