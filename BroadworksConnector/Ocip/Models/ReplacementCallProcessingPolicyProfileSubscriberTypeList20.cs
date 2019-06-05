using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCallProcessingPolicyProfileSubscriberTypeList20 
{
    private List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> _subscriberType;

    [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> SubscriberType {
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
