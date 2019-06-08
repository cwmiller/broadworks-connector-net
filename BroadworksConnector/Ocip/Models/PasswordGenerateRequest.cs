using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordGenerateRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.PasswordForSystemAdministrator _systemAdministratorPassword;

    [XmlElement(ElementName = "systemAdministratorPassword", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PasswordForSystemAdministrator SystemAdministratorPassword {
        get => _systemAdministratorPassword;
        set {
            SystemAdministratorPasswordSpecified = true;
            _systemAdministratorPassword = value;
        }
    }

    [XmlIgnore]
    public bool SystemAdministratorPasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PasswordForServiceProviderAdministrator _serviceProviderAdministratorPassword;

    [XmlElement(ElementName = "serviceProviderAdministratorPassword", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PasswordForServiceProviderAdministrator ServiceProviderAdministratorPassword {
        get => _serviceProviderAdministratorPassword;
        set {
            ServiceProviderAdministratorPasswordSpecified = true;
            _serviceProviderAdministratorPassword = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdministratorPasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PasswordForGroupAdministrator _groupAdministratorPassword;

    [XmlElement(ElementName = "groupAdministratorPassword", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PasswordForGroupAdministrator GroupAdministratorPassword {
        get => _groupAdministratorPassword;
        set {
            GroupAdministratorPasswordSpecified = true;
            _groupAdministratorPassword = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdministratorPasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PasswordForUser _userPassword;

    [XmlElement(ElementName = "userPassword", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PasswordForUser UserPassword {
        get => _userPassword;
        set {
            UserPasswordSpecified = true;
            _userPassword = value;
        }
    }

    [XmlIgnore]
    public bool UserPasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PasswordForAccessDevice _accessDeviceAuthenticationPassword;

    [XmlElement(ElementName = "accessDeviceAuthenticationPassword", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PasswordForAccessDevice AccessDeviceAuthenticationPassword {
        get => _accessDeviceAuthenticationPassword;
        set {
            AccessDeviceAuthenticationPasswordSpecified = true;
            _accessDeviceAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceAuthenticationPasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PasswordForTrunkGroup _trunkGroupAuthenticationPassword;

    [XmlElement(ElementName = "trunkGroupAuthenticationPassword", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PasswordForTrunkGroup TrunkGroupAuthenticationPassword {
        get => _trunkGroupAuthenticationPassword;
        set {
            TrunkGroupAuthenticationPasswordSpecified = true;
            _trunkGroupAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupAuthenticationPasswordSpecified { get; set; }
}
}
