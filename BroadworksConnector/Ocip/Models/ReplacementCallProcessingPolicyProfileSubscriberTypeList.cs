using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCallProcessingPolicyProfileSubscriberTypeList 
{
    [XmlElement(ElementName = "subscriberType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> SubscriberType { get; set; }
 }
}
