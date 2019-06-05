using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAuthenticationTrunkGroupLockoutClearRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.TrunkGroupKey> _trunkGroupkey;

    [XmlElement(ElementName = "trunkGroupkey", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.TrunkGroupKey> TrunkGroupkey {
        get => _trunkGroupkey;
        set {
            TrunkGroupkeySpecified = true;
            _trunkGroupkey = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupkeySpecified { get; set; }
}
}
