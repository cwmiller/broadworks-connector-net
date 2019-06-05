using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPriorityAlertModifyActiveCriteriaListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

    [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
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
