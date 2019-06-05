using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _newDigitPattern;

    [XmlElement(ElementName = "newDigitPattern", IsNullable = false, Namespace = "")]
    public string NewDigitPattern {
        get => _newDigitPattern;
        set {
            NewDigitPatternSpecified = true;
            _newDigitPattern = value;
        }
    }

    [XmlIgnore]
    public bool NewDigitPatternSpecified { get; set; }
    private string _status;

    [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
    public string Status {
        get => _status;
        set {
            StatusSpecified = true;
            _status = value;
        }
    }

    [XmlIgnore]
    public bool StatusSpecified { get; set; }
}
}
