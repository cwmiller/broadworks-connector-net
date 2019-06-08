using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedUserServiceAuthorizationList 
{
    private List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAuthorization> _userServiceAuthorization;

    [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAuthorization> UserServiceAuthorization {
        get => _userServiceAuthorization;
        set {
            UserServiceAuthorizationSpecified = true;
            _userServiceAuthorization = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceAuthorizationSpecified { get; set; }
}
}
