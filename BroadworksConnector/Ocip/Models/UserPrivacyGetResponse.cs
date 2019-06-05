using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrivacyGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableDirectoryPrivacy;

    [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false, Namespace = "")]
    public bool EnableDirectoryPrivacy {
        get => _enableDirectoryPrivacy;
        set {
            EnableDirectoryPrivacySpecified = true;
            _enableDirectoryPrivacy = value;
        }
    }

    [XmlIgnore]
    public bool EnableDirectoryPrivacySpecified { get; set; }
}
}
