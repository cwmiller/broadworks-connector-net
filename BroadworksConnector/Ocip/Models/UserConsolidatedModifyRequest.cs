using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a user.
    /// 
    /// If deleteExistingDevices is set to true, when the devices for the main endpoint or SCA service are changed, devices with no more endpoint will be deleted if the command is executed with the correct priviledge.
    /// Group administrator or above running this command can delete any group level devices.
    /// Service provider administrator or above can delete any service provider and group devices.
    /// Provisioning administrator or above can delete any devices.
    /// An ErrorResponse will be returned if any device cannot be deleted because of insufficient privilege.
    /// 
    /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
    /// 
    /// Alternate user ids can be added by a group level administrator or above.
    /// 
    /// The password is not required if external authentication is enabled.
    /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call Appearance service is not assigned after this request, the request will fail.
    /// 
    /// The userService/servicePackwill be authorized to the group if it has not been authorized to the group and the command is excuted by a service provider administrator. The request will fail otherwise.
    /// If not present, the authorizedQuantity will be set to unlimited if allowed.
    /// 
    /// If any of the third party voice mail elements are included but the service is not assigned after this request, the request will fail.
    /// 
    /// If the sip authentication elements are included but the SPI Authentication service is not assigned after this request, the request will fail.
    /// 
    /// If the impPassword element is included but the Integrated IMP service is not assigned after this request, the request will fail.
    /// 
    /// 
    /// The following elements are ignored in XS data mode:
    /// nameDialingName
    /// alternateUserIdList
    /// passcode
    /// trunkAddressing
    /// thirdPartyVoiceMailServerSelection
    /// thirdPartyVoiceMailServerUserServer
    /// thirdPartyVoiceMailServerMailboxIdType
    /// thirdPartyVoiceMailMailboxURL
    /// sipAuthenticationData
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1395""}]")]
    public class UserConsolidatedModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private bool _deleteExistingDevices;

        [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public bool DeleteExistingDevices
        {
            get => _deleteExistingDevices;
            set
            {
                DeleteExistingDevicesSpecified = true;
                _deleteExistingDevices = value;
            }
        }

        [XmlIgnore]
        public bool DeleteExistingDevicesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

        [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers
        {
            get => _unassignPhoneNumbers;
            set
            {
                UnassignPhoneNumbersSpecified = true;
                _unassignPhoneNumbers = value;
            }
        }

        [XmlIgnore]
        public bool UnassignPhoneNumbersSpecified { get; set; }

        private bool _addPhoneNumberToGroup;

        [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public bool AddPhoneNumberToGroup
        {
            get => _addPhoneNumberToGroup;
            set
            {
                AddPhoneNumberToGroupSpecified = true;
                _addPhoneNumberToGroup = value;
            }
        }

        [XmlIgnore]
        public bool AddPhoneNumberToGroupSpecified { get; set; }

        private string _newUserId;

        [XmlElement(ElementName = "newUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(161)]
        public string NewUserId
        {
            get => _newUserId;
            set
            {
                NewUserIdSpecified = true;
                _newUserId = value;
            }
        }

        [XmlIgnore]
        public bool NewUserIdSpecified { get; set; }

        private string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string LastName
        {
            get => _lastName;
            set
            {
                LastNameSpecified = true;
                _lastName = value;
            }
        }

        [XmlIgnore]
        public bool LastNameSpecified { get; set; }

        private string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FirstName
        {
            get => _firstName;
            set
            {
                FirstNameSpecified = true;
                _firstName = value;
            }
        }

        [XmlIgnore]
        public bool FirstNameSpecified { get; set; }

        private string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdLastName
        {
            get => _callingLineIdLastName;
            set
            {
                CallingLineIdLastNameSpecified = true;
                _callingLineIdLastName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdLastNameSpecified { get; set; }

        private string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdFirstName
        {
            get => _callingLineIdFirstName;
            set
            {
                CallingLineIdFirstNameSpecified = true;
                _callingLineIdFirstName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdFirstNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.NameDialingName _nameDialingName;

        [XmlElement(ElementName = "nameDialingName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.NameDialingName NameDialingName
        {
            get => _nameDialingName;
            set
            {
                NameDialingNameSpecified = true;
                _nameDialingName = value;
            }
        }

        [XmlIgnore]
        public bool NameDialingNameSpecified { get; set; }

        private string _hiraganaLastName;

        [XmlElement(ElementName = "hiraganaLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HiraganaLastName
        {
            get => _hiraganaLastName;
            set
            {
                HiraganaLastNameSpecified = true;
                _hiraganaLastName = value;
            }
        }

        [XmlIgnore]
        public bool HiraganaLastNameSpecified { get; set; }

        private string _hiraganaFirstName;

        [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HiraganaFirstName
        {
            get => _hiraganaFirstName;
            set
            {
                HiraganaFirstNameSpecified = true;
                _hiraganaFirstName = value;
            }
        }

        [XmlIgnore]
        public bool HiraganaFirstNameSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementAlternateUserIdEntryList _alternateUserIdList;

        [XmlElement(ElementName = "alternateUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.ReplacementAlternateUserIdEntryList AlternateUserIdList
        {
            get => _alternateUserIdList;
            set
            {
                AlternateUserIdListSpecified = true;
                _alternateUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool AlternateUserIdListSpecified { get; set; }

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionSpecified { get; set; }

        private string _callingLineIdPhoneNumber;

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(23)]
        public string CallingLineIdPhoneNumber
        {
            get => _callingLineIdPhoneNumber;
            set
            {
                CallingLineIdPhoneNumberSpecified = true;
                _callingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdPhoneNumberSpecified { get; set; }

        private string _oldPassword;

        [XmlElement(ElementName = "oldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(60)]
        public string OldPassword
        {
            get => _oldPassword;
            set
            {
                OldPasswordSpecified = true;
                _oldPassword = value;
            }
        }

        [XmlIgnore]
        public bool OldPasswordSpecified { get; set; }

        private string _newPassword;

        [XmlElement(ElementName = "newPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(60)]
        public string NewPassword
        {
            get => _newPassword;
            set
            {
                NewPasswordSpecified = true;
                _newPassword = value;
            }
        }

        [XmlIgnore]
        public bool NewPasswordSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.DepartmentKey Department
        {
            get => _department;
            set
            {
                DepartmentSpecified = true;
                _department = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentSpecified { get; set; }

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Language
        {
            get => _language;
            set
            {
                LanguageSpecified = true;
                _language = value;
            }
        }

        [XmlIgnore]
        public bool LanguageSpecified { get; set; }

        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(127)]
        public string TimeZone
        {
            get => _timeZone;
            set
            {
                TimeZoneSpecified = true;
                _timeZone = value;
            }
        }

        [XmlIgnore]
        public bool TimeZoneSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementSIPAliasList _sipAliasList;

        [XmlElement(ElementName = "sipAliasList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.ReplacementSIPAliasList SipAliasList
        {
            get => _sipAliasList;
            set
            {
                SipAliasListSpecified = true;
                _sipAliasList = value;
            }
        }

        [XmlIgnore]
        public bool SipAliasListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserConsolidatedModifyRequestEndpoint _endpoint;

        [XmlElement(ElementName = "endpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.UserConsolidatedModifyRequestEndpoint Endpoint
        {
            get => _endpoint;
            set
            {
                EndpointSpecified = true;
                _endpoint = value;
            }
        }

        [XmlIgnore]
        public bool EndpointSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList _sharedCallAppearanceAccessDeviceEndpointList;

        [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpointList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList SharedCallAppearanceAccessDeviceEndpointList
        {
            get => _sharedCallAppearanceAccessDeviceEndpointList;
            set
            {
                SharedCallAppearanceAccessDeviceEndpointListSpecified = true;
                _sharedCallAppearanceAccessDeviceEndpointList = value;
            }
        }

        [XmlIgnore]
        public bool SharedCallAppearanceAccessDeviceEndpointListSpecified { get; set; }

        private string _title;

        [XmlElement(ElementName = "title", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(50)]
        public string Title
        {
            get => _title;
            set
            {
                TitleSpecified = true;
                _title = value;
            }
        }

        [XmlIgnore]
        public bool TitleSpecified { get; set; }

        private string _pagerPhoneNumber;

        [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string PagerPhoneNumber
        {
            get => _pagerPhoneNumber;
            set
            {
                PagerPhoneNumberSpecified = true;
                _pagerPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PagerPhoneNumberSpecified { get; set; }

        private string _mobilePhoneNumber;

        [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string MobilePhoneNumber
        {
            get => _mobilePhoneNumber;
            set
            {
                MobilePhoneNumberSpecified = true;
                _mobilePhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool MobilePhoneNumberSpecified { get; set; }

        private string _emailAddress;

        [XmlElement(ElementName = "emailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                EmailAddressSpecified = true;
                _emailAddress = value;
            }
        }

        [XmlIgnore]
        public bool EmailAddressSpecified { get; set; }

        private string _yahooId;

        [XmlElement(ElementName = "yahooId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(50)]
        public string YahooId
        {
            get => _yahooId;
            set
            {
                YahooIdSpecified = true;
                _yahooId = value;
            }
        }

        [XmlIgnore]
        public bool YahooIdSpecified { get; set; }

        private string _addressLocation;

        [XmlElement(ElementName = "addressLocation", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AddressLocation
        {
            get => _addressLocation;
            set
            {
                AddressLocationSpecified = true;
                _addressLocation = value;
            }
        }

        [XmlIgnore]
        public bool AddressLocationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.StreetAddress Address
        {
            get => _address;
            set
            {
                AddressSpecified = true;
                _address = value;
            }
        }

        [XmlIgnore]
        public bool AddressSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList _userServiceList;

        [XmlElement(ElementName = "userServiceList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList UserServiceList
        {
            get => _userServiceList;
            set
            {
                UserServiceListSpecified = true;
                _userServiceList = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementConsolidatedServicePackAssignmentList _servicePackList;

        [XmlElement(ElementName = "servicePackList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedServicePackAssignmentList ServicePackList
        {
            get => _servicePackList;
            set
            {
                ServicePackListSpecified = true;
                _servicePackList = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackListSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection _thirdPartyVoiceMailServerSelection;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection ThirdPartyVoiceMailServerSelection
        {
            get => _thirdPartyVoiceMailServerSelection;
            set
            {
                ThirdPartyVoiceMailServerSelectionSpecified = true;
                _thirdPartyVoiceMailServerSelection = value;
            }
        }

        [XmlIgnore]
        public bool ThirdPartyVoiceMailServerSelectionSpecified { get; set; }

        private string _thirdPartyVoiceMailServerUserServer;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerUserServer", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ThirdPartyVoiceMailServerUserServer
        {
            get => _thirdPartyVoiceMailServerUserServer;
            set
            {
                ThirdPartyVoiceMailServerUserServerSpecified = true;
                _thirdPartyVoiceMailServerUserServer = value;
            }
        }

        [XmlIgnore]
        public bool ThirdPartyVoiceMailServerUserServerSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType _thirdPartyVoiceMailServerMailboxIdType;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerMailboxIdType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        public BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType ThirdPartyVoiceMailServerMailboxIdType
        {
            get => _thirdPartyVoiceMailServerMailboxIdType;
            set
            {
                ThirdPartyVoiceMailServerMailboxIdTypeSpecified = true;
                _thirdPartyVoiceMailServerMailboxIdType = value;
            }
        }

        [XmlIgnore]
        public bool ThirdPartyVoiceMailServerMailboxIdTypeSpecified { get; set; }

        private string _thirdPartyVoiceMailMailboxURL;

        [XmlElement(ElementName = "thirdPartyVoiceMailMailboxURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ThirdPartyVoiceMailMailboxURL
        {
            get => _thirdPartyVoiceMailMailboxURL;
            set
            {
                ThirdPartyVoiceMailMailboxURLSpecified = true;
                _thirdPartyVoiceMailMailboxURL = value;
            }
        }

        [XmlIgnore]
        public bool ThirdPartyVoiceMailMailboxURLSpecified { get; set; }

        private string _sipAuthenticationUserName;

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SipAuthenticationUserName
        {
            get => _sipAuthenticationUserName;
            set
            {
                SipAuthenticationUserNameSpecified = true;
                _sipAuthenticationUserName = value;
            }
        }

        [XmlIgnore]
        public bool SipAuthenticationUserNameSpecified { get; set; }

        private string _newSipAuthenticationPassword;

        [XmlElement(ElementName = "newSipAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(60)]
        public string NewSipAuthenticationPassword
        {
            get => _newSipAuthenticationPassword;
            set
            {
                NewSipAuthenticationPasswordSpecified = true;
                _newSipAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        public bool NewSipAuthenticationPasswordSpecified { get; set; }

        private string _oldSipAuthenticationPassword;

        [XmlElement(ElementName = "OldSipAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(60)]
        public string OldSipAuthenticationPassword
        {
            get => _oldSipAuthenticationPassword;
            set
            {
                OldSipAuthenticationPasswordSpecified = true;
                _oldSipAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        public bool OldSipAuthenticationPasswordSpecified { get; set; }

        private string _newPasscode;

        [XmlElement(ElementName = "newPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewPasscode
        {
            get => _newPasscode;
            set
            {
                NewPasscodeSpecified = true;
                _newPasscode = value;
            }
        }

        [XmlIgnore]
        public bool NewPasscodeSpecified { get; set; }

        private string _oldPasscode;

        [XmlElement(ElementName = "oldPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(30)]
        public string OldPasscode
        {
            get => _oldPasscode;
            set
            {
                OldPasscodeSpecified = true;
                _oldPasscode = value;
            }
        }

        [XmlIgnore]
        public bool OldPasscodeSpecified { get; set; }

        private string _impPassword;

        [XmlElement(ElementName = "impPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1395")]
        [MinLength(1)]
        [MaxLength(60)]
        public string ImpPassword
        {
            get => _impPassword;
            set
            {
                ImpPasswordSpecified = true;
                _impPassword = value;
            }
        }

        [XmlIgnore]
        public bool ImpPasswordSpecified { get; set; }

    }
}
