using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointDistinctiveRingingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableDistinctiveRinging", IsNullable = false)]
    public bool EnableDistinctiveRinging { get; set; }
    [XmlElement(ElementName = "distinctiveRingingRingPattern", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPattern { get; set; }
    [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern DistinctiveRingingForceDeliveryRingPattern { get; set; }
 }
}
