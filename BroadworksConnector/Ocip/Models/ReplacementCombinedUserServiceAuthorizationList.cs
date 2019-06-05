using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedUserServiceAuthorizationList 
{
    private List<BroadworksConnector.Ocip.Models.CombinedUserServiceAuthorization> _userServiceAuthorization;

    [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CombinedUserServiceAuthorization> UserServiceAuthorization {
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
