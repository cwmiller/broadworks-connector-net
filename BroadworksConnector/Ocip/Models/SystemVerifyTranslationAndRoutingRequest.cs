using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVerifyTranslationAndRoutingRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.VerifyTranslationAndRoutingParameters _parameters;

    [XmlElement(ElementName = "parameters", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VerifyTranslationAndRoutingParameters Parameters {
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
