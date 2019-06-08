using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _digitPattern;

    [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
    public string DigitPattern {
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
