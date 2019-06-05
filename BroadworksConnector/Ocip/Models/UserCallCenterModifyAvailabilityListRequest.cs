using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterModifyAvailabilityListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallCenterAgentAvailability> _callCenterAvailability;

    [XmlElement(ElementName = "callCenterAvailability", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallCenterAgentAvailability> CallCenterAvailability {
        get => _callCenterAvailability;
        set {
            CallCenterAvailabilitySpecified = true;
            _callCenterAvailability = value;
        }
    }

    [XmlIgnore]
    public bool CallCenterAvailabilitySpecified { get; set; }
}
}
