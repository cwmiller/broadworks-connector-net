using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private string _lastName;

    [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
    public string LastName {
        get => _lastName;
        set {
            LastNameSpecified = true;
            _lastName = value;
        }
    }

    [XmlIgnore]
    public bool LastNameSpecified { get; set; }
    private string _firstName;

    [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
    public string FirstName {
        get => _firstName;
        set {
            FirstNameSpecified = true;
            _firstName = value;
        }
    }

    [XmlIgnore]
    public bool FirstNameSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.DepartmentKey _department;

    [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department {
        get => _department;
        set {
            DepartmentSpecified = true;
            _department = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentSpecified { get; set; }
    private string _departmentFullPath;

    [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
    public string DepartmentFullPath {
        get => _departmentFullPath;
        set {
            DepartmentFullPathSpecified = true;
            _departmentFullPath = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentFullPathSpecified { get; set; }
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
    private string _timeZoneDisplayName;

    [XmlElement(ElementName = "timeZoneDisplayName", IsNullable = false, Namespace = "")]
    public string TimeZoneDisplayName {
        get => _timeZoneDisplayName;
        set {
            TimeZoneDisplayNameSpecified = true;
            _timeZoneDisplayName = value;
        }
    }

    [XmlIgnore]
    public bool TimeZoneDisplayNameSpecified { get; set; }
    private string _defaultAlias;

    [XmlElement(ElementName = "defaultAlias", IsNullable = false, Namespace = "")]
    public string DefaultAlias {
        get => _defaultAlias;
        set {
            DefaultAliasSpecified = true;
            _defaultAlias = value;
        }
    }

    [XmlIgnore]
    public bool DefaultAliasSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointRead _trunkGroupDeviceEndpoint;

    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointRead TrunkGroupDeviceEndpoint {
        get => _trunkGroupDeviceEndpoint;
        set {
            TrunkGroupDeviceEndpointSpecified = true;
            _trunkGroupDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool TrunkGroupDeviceEndpointSpecified { get; set; }
    private string _title;

    [XmlElement(ElementName = "title", IsNullable = false, Namespace = "")]
    public string Title {
        get => _title;
        set {
            TitleSpecified = true;
            _title = value;
        }
    }

    [XmlIgnore]
    public bool TitleSpecified { get; set; }
    private string _pagerPhoneNumber;

    [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = false, Namespace = "")]
    public string PagerPhoneNumber {
        get => _pagerPhoneNumber;
        set {
            PagerPhoneNumberSpecified = true;
            _pagerPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PagerPhoneNumberSpecified { get; set; }
    private string _mobilePhoneNumber;

    [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = false, Namespace = "")]
    public string MobilePhoneNumber {
        get => _mobilePhoneNumber;
        set {
            MobilePhoneNumberSpecified = true;
            _mobilePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool MobilePhoneNumberSpecified { get; set; }
    private string _emailAddress;

    [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
    public string EmailAddress {
        get => _emailAddress;
        set {
            EmailAddressSpecified = true;
            _emailAddress = value;
        }
    }

    [XmlIgnore]
    public bool EmailAddressSpecified { get; set; }
    private string _yahooId;

    [XmlElement(ElementName = "yahooId", IsNullable = false, Namespace = "")]
    public string YahooId {
        get => _yahooId;
        set {
            YahooIdSpecified = true;
            _yahooId = value;
        }
    }

    [XmlIgnore]
    public bool YahooIdSpecified { get; set; }
    private string _addressLocation;

    [XmlElement(ElementName = "addressLocation", IsNullable = false, Namespace = "")]
    public string AddressLocation {
        get => _addressLocation;
        set {
            AddressLocationSpecified = true;
            _addressLocation = value;
        }
    }

    [XmlIgnore]
    public bool AddressLocationSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.StreetAddress _address;

    [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.StreetAddress Address {
        get => _address;
        set {
            AddressSpecified = true;
            _address = value;
        }
    }

    [XmlIgnore]
    public bool AddressSpecified { get; set; }
}
}
