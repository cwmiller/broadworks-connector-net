using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LogoutRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.LogoutRequestReason _reason;

    [XmlElement(ElementName = "reason", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LogoutRequestReason Reason {
        get => _reason;
        set {
            ReasonSpecified = true;
            _reason = value;
        }
    }

    [XmlIgnore]
    public bool ReasonSpecified { get; set; }
}
}
