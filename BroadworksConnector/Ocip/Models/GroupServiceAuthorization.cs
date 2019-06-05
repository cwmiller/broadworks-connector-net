using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceAuthorization 
{
    private BroadworksConnector.Ocip.Models.GroupService _serviceName;

    [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupService ServiceName {
        get => _serviceName;
        set {
            ServiceNameSpecified = true;
            _serviceName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity {
        get => _authorizedQuantity;
        set {
            AuthorizedQuantitySpecified = true;
            _authorizedQuantity = value;
        }
    }

    [XmlIgnore]
    public bool AuthorizedQuantitySpecified { get; set; }
    private bool _unauthorized;

    [XmlElement(ElementName = "unauthorized", IsNullable = false, Namespace = "")]
    public bool Unauthorized {
        get => _unauthorized;
        set {
            UnauthorizedSpecified = true;
            _unauthorized = value;
        }
    }

    [XmlIgnore]
    public bool UnauthorizedSpecified { get; set; }
}
}
