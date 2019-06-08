using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostRoutingPoliciesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _allowEmergencyCalls;

    [XmlElement(ElementName = "allowEmergencyCalls", IsNullable = false, Namespace = "")]
    public bool AllowEmergencyCalls {
        get => _allowEmergencyCalls;
        set {
            AllowEmergencyCallsSpecified = true;
            _allowEmergencyCalls = value;
        }
    }

    [XmlIgnore]
    public bool AllowEmergencyCallsSpecified { get; set; }
    private bool _allowCallsToVoicePortal;

    [XmlElement(ElementName = "allowCallsToVoicePortal", IsNullable = false, Namespace = "")]
    public bool AllowCallsToVoicePortal {
        get => _allowCallsToVoicePortal;
        set {
            AllowCallsToVoicePortalSpecified = true;
            _allowCallsToVoicePortal = value;
        }
    }

    [XmlIgnore]
    public bool AllowCallsToVoicePortalSpecified { get; set; }
}
}
