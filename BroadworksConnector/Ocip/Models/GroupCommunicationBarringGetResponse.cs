using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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

    [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
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
