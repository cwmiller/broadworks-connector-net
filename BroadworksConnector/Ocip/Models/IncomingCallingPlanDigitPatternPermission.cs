using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class IncomingCallingPlanDigitPatternPermission 
{
    private string _digitPatternName;

    [XmlElement(ElementName = "digitPatternName", IsNullable = false, Namespace = "")]
    public string DigitPatternName {
        get => _digitPatternName;
        set {
            DigitPatternNameSpecified = true;
            _digitPatternName = value;
        }
    }

    [XmlIgnore]
    public bool DigitPatternNameSpecified { get; set; }
    private bool _allow;

    [XmlElement(ElementName = "allow", IsNullable = false, Namespace = "")]
    public bool Allow {
        get => _allow;
        set {
            AllowSpecified = true;
            _allow = value;
        }
    }

    [XmlIgnore]
    public bool AllowSpecified { get; set; }
}
}
