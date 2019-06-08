using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServiceGetAuthorizationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _authorized;

    [XmlElement(ElementName = "authorized", IsNullable = false, Namespace = "")]
    public bool Authorized {
        get => _authorized;
        set {
            AuthorizedSpecified = true;
            _authorized = value;
        }
    }

    [XmlIgnore]
    public bool AuthorizedSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _authorizedQuantity;

    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt AuthorizedQuantity {
        get => _authorizedQuantity;
        set {
            AuthorizedQuantitySpecified = true;
            _authorizedQuantity = value;
        }
    }

    [XmlIgnore]
    public bool AuthorizedQuantitySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _usedQuantity;

    [XmlElement(ElementName = "usedQuantity", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt UsedQuantity {
        get => _usedQuantity;
        set {
            UsedQuantitySpecified = true;
            _usedQuantity = value;
        }
    }

    [XmlIgnore]
    public bool UsedQuantitySpecified { get; set; }
    private bool _authorizable;

    [XmlElement(ElementName = "authorizable", IsNullable = false, Namespace = "")]
    public bool Authorizable {
        get => _authorizable;
        set {
            AuthorizableSpecified = true;
            _authorizable = value;
        }
    }

    [XmlIgnore]
    public bool AuthorizableSpecified { get; set; }
}
}
