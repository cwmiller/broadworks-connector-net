using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingFamilyGetCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _criteriaName;

    [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
    public string CriteriaName {
        get => _criteriaName;
        set {
            CriteriaNameSpecified = true;
            _criteriaName = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaNameSpecified { get; set; }
}
}
