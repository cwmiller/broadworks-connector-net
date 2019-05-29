using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCallProcessingPolicyProfileSubscriberTypeList21 
{
    [XmlElement(ElementName = "subscriberType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> SubscriberType { get; set; }
 }
}
