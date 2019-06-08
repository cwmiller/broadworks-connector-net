using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ConsolidatedUserServiceAssignment 
{
    private BroadWorksConnector.Ocip.Models.UserService _userServiceName;

    [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UserService UserServiceName {
        get => _userServiceName;
        set {
            UserServiceNameSpecified = true;
            _userServiceName = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceNameSpecified { get; set; }
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
