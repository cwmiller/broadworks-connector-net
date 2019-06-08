using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVerifyTranslationAndRoutingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingParameters _parameters;

    [XmlElement(ElementName = "parameters", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingParameters Parameters {
        get => _parameters;
        set {
            ParametersSpecified = true;
            _parameters = value;
        }
    }

    [XmlIgnore]
    public bool ParametersSpecified { get; set; }
    private string _sipMessage;

    [XmlElement(ElementName = "sipMessage", IsNullable = false, Namespace = "")]
    public string SipMessage {
        get => _sipMessage;
        set {
            SipMessageSpecified = true;
            _sipMessage = value;
        }
    }

    [XmlIgnore]
    public bool SipMessageSpecified { get; set; }
}
}
