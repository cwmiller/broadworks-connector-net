using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberActivationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _useNumberActivation;

    [XmlElement(ElementName = "useNumberActivation", IsNullable = false, Namespace = "")]
    public bool UseNumberActivation {
        get => _useNumberActivation;
        set {
            UseNumberActivationSpecified = true;
            _useNumberActivation = value;
        }
    }

    [XmlIgnore]
    public bool UseNumberActivationSpecified { get; set; }
}
}
