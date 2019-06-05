using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSecurityClassificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _securityClassification;

    [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
    public string SecurityClassification {
        get => _securityClassification;
        set {
            SecurityClassificationSpecified = true;
            _securityClassification = value;
        }
    }

    [XmlIgnore]
    public bool SecurityClassificationSpecified { get; set; }
}
}
