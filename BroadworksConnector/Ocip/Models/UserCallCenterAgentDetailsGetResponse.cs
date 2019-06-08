using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterAgentDetailsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isCallCenterBasicAssigned;

    [XmlElement(ElementName = "isCallCenterBasicAssigned", IsNullable = false, Namespace = "")]
    public bool IsCallCenterBasicAssigned {
        get => _isCallCenterBasicAssigned;
        set {
            IsCallCenterBasicAssignedSpecified = true;
            _isCallCenterBasicAssigned = value;
        }
    }

    [XmlIgnore]
    public bool IsCallCenterBasicAssignedSpecified { get; set; }
    private bool _isCallCenterStandardAssigned;

    [XmlElement(ElementName = "isCallCenterStandardAssigned", IsNullable = false, Namespace = "")]
    public bool IsCallCenterStandardAssigned {
        get => _isCallCenterStandardAssigned;
        set {
            IsCallCenterStandardAssignedSpecified = true;
            _isCallCenterStandardAssigned = value;
        }
    }

    [XmlIgnore]
    public bool IsCallCenterStandardAssignedSpecified { get; set; }
    private bool _isCallCenterPremiumAssigned;

    [XmlElement(ElementName = "isCallCenterPremiumAssigned", IsNullable = false, Namespace = "")]
    public bool IsCallCenterPremiumAssigned {
        get => _isCallCenterPremiumAssigned;
        set {
            IsCallCenterPremiumAssignedSpecified = true;
            _isCallCenterPremiumAssigned = value;
        }
    }

    [XmlIgnore]
    public bool IsCallCenterPremiumAssignedSpecified { get; set; }
}
}
