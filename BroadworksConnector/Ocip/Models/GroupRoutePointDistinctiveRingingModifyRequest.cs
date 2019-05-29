using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointDistinctiveRingingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "enableDistinctiveRinging", IsNullable = false)]
    public bool EnableDistinctiveRinging { get; set; }
    [XmlElement(ElementName = "distinctiveRingingRingPattern", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPattern { get; set; }
    [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingForceDeliveryRingPattern { get; set; }
 }
}
