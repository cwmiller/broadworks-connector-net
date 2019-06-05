using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordForUser 
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
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _generatePassword;

    [XmlElement(ElementName = "generatePassword", IsNullable = false, Namespace = "")]
    public bool GeneratePassword {
        get => _generatePassword;
        set {
            GeneratePasswordSpecified = true;
            _generatePassword = value;
        }
    }

    [XmlIgnore]
    public bool GeneratePasswordSpecified { get; set; }
    private bool _generatePasscode;

    [XmlElement(ElementName = "generatePasscode", IsNullable = false, Namespace = "")]
    public bool GeneratePasscode {
        get => _generatePasscode;
        set {
            GeneratePasscodeSpecified = true;
            _generatePasscode = value;
        }
    }

    [XmlIgnore]
    public bool GeneratePasscodeSpecified { get; set; }
    private bool _generateSipPassword;

    [XmlElement(ElementName = "generateSipPassword", IsNullable = false, Namespace = "")]
    public bool GenerateSipPassword {
        get => _generateSipPassword;
        set {
            GenerateSipPasswordSpecified = true;
            _generateSipPassword = value;
        }
    }

    [XmlIgnore]
    public bool GenerateSipPasswordSpecified { get; set; }
}
}
