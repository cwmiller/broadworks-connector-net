using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserConsolidatedAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ConsolidatedGroupProperties _groupProperties;

    [XmlElement(ElementName = "groupProperties", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ConsolidatedGroupProperties GroupProperties {
        get => _groupProperties;
        set {
            GroupPropertiesSpecified = true;
            _groupProperties = value;
        }
    }

    [XmlIgnore]
    public bool GroupPropertiesSpecified { get; set; }
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
    private bool _addPhoneNumberToGroup;

    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
    public bool AddPhoneNumberToGroup {
        get => _addPhoneNumberToGroup;
        set {
            AddPhoneNumberToGroupSpecified = true;
            _addPhoneNumberToGroup = value;
        }
    }

    [XmlIgnore]
    public bool AddPhoneNumberToGroupSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.NameDialingName _nameDialingName;

    [XmlElement(ElementName = "nameDialingName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NameDialingName NameDialingName {
        get => _nameDialingName;
        set {
            NameDialingNameSpecified = true;
            _nameDialingName = value;
        }
    }

    [XmlIgnore]
    public bool NameDialingNameSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.AlternateUserIdEntry> _alternateUserId;

    [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AlternateUserIdEntry> AlternateUserId {
        get => _alternateUserId;
        set {
            AlternateUserIdSpecified = true;
            _alternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool AlternateUserIdSpecified { get; set; }
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
    private string _passcode;

    [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
    public string Passcode {
        get => _passcode;
        set {
            PasscodeSpecified = true;
            _passcode = value;
        }
    }

    [XmlIgnore]
    public bool PasscodeSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactAdd _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactAdd AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactAdd _trunkAddressing;

    [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactAdd TrunkAddressing {
        get => _trunkAddressing;
        set {
            TrunkAddressingSpecified = true;
            _trunkAddressing = value;
        }
    }

    [XmlIgnore]
    public bool TrunkAddressingSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> _sharedCallAppearanceAccessDeviceEndpoint;

    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint {
        get => _sharedCallAppearanceAccessDeviceEndpoint;
        set {
            SharedCallAppearanceAccessDeviceEndpointSpecified = true;
            _sharedCallAppearanceAccessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool SharedCallAppearanceAccessDeviceEndpointSpecified { get; set; }
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
    private string _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public string NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _userService;

    [XmlElement(ElementName = "userService", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> UserService {
        get => _userService;
        set {
            UserServiceSpecified = true;
            _userService = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.ConsolidatedServicePackAssignment> _servicePack;

    [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedServicePackAssignment> ServicePack {
        get => _servicePack;
        set {
            ServicePackSpecified = true;
            _servicePack = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection _thirdPartyVoiceMailServerSelection;

    [XmlElement(ElementName = "thirdPartyVoiceMailServerSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection ThirdPartyVoiceMailServerSelection {
        get => _thirdPartyVoiceMailServerSelection;
        set {
            ThirdPartyVoiceMailServerSelectionSpecified = true;
            _thirdPartyVoiceMailServerSelection = value;
        }
    }

    [XmlIgnore]
    public bool ThirdPartyVoiceMailServerSelectionSpecified { get; set; }
    private string _thirdPartyVoiceMailServerUserServer;

    [XmlElement(ElementName = "thirdPartyVoiceMailServerUserServer", IsNullable = true, Namespace = "")]
    public string ThirdPartyVoiceMailServerUserServer {
        get => _thirdPartyVoiceMailServerUserServer;
        set {
            ThirdPartyVoiceMailServerUserServerSpecified = true;
            _thirdPartyVoiceMailServerUserServer = value;
        }
    }

    [XmlIgnore]
    public bool ThirdPartyVoiceMailServerUserServerSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType _thirdPartyVoiceMailServerMailboxIdType;

    [XmlElement(ElementName = "thirdPartyVoiceMailServerMailboxIdType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType ThirdPartyVoiceMailServerMailboxIdType {
        get => _thirdPartyVoiceMailServerMailboxIdType;
        set {
            ThirdPartyVoiceMailServerMailboxIdTypeSpecified = true;
            _thirdPartyVoiceMailServerMailboxIdType = value;
        }
    }

    [XmlIgnore]
    public bool ThirdPartyVoiceMailServerMailboxIdTypeSpecified { get; set; }
    private string _thirdPartyVoiceMailMailboxURL;

    [XmlElement(ElementName = "thirdPartyVoiceMailMailboxURL", IsNullable = true, Namespace = "")]
    public string ThirdPartyVoiceMailMailboxURL {
        get => _thirdPartyVoiceMailMailboxURL;
        set {
            ThirdPartyVoiceMailMailboxURLSpecified = true;
            _thirdPartyVoiceMailMailboxURL = value;
        }
    }

    [XmlIgnore]
    public bool ThirdPartyVoiceMailMailboxURLSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SIPAuthenticationUserNamePassword _sipAuthenticationData;

    [XmlElement(ElementName = "sipAuthenticationData", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SIPAuthenticationUserNamePassword SipAuthenticationData {
        get => _sipAuthenticationData;
        set {
            SipAuthenticationDataSpecified = true;
            _sipAuthenticationData = value;
        }
    }

    [XmlIgnore]
    public bool SipAuthenticationDataSpecified { get; set; }
}
}
