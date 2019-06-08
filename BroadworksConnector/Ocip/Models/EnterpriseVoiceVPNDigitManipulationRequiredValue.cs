using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNDigitManipulationRequiredValue : BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
{
    private BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationRequiredValue _operation;

    [XmlElement(ElementName = "operation", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationRequiredValue Operation {
        get => _operation;
        set {
            OperationSpecified = true;
            _operation = value;
        }
    }

    [XmlIgnore]
    public bool OperationSpecified { get; set; }
    private string _value;

    [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
    public string Value {
        get => _value;
        set {
            ValueSpecified = true;
            _value = value;
        }
    }

    [XmlIgnore]
    public bool ValueSpecified { get; set; }
}
}
