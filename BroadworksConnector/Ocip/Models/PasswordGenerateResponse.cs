using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordGenerateResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _systemAdministratorPassword;

    [XmlElement(ElementName = "systemAdministratorPassword", IsNullable = false, Namespace = "")]
    public string SystemAdministratorPassword {
        get => _systemAdministratorPassword;
        set {
            SystemAdministratorPasswordSpecified = true;
            _systemAdministratorPassword = value;
        }
    }

    [XmlIgnore]
    public bool SystemAdministratorPasswordSpecified { get; set; }
    private string _serviceProviderAdministratorPassword;

    [XmlElement(ElementName = "serviceProviderAdministratorPassword", IsNullable = false, Namespace = "")]
    public string ServiceProviderAdministratorPassword {
        get => _serviceProviderAdministratorPassword;
        set {
            ServiceProviderAdministratorPasswordSpecified = true;
            _serviceProviderAdministratorPassword = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdministratorPasswordSpecified { get; set; }
    private string _groupAdministratorPassword;

    [XmlElement(ElementName = "groupAdministratorPassword", IsNullable = false, Namespace = "")]
    public string GroupAdministratorPassword {
        get => _groupAdministratorPassword;
        set {
            GroupAdministratorPasswordSpecified = true;
            _groupAdministratorPassword = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdministratorPasswordSpecified { get; set; }
    private string _userPassword;

    [XmlElement(ElementName = "userPassword", IsNullable = false, Namespace = "")]
    public string UserPassword {
        get => _userPassword;
        set {
            UserPasswordSpecified = true;
            _userPassword = value;
        }
    }

    [XmlIgnore]
    public bool UserPasswordSpecified { get; set; }
    private string _userPasscode;

    [XmlElement(ElementName = "userPasscode", IsNullable = false, Namespace = "")]
    public string UserPasscode {
        get => _userPasscode;
        set {
            UserPasscodeSpecified = true;
            _userPasscode = value;
        }
    }

    [XmlIgnore]
    public bool UserPasscodeSpecified { get; set; }
    private string _userSIPAuthenticationPassword;

    [XmlElement(ElementName = "userSIPAuthenticationPassword", IsNullable = false, Namespace = "")]
    public string UserSIPAuthenticationPassword {
        get => _userSIPAuthenticationPassword;
        set {
            UserSIPAuthenticationPasswordSpecified = true;
            _userSIPAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool UserSIPAuthenticationPasswordSpecified { get; set; }
    private string _accessDeviceAuthenticationPassword;

    [XmlElement(ElementName = "accessDeviceAuthenticationPassword", IsNullable = false, Namespace = "")]
    public string AccessDeviceAuthenticationPassword {
        get => _accessDeviceAuthenticationPassword;
        set {
            AccessDeviceAuthenticationPasswordSpecified = true;
            _accessDeviceAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceAuthenticationPasswordSpecified { get; set; }
    private string _trunkGroupAuthenticationPassword;

    [XmlElement(ElementName = "trunkGroupAuthenticationPassword", IsNullable = false, Namespace = "")]
    public string TrunkGroupAuthenticationPassword {
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
