using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordForServiceProviderAdministrator 
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
    private string _administratorId;

    [XmlElement(ElementName = "administratorId", IsNullable = false, Namespace = "")]
    public string AdministratorId {
        get => _administratorId;
        set {
            AdministratorIdSpecified = true;
            _administratorId = value;
        }
    }

    [XmlIgnore]
    public bool AdministratorIdSpecified { get; set; }
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
}
}
