using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class Q850CauseMapEntry 
{
    private int _q850CauseValue;

    [XmlElement(ElementName = "q850CauseValue", IsNullable = false, Namespace = "")]
    public int Q850CauseValue {
        get => _q850CauseValue;
        set {
            Q850CauseValueSpecified = true;
            _q850CauseValue = value;
        }
    }

    [XmlIgnore]
    public bool Q850CauseValueSpecified { get; set; }
    private string _treatmentId;

    [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
    public string TreatmentId {
        get => _treatmentId;
        set {
            TreatmentIdSpecified = true;
            _treatmentId = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentIdSpecified { get; set; }
}
}