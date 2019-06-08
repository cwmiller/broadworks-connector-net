using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserINIntegrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _originatingServiceKey;

    [XmlElement(ElementName = "originatingServiceKey", IsNullable = false, Namespace = "")]
    public int OriginatingServiceKey {
        get => _originatingServiceKey;
        set {
            OriginatingServiceKeySpecified = true;
            _originatingServiceKey = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingServiceKeySpecified { get; set; }
    private int _terminatingServiceKey;

    [XmlElement(ElementName = "terminatingServiceKey", IsNullable = false, Namespace = "")]
    public int TerminatingServiceKey {
        get => _terminatingServiceKey;
        set {
            TerminatingServiceKeySpecified = true;
            _terminatingServiceKey = value;
        }
    }

    [XmlIgnore]
    public bool TerminatingServiceKeySpecified { get; set; }
}
}
