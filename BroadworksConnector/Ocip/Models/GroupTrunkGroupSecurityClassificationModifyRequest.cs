using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupSecurityClassificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

    [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey {
        get => _trunkGroupKey;
        set {
            TrunkGroupKeySpecified = true;
            _trunkGroupKey = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupKeySpecified { get; set; }
    private string _defaultSecurityClassification;

    [XmlElement(ElementName = "defaultSecurityClassification", IsNullable = true, Namespace = "")]
    public string DefaultSecurityClassification {
        get => _defaultSecurityClassification;
        set {
            DefaultSecurityClassificationSpecified = true;
            _defaultSecurityClassification = value;
        }
    }

    [XmlIgnore]
    public bool DefaultSecurityClassificationSpecified { get; set; }
}
}
