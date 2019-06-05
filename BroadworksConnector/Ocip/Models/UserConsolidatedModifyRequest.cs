using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserConsolidatedModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
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
    private bool _deleteExistingDevices;

    [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false, Namespace = "")]
    public bool DeleteExistingDevices {
        get => _deleteExistingDevices;
        set {
            DeleteExistingDevicesSpecified = true;
            _deleteExistingDevices = value;
        }
    }

    [XmlIgnore]
    public bool DeleteExistingDevicesSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

    [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers {
        get => _unassignPhoneNumbers;
        set {
            UnassignPhoneNumbersSpecified = true;
            _unassignPhoneNumbers = value;
        }
    }

    [XmlIgnore]
    public bool UnassignPhoneNumbersSpecified { get; set; }
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
    private string _newUserId;

    [XmlElement(ElementName = "newUserId", IsNullable = false, Namespace = "")]
    public string NewUserId {
        get => _newUserId;
        set {
            NewUserIdSpecified = true;
            _newUserId = value;
        }
    }

    [XmlIgnore]
    public bool NewUserIdSpecified { get; set; }
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

    [XmlElement(ElementName = "nameDialingName", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementAlternateUserIdEntryList _alternateUserIdList;

    [XmlElement(ElementName = "alternateUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementAlternateUserIdEntryList AlternateUserIdList {
        get => _alternateUserIdList;
        set {
            AlternateUserIdListSpecified = true;
            _alternateUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool AlternateUserIdListSpecified { get; set; }
    private string _extension;

    [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
    public string CallingLineIdPhoneNumber {
        get => _callingLineIdPhoneNumber;
        set {
            CallingLineIdPhoneNumberSpecified = true;
            _callingLineIdPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdPhoneNumberSpecified { get; set; }
    private string _oldPassword;

    [XmlElement(ElementName = "oldPassword", IsNullable = false, Namespace = "")]
    public string OldPassword {
        get => _oldPassword;
        set {
            OldPasswordSpecified = true;
            _oldPassword = value;
        }
    }

    [XmlIgnore]
    public bool OldPasswordSpecified { get; set; }
    private string _newPassword;

    [XmlElement(ElementName = "newPassword", IsNullable = true, Namespace = "")]
    public string NewPassword {
        get => _newPassword;
        set {
            NewPasswordSpecified = true;
            _newPassword = value;
        }
    }

    [XmlIgnore]
    public bool NewPasswordSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.DepartmentKey _department;

    [XmlElement(ElementName = "department", IsNullable = true, Namespace = "")]
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
    private BroadworksConnector.Ocip.Models.ReplacementSIPAliasList _sipAliasList;

    [XmlElement(ElementName = "sipAliasList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementSIPAliasList SipAliasList {
        get => _sipAliasList;
        set {
            SipAliasListSpecified = true;
            _sipAliasList = value;
        }
    }

    [XmlIgnore]
    public bool SipAliasListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UserConsolidatedModifyRequestEndpoint _endpoint;

    [XmlElement(ElementName = "endpoint", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserConsolidatedModifyRequestEndpoint Endpoint {
        get => _endpoint;
        set {
            EndpointSpecified = true;
            _endpoint = value;
        }
    }

    [XmlIgnore]
    public bool EndpointSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList _sharedCallAppearanceAccessDeviceEndpointList;

    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpointList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList SharedCallAppearanceAccessDeviceEndpointList {
        get => _sharedCallAppearanceAccessDeviceEndpointList;
        set {
            SharedCallAppearanceAccessDeviceEndpointListSpecified = true;
            _sharedCallAppearanceAccessDeviceEndpointList = value;
        }
    }

    [XmlIgnore]
    public bool SharedCallAppearanceAccessDeviceEndpointListSpecified { get; set; }
    private string _title;

    [XmlElement(ElementName = "title", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "emailAddress", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "yahooId", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "addressLocation", IsNullable = true, Namespace = "")]
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
    private BroadworksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList _userServiceList;

    [XmlElement(ElementName = "userServiceList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList UserServiceList {
        get => _userServiceList;
        set {
            UserServiceListSpecified = true;
            _userServiceList = value;
        }
    }

    [XmlIgnore]
    public bool UserServiceListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementConsolidatedServicePackAssignmentList _servicePackList;

    [XmlElement(ElementName = "servicePackList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementConsolidatedServicePackAssignmentList ServicePackList {
        get => _servicePackList;
        set {
            ServicePackListSpecified = true;
            _servicePackList = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackListSpecified { get; set; }
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
    private string _sipAuthenticationUserName;

    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
    public string SipAuthenticationUserName {
        get => _sipAuthenticationUserName;
        set {
            SipAuthenticationUserNameSpecified = true;
            _sipAuthenticationUserName = value;
        }
    }

    [XmlIgnore]
    public bool SipAuthenticationUserNameSpecified { get; set; }
    private string _newSipAuthenticationPassword;

    [XmlElement(ElementName = "newSipAuthenticationPassword", IsNullable = false, Namespace = "")]
    public string NewSipAuthenticationPassword {
        get => _newSipAuthenticationPassword;
        set {
            NewSipAuthenticationPasswordSpecified = true;
            _newSipAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool NewSipAuthenticationPasswordSpecified { get; set; }
    private string _oldSipAuthenticationPassword;

    [XmlElement(ElementName = "OldSipAuthenticationPassword", IsNullable = false, Namespace = "")]
    public string OldSipAuthenticationPassword {
        get => _oldSipAuthenticationPassword;
        set {
            OldSipAuthenticationPasswordSpecified = true;
            _oldSipAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool OldSipAuthenticationPasswordSpecified { get; set; }
    private string _newPasscode;

    [XmlElement(ElementName = "newPasscode", IsNullable = false, Namespace = "")]
    public string NewPasscode {
        get => _newPasscode;
        set {
            NewPasscodeSpecified = true;
            _newPasscode = value;
        }
    }

    [XmlIgnore]
    public bool NewPasscodeSpecified { get; set; }
    private string _oldPasscode;

    [XmlElement(ElementName = "oldPasscode", IsNullable = false, Namespace = "")]
    public string OldPasscode {
        get => _oldPasscode;
        set {
            OldPasscodeSpecified = true;
            _oldPasscode = value;
        }
    }

    [XmlIgnore]
    public bool OldPasscodeSpecified { get; set; }
    private string _impPassword;

    [XmlElement(ElementName = "impPassword", IsNullable = true, Namespace = "")]
    public string ImpPassword {
        get => _impPassword;
        set {
            ImpPasswordSpecified = true;
            _impPassword = value;
        }
    }

    [XmlIgnore]
    public bool ImpPasswordSpecified { get; set; }
}
}
