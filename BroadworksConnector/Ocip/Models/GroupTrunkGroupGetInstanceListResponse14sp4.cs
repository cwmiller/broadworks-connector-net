using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceListResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _trunkGroupTable;

    [XmlElement(ElementName = "trunkGroupTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TrunkGroupTable {
        get => _trunkGroupTable;
        set {
            TrunkGroupTableSpecified = true;
            _trunkGroupTable = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupTableSpecified { get; set; }
}
}
