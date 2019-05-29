using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyDistinctiveRingingRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "distinctiveRingingCallCenterCalls", IsNullable = false)]
    public bool DistinctiveRingingCallCenterCalls { get; set; }
    [XmlElement(ElementName = "distinctiveRingingRingPatternForCallCenter", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPatternForCallCenter { get; set; }
    [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingForceDeliveryRingPattern { get; set; }
 }
}
