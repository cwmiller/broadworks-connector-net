using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _matchDigitPattern;

    [XmlElement(ElementName = "matchDigitPattern", IsNullable = false, Namespace = "")]
    public List<string> MatchDigitPattern {
        get => _matchDigitPattern;
        set {
            MatchDigitPatternSpecified = true;
            _matchDigitPattern = value;
        }
    }

    [XmlIgnore]
    public bool MatchDigitPatternSpecified { get; set; }
}
}
