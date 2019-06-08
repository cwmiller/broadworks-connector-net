using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxActiveCalls;

    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt MaxActiveCalls {
        get => _maxActiveCalls;
        set {
            MaxActiveCallsSpecified = true;
            _maxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxActiveCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _maxAvailableActiveCalls;

    [XmlElement(ElementName = "maxAvailableActiveCalls", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt MaxAvailableActiveCalls {
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
