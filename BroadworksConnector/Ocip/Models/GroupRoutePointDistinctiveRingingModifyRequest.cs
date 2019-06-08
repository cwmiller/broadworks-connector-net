using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointDistinctiveRingingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private bool _enableDistinctiveRinging;

    [XmlElement(ElementName = "enableDistinctiveRinging", IsNullable = false, Namespace = "")]
    public bool EnableDistinctiveRinging {
        get => _enableDistinctiveRinging;
        set {
            EnableDistinctiveRingingSpecified = true;
            _enableDistinctiveRinging = value;
        }
    }

    [XmlIgnore]
    public bool EnableDistinctiveRingingSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingRingPattern;

    [XmlElement(ElementName = "distinctiveRingingRingPattern", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPattern {
        get => _distinctiveRingingRingPattern;
        set {
            DistinctiveRingingRingPatternSpecified = true;
            _distinctiveRingingRingPattern = value;
        }
    }

    [XmlIgnore]
    public bool DistinctiveRingingRingPatternSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingForceDeliveryRingPattern;

    [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingForceDeliveryRingPattern {
        get => _distinctiveRingingForceDeliveryRingPattern;
        set {
            DistinctiveRingingForceDeliveryRingPatternSpecified = true;
            _distinctiveRingingForceDeliveryRingPattern = value;
        }
    }

    [XmlIgnore]
    public bool DistinctiveRingingForceDeliveryRingPatternSpecified { get; set; }
}
}
