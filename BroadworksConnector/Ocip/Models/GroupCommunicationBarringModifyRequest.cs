using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private bool _useDefaultServiceProviderProfile;

    [XmlElement(ElementName = "useDefaultServiceProviderProfile", IsNullable = false, Namespace = "")]
    public bool UseDefaultServiceProviderProfile {
        get => _useDefaultServiceProviderProfile;
        set {
            UseDefaultServiceProviderProfileSpecified = true;
            _useDefaultServiceProviderProfile = value;
        }
    }

    [XmlIgnore]
    public bool UseDefaultServiceProviderProfileSpecified { get; set; }
    private string _profile;

    [XmlElement(ElementName = "profile", IsNullable = true, Namespace = "")]
    public string Profile {
        get => _profile;
        set {
            ProfileSpecified = true;
            _profile = value;
        }
    }

    [XmlIgnore]
    public bool ProfileSpecified { get; set; }
}
}
