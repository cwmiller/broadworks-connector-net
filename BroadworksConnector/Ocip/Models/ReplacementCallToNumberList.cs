using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCallToNumberList 
{
    private List<BroadWorksConnector.Ocip.Models.CallToNumber> _callToNumber;

    [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CallToNumber> CallToNumber {
        get => _callToNumber;
        set {
            CallToNumberSpecified = true;
            _callToNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallToNumberSpecified { get; set; }
}
}
