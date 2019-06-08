using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallNotifyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _callNotifyEmailAddress;

    [XmlElement(ElementName = "callNotifyEmailAddress", IsNullable = false, Namespace = "")]
    public string CallNotifyEmailAddress {
        get => _callNotifyEmailAddress;
        set {
            CallNotifyEmailAddressSpecified = true;
            _callNotifyEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool CallNotifyEmailAddressSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

    [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
        get => _criteriaActivation;
        set {
            CriteriaActivationSpecified = true;
            _criteriaActivation = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaActivationSpecified { get; set; }
}
}
