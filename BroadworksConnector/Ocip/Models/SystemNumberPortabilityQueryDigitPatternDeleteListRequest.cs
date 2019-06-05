using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<string> _digitPattern;

    [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
    public List<string> DigitPattern {
        get => _digitPattern;
        set {
            DigitPatternSpecified = true;
            _digitPattern = value;
        }
    }

    [XmlIgnore]
    public bool DigitPatternSpecified { get; set; }
}
}
