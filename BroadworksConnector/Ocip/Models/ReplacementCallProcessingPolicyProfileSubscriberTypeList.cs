using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCallProcessingPolicyProfileSubscriberTypeList 
{
    private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> _subscriberType;

    [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> SubscriberType {
        get => _subscriberType;
        set {
            SubscriberTypeSpecified = true;
            _subscriberType = value;
        }
    }

    [XmlIgnore]
    public bool SubscriberTypeSpecified { get; set; }
}
}
