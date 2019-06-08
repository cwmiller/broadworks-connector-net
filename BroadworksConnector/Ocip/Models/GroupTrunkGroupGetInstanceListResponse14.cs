using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _trunkGroupTable;

    [XmlElement(ElementName = "trunkGroupTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TrunkGroupTable {
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
