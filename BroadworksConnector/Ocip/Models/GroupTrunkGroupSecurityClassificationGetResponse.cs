using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupSecurityClassificationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultSecurityClassification;

    [XmlElement(ElementName = "defaultSecurityClassification", IsNullable = false, Namespace = "")]
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