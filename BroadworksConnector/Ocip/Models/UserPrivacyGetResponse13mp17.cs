using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrivacyGetResponse13mp17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _enableAutoAttendantNameDialingPrivacy;

    [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false, Namespace = "")]
    public bool EnableAutoAttendantNameDialingPrivacy {
        get => _enableAutoAttendantNameDialingPrivacy;
        set {
            EnableAutoAttendantNameDialingPrivacySpecified = true;
            _enableAutoAttendantNameDialingPrivacy = value;
        }
    }

    [XmlIgnore]
    public bool EnableAutoAttendantNameDialingPrivacySpecified { get; set; }
    private bool _enablePhoneStatusPrivacy;

    [XmlElement(ElementName = "enablePhoneStatusPrivacy", IsNullable = false, Namespace = "")]
    public bool EnablePhoneStatusPrivacy {
        get => _enablePhoneStatusPrivacy;
        set {
            EnablePhoneStatusPrivacySpecified = true;
            _enablePhoneStatusPrivacy = value;
        }
    }

    [XmlIgnore]
    public bool EnablePhoneStatusPrivacySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _permittedMonitorUserIdTable;

    [XmlElement(ElementName = "permittedMonitorUserIdTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PermittedMonitorUserIdTable {
        get => _permittedMonitorUserIdTable;
        set {
            PermittedMonitorUserIdTableSpecified = true;
            _permittedMonitorUserIdTable = value;
        }
    }

    [XmlIgnore]
    public bool PermittedMonitorUserIdTableSpecified { get; set; }
}
}
