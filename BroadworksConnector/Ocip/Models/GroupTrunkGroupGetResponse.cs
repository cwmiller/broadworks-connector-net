using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt _maxAvailableActiveCalls;

    [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt MaxAvailableActiveCalls {
        get => _maxAvailableActiveCalls;
        set {
            MaxAvailableActiveCallsSpecified = true;
            _maxAvailableActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxAvailableActiveCallsSpecified { get; set; }
}
}
