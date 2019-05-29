using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt MaxActiveCalls { get; set; }
    [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt MaxAvailableActiveCalls { get; set; }
 }
}
