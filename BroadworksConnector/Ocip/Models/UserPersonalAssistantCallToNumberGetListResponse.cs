using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantCallToNumberGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.CallToNumber> _callToNumber;

    [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallToNumber> CallToNumber {
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
