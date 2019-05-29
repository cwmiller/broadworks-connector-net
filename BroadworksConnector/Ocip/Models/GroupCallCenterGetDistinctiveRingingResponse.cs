using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetDistinctiveRingingResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "distinctiveRingingCallCenterCalls", IsNullable = false)]
    public bool DistinctiveRingingCallCenterCalls { get; set; }
    [XmlElement(ElementName = "distinctiveRingingRingPatternForCallCenter", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPatternForCallCenter { get; set; }
    [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingForceDeliveryRingPattern { get; set; }
 }
}
