using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAuthenticationTrunkGroupLockoutClearRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.TrunkGroupKey> _trunkGroupkey;

    [XmlElement(ElementName = "trunkGroupkey", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.TrunkGroupKey> TrunkGroupkey {
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
