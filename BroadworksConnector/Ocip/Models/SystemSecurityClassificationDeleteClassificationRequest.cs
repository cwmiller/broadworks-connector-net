using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationDeleteClassificationRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _securityClassificationName;

    [XmlElement(ElementName = "securityClassificationName", IsNullable = false, Namespace = "")]
    public string SecurityClassificationName {
        get => _securityClassificationName;
        set {
            SecurityClassificationNameSpecified = true;
            _securityClassificationName = value;
        }
    }

    [XmlIgnore]
    public bool SecurityClassificationNameSpecified { get; set; }
}
}
