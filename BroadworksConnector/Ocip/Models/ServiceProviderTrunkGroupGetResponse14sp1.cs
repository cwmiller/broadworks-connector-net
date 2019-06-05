using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderTrunkGroupGetResponse14sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt _maxActiveCalls;

    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt MaxActiveCalls {
        get => _maxActiveCalls;
        set {
            MaxActiveCallsSpecified = true;
            _maxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxActiveCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxActiveCalls;

    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxActiveCalls {
        get => _burstingMaxActiveCalls;
        set {
            BurstingMaxActiveCallsSpecified = true;
            _burstingMaxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxActiveCallsSpecified { get; set; }
}
}
