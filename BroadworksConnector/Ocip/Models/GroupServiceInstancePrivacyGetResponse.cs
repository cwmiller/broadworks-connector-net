using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceInstancePrivacyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _enableAutoAttendantExtensionDialingPrivacy;

    [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false, Namespace = "")]
    public bool EnableAutoAttendantExtensionDialingPrivacy {
        get => _enableAutoAttendantExtensionDialingPrivacy;
        set {
            EnableAutoAttendantExtensionDialingPrivacySpecified = true;
            _enableAutoAttendantExtensionDialingPrivacy = value;
        }
    }

    [XmlIgnore]
    public bool EnableAutoAttendantExtensionDialingPrivacySpecified { get; set; }
}
}
