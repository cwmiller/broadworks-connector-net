using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetResponse14sp9 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _maxActiveCalls;

    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
    public int MaxActiveCalls {
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
    private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxActiveCalls;

    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxActiveCalls {
        get => _burstingMaxActiveCalls;
        set {
            BurstingMaxActiveCallsSpecified = true;
            _burstingMaxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxActiveCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _burstingMaxAvailableActiveCalls;

    [XmlElement(ElementName = "burstingMaxAvailableActiveCalls", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt BurstingMaxAvailableActiveCalls {
        get => _burstingMaxAvailableActiveCalls;
        set {
            BurstingMaxAvailableActiveCallsSpecified = true;
            _burstingMaxAvailableActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxAvailableActiveCallsSpecified { get; set; }
}
}
