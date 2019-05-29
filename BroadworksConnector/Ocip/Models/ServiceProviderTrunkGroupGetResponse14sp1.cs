using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderTrunkGroupGetResponse14sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt MaxActiveCalls { get; set; }
    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxActiveCalls { get; set; }
 }
}
