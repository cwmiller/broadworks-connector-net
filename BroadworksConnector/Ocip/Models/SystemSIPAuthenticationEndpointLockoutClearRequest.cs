using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAuthenticationEndpointLockoutClearRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.UserEndpointKey> _userEndpointKey;

    [XmlElement(ElementName = "userEndpointKey", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.UserEndpointKey> UserEndpointKey {
        get => _userEndpointKey;
        set {
            UserEndpointKeySpecified = true;
            _userEndpointKey = value;
        }
    }

    [XmlIgnore]
    public bool UserEndpointKeySpecified { get; set; }
}
}
