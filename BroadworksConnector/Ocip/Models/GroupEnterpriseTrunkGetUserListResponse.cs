using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseTrunkUserTable;

    [XmlElement(ElementName = "enterpriseTrunkUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable EnterpriseTrunkUserTable {
        get => _enterpriseTrunkUserTable;
        set {
            EnterpriseTrunkUserTableSpecified = true;
            _enterpriseTrunkUserTable = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseTrunkUserTableSpecified { get; set; }
}
}
