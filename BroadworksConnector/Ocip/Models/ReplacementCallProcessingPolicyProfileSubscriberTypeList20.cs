using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCallProcessingPolicyProfileSubscriberTypeList20 
{
    [XmlElement(ElementName = "subscriberType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType20> SubscriberType { get; set; }
 }
}
