using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceUserListResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupUserTable;

    [XmlElement(ElementName = "trunkGroupUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TrunkGroupUserTable {
        get => _trunkGroupUserTable;
        set {
            TrunkGroupUserTableSpecified = true;
            _trunkGroupUserTable = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupUserTableSpecified { get; set; }
}
}
