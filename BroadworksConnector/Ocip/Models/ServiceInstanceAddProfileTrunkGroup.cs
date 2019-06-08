using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceInstanceAddProfileTrunkGroup 
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _callingLineIdLastName;

    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
    public string CallingLineIdLastName {
        get => _callingLineIdLastName;
        set {
            CallingLineIdLastNameSpecified = true;
            _callingLineIdLastName = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdLastNameSpecified { get; set; }
    private string _callingLineIdFirstName;

    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
    public string CallingLineIdFirstName {
        get => _callingLineIdFirstName;
        set {
            CallingLineIdFirstNameSpecified = true;
            _callingLineIdFirstName = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdFirstNameSpecified { get; set; }
    private string _hiraganaLastName;

    [XmlElement(ElementName = "hiraganaLastName", IsNullable = false, Namespace = "")]
    public string HiraganaLastName {
        get => _hiraganaLastName;
        set {
            HiraganaLastNameSpecified = true;
            _hiraganaLastName = value;
        }
    }

    [XmlIgnore]
    public bool HiraganaLastNameSpecified { get; set; }
    private string _hiraganaFirstName;

    [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false, Namespace = "")]
    public string HiraganaFirstName {
        get => _hiraganaFirstName;
        set {
            HiraganaFirstNameSpecified = true;
            _hiraganaFirstName = value;
        }
    }

    [XmlIgnore]
    public bool HiraganaFirstNameSpecified { get; set; }
    private string _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private string _extension;

    [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
    public string Extension {
        get => _extension;
        set {
            ExtensionSpecified = true;
            _extension = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionSpecified { get; set; }
    private string _password;

    [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
    public string Password {
        get => _password;
        set {
            PasswordSpecified = true;
            _password = value;
        }
    }

    [XmlIgnore]
    public bool PasswordSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

    [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DepartmentKey Department {
        get => _department;
        set {
            DepartmentSpecified = true;
            _department = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentSpecified { get; set; }
    private string _language;

    [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
    public string Language {
        get => _language;
        set {
            LanguageSpecified = true;
            _language = value;
        }
    }

    [XmlIgnore]
    public bool LanguageSpecified { get; set; }
    private string _timeZone;

    [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
    public string TimeZone {
        get => _timeZone;
        set {
            TimeZoneSpecified = true;
            _timeZone = value;
        }
    }

    [XmlIgnore]
    public bool TimeZoneSpecified { get; set; }
    private List<string> _alias;

    [XmlElement(ElementName = "alias", IsNullable = false, Namespace = "")]
    public List<string> Alias {
        get => _alias;
        set {
            AliasSpecified = true;
            _alias = value;
        }
    }

    [XmlIgnore]
    public bool AliasSpecified { get; set; }
    private string _callingLineIdPhoneNumber;

    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
    public string CallingLineIdPhoneNumber {
        get => _callingLineIdPhoneNumber;
        set {
            CallingLineIdPhoneNumberSpecified = true;
            _callingLineIdPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdPhoneNumberSpecified { get; set; }
}
}
