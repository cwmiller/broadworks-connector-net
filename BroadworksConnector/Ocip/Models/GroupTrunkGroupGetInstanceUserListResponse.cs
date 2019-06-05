using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _trunkGroupUserTable;

    [XmlElement(ElementName = "trunkGroupUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TrunkGroupUserTable {
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
