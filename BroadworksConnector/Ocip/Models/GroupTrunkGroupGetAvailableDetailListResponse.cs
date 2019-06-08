using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetAvailableDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup> _trunkGroup;

    [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.GroupTrunkGroupGetAvailableDetailListResponseTrunkGroup> TrunkGroup {
        get => _trunkGroup;
        set {
            TrunkGroupSpecified = true;
            _trunkGroup = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupSpecified { get; set; }
}
}
