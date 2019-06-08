using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _statusCode;

    [XmlElement(ElementName = "statusCode", IsNullable = false, Namespace = "")]
    public List<string> StatusCode {
        get => _statusCode;
        set {
            StatusCodeSpecified = true;
            _statusCode = value;
        }
    }

    [XmlIgnore]
    public bool StatusCodeSpecified { get; set; }
}
}
