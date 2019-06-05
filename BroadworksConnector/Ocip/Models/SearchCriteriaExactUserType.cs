using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactUserType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.UserType _userType;

    [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserType UserType {
        get => _userType;
        set {
            UserTypeSpecified = true;
            _userType = value;
        }
    }

    [XmlIgnore]
    public bool UserTypeSpecified { get; set; }
}
}
