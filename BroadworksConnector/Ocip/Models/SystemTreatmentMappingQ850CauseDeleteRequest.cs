using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingQ850CauseDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
}
}
