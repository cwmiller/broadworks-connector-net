using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyDistinctiveRingingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _distinctiveRingingCallCenterCalls;

    [XmlElement(ElementName = "distinctiveRingingCallCenterCalls", IsNullable = false, Namespace = "")]
    public bool DistinctiveRingingCallCenterCalls {
        get => _distinctiveRingingCallCenterCalls;
        set {
            DistinctiveRingingCallCenterCallsSpecified = true;
            _distinctiveRingingCallCenterCalls = value;
        }
    }

    [XmlIgnore]
    public bool DistinctiveRingingCallCenterCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingRingPatternForCallCenter;

    [XmlElement(ElementName = "distinctiveRingingRingPatternForCallCenter", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPatternForCallCenter {
        get => _distinctiveRingingRingPatternForCallCenter;
        set {
            DistinctiveRingingRingPatternForCallCenterSpecified = true;
            _distinctiveRingingRingPatternForCallCenter = value;
        }
    }

    [XmlIgnore]
    public bool DistinctiveRingingRingPatternForCallCenterSpecified { get; set; }
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
