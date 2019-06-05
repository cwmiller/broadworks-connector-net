using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderNumberPortabilityQueryModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
    private List<string> _deleteDigitPattern;

    [XmlElement(ElementName = "deleteDigitPattern", IsNullable = false, Namespace = "")]
    public List<string> DeleteDigitPattern {
        get => _deleteDigitPattern;
        set {
            DeleteDigitPatternSpecified = true;
            _deleteDigitPattern = value;
        }
    }

    [XmlIgnore]
    public bool DeleteDigitPatternSpecified { get; set; }
}
}
