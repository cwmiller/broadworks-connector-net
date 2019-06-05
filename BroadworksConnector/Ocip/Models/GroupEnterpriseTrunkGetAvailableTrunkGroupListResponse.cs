using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _trunkGroupName;

    [XmlElement(ElementName = "trunkGroupName", IsNullable = false, Namespace = "")]
    public List<string> TrunkGroupName {
        get => _trunkGroupName;
        set {
            TrunkGroupNameSpecified = true;
            _trunkGroupName = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupNameSpecified { get; set; }
}
}
