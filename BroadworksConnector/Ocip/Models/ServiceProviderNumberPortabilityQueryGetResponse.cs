using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderNumberPortabilityQueryGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableNumberPortabilityQueryForOutgoingCalls;

    [XmlElement(ElementName = "enableNumberPortabilityQueryForOutgoingCalls", IsNullable = false, Namespace = "")]
    public bool EnableNumberPortabilityQueryForOutgoingCalls {
        get => _enableNumberPortabilityQueryForOutgoingCalls;
        set {
            EnableNumberPortabilityQueryForOutgoingCallsSpecified = true;
            _enableNumberPortabilityQueryForOutgoingCalls = value;
        }
    }

    [XmlIgnore]
    public bool EnableNumberPortabilityQueryForOutgoingCallsSpecified { get; set; }
    private bool _enableNumberPortabilityQueryForIncomingCalls;

    [XmlElement(ElementName = "enableNumberPortabilityQueryForIncomingCalls", IsNullable = false, Namespace = "")]
    public bool EnableNumberPortabilityQueryForIncomingCalls {
        get => _enableNumberPortabilityQueryForIncomingCalls;
        set {
            EnableNumberPortabilityQueryForIncomingCallsSpecified = true;
            _enableNumberPortabilityQueryForIncomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool EnableNumberPortabilityQueryForIncomingCallsSpecified { get; set; }
    private bool _enableNumberPortabilityQueryForNetworkCallsOnly;

    [XmlElement(ElementName = "enableNumberPortabilityQueryForNetworkCallsOnly", IsNullable = false, Namespace = "")]
    public bool EnableNumberPortabilityQueryForNetworkCallsOnly {
        get => _enableNumberPortabilityQueryForNetworkCallsOnly;
        set {
            EnableNumberPortabilityQueryForNetworkCallsOnlySpecified = true;
            _enableNumberPortabilityQueryForNetworkCallsOnly = value;
        }
    }

    [XmlIgnore]
    public bool EnableNumberPortabilityQueryForNetworkCallsOnlySpecified { get; set; }
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
