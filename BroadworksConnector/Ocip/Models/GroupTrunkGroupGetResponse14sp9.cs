using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetResponse14sp9 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false)]
    public int MaxActiveCalls { get; set; }
    [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt MaxAvailableActiveCalls { get; set; }
    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxActiveCalls { get; set; }
    [XmlElement(ElementName = "burstingMaxAvailableActiveCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxAvailableActiveCalls { get; set; }
 }
}
