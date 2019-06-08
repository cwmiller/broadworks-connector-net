using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServicePackAuthorization 
{
    private string _servicePackName;

    [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
    public string ServicePackName {
        get => _servicePackName;
        set {
            ServicePackNameSpecified = true;
            _servicePackName = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackNameSpecified { get; set; }
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
