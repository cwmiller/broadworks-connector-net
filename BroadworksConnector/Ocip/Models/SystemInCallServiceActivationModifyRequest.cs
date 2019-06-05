using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInCallServiceActivationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _defaultActivationDigits;

    [XmlElement(ElementName = "defaultActivationDigits", IsNullable = false, Namespace = "")]
    public string DefaultActivationDigits {
        get => _defaultActivationDigits;
        set {
            DefaultActivationDigitsSpecified = true;
            _defaultActivationDigits = value;
        }
    }

    [XmlIgnore]
    public bool DefaultActivationDigitsSpecified { get; set; }
}
}
