using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServiceModifyAuthorizationListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization> _groupServiceAuthorization;

    [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization> GroupServiceAuthorization {
        get => _groupServiceAuthorization;
        set {
            GroupServiceAuthorizationSpecified = true;
            _groupServiceAuthorization = value;
        }
    }

    [XmlIgnore]
    public bool GroupServiceAuthorizationSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization> _userServiceAuthorization;

    [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization> UserServiceAuthorization {
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
