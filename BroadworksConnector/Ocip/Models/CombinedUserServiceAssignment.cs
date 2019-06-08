using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CombinedUserServiceAssignment 
{
    private BroadWorksConnector.Ocip.Models.UserService _userService;

    [XmlElement(ElementName = "userService", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UserService UserService {
        get => _userService;
        set {
            UserServiceSpecified = true;
            _userService = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity {
        get => _authorizedQuantity;
        set {
            AuthorizedQuantitySpecified = true;
            _authorizedQuantity = value;
        }
    }

    [XmlIgnore]
    public bool AuthorizedQuantitySpecified { get; set; }
}
}
