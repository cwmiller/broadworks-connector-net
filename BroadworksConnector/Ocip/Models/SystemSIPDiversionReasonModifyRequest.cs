using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDiversionReasonModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.SIPDiversionReason _diversionReason;

    [XmlElement(ElementName = "diversionReason", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SIPDiversionReason DiversionReason {
        get => _diversionReason;
        set {
            DiversionReasonSpecified = true;
            _diversionReason = value;
        }
    }

    [XmlIgnore]
    public bool DiversionReasonSpecified { get; set; }
    private string _causeValue;

    [XmlElement(ElementName = "causeValue", IsNullable = false, Namespace = "")]
    public string CauseValue {
        get => _causeValue;
        set {
            CauseValueSpecified = true;
            _causeValue = value;
        }
    }

    [XmlIgnore]
    public bool CauseValueSpecified { get; set; }
}
}
