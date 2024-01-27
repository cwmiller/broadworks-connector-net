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
    /// If deleteExistingDevices is set to true, when the devices for the main endpoint or SCA service are changed, devices with no more endpoint will be deleted if the command is executed with the correct privilege.
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
    /// newUserExternalId
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:1468""}]")]
    public class UserConsolidatedModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool UserIdSpecified { get; set; }

        protected bool _deleteExistingDevices;

        [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool DeleteExistingDevicesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

        [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool UnassignPhoneNumbersSpecified { get; set; }

        protected bool _addPhoneNumberToGroup;

        [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool AddPhoneNumberToGroupSpecified { get; set; }

        protected string _newUserId;

        [XmlElement(ElementName = "newUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool NewUserIdSpecified { get; set; }

        protected string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool LastNameSpecified { get; set; }

        protected string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool FirstNameSpecified { get; set; }

        protected string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool CallingLineIdLastNameSpecified { get; set; }

        protected string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool CallingLineIdFirstNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NameDialingName _nameDialingName;

        [XmlElement(ElementName = "nameDialingName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool NameDialingNameSpecified { get; set; }

        protected string _hiraganaLastName;

        [XmlElement(ElementName = "hiraganaLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool HiraganaLastNameSpecified { get; set; }

        protected string _hiraganaFirstName;

        [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool HiraganaFirstNameSpecified { get; set; }

        protected string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool PhoneNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementAlternateUserIdEntryList _alternateUserIdList;

        [XmlElement(ElementName = "alternateUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool AlternateUserIdListSpecified { get; set; }

        protected string _extension;

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool ExtensionSpecified { get; set; }

        protected string _callingLineIdPhoneNumber;

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool CallingLineIdPhoneNumberSpecified { get; set; }

        protected string _oldPassword;

        [XmlElement(ElementName = "oldPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool OldPasswordSpecified { get; set; }

        protected string _newPassword;

        [XmlElement(ElementName = "newPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool NewPasswordSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool DepartmentSpecified { get; set; }

        protected string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool LanguageSpecified { get; set; }

        protected string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool TimeZoneSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementSIPAliasList _sipAliasList;

        [XmlElement(ElementName = "sipAliasList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool SipAliasListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UserConsolidatedModifyRequest22Endpoint _endpoint;

        [XmlElement(ElementName = "endpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
        public BroadWorksConnector.Ocip.Models.UserConsolidatedModifyRequest22Endpoint Endpoint
        {
            get => _endpoint;
            set
            {
                EndpointSpecified = true;
                _endpoint = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList22 _sharedCallAppearanceAccessDeviceEndpointList;

        [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpointList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
        public BroadWorksConnector.Ocip.Models.ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList22 SharedCallAppearanceAccessDeviceEndpointList
        {
            get => _sharedCallAppearanceAccessDeviceEndpointList;
            set
            {
                SharedCallAppearanceAccessDeviceEndpointListSpecified = true;
                _sharedCallAppearanceAccessDeviceEndpointList = value;
            }
        }

        [XmlIgnore]
        protected bool SharedCallAppearanceAccessDeviceEndpointListSpecified { get; set; }

        protected string _title;

        [XmlElement(ElementName = "title", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool TitleSpecified { get; set; }

        protected string _pagerPhoneNumber;

        [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool PagerPhoneNumberSpecified { get; set; }

        protected string _mobilePhoneNumber;

        [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool MobilePhoneNumberSpecified { get; set; }

        protected string _emailAddress;

        [XmlElement(ElementName = "emailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool EmailAddressSpecified { get; set; }

        protected string _yahooId;

        [XmlElement(ElementName = "yahooId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool YahooIdSpecified { get; set; }

        protected string _addressLocation;

        [XmlElement(ElementName = "addressLocation", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool AddressLocationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool AddressSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool NetworkClassOfServiceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList _userServiceList;

        [XmlElement(ElementName = "userServiceList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool UserServiceListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementConsolidatedServicePackAssignmentList _servicePackList;

        [XmlElement(ElementName = "servicePackList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool ServicePackListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection _thirdPartyVoiceMailServerSelection;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool ThirdPartyVoiceMailServerSelectionSpecified { get; set; }

        protected string _thirdPartyVoiceMailServerUserServer;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerUserServer", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool ThirdPartyVoiceMailServerUserServerSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType _thirdPartyVoiceMailServerMailboxIdType;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerMailboxIdType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool ThirdPartyVoiceMailServerMailboxIdTypeSpecified { get; set; }

        protected string _thirdPartyVoiceMailMailboxURL;

        [XmlElement(ElementName = "thirdPartyVoiceMailMailboxURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool ThirdPartyVoiceMailMailboxURLSpecified { get; set; }

        protected string _sipAuthenticationUserName;

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool SipAuthenticationUserNameSpecified { get; set; }

        protected string _newSipAuthenticationPassword;

        [XmlElement(ElementName = "newSipAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool NewSipAuthenticationPasswordSpecified { get; set; }

        protected string _oldSipAuthenticationPassword;

        [XmlElement(ElementName = "OldSipAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool OldSipAuthenticationPasswordSpecified { get; set; }

        protected string _newPasscode;

        [XmlElement(ElementName = "newPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool NewPasscodeSpecified { get; set; }

        protected string _oldPasscode;

        [XmlElement(ElementName = "oldPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool OldPasscodeSpecified { get; set; }

        protected string _impPassword;

        [XmlElement(ElementName = "impPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
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
        protected bool ImpPasswordSpecified { get; set; }

        protected string _newUserExternalId;

        [XmlElement(ElementName = "newUserExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1468")]
        [MaxLength(36)]
        public string NewUserExternalId
        {
            get => _newUserExternalId;
            set
            {
                NewUserExternalIdSpecified = true;
                _newUserExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool NewUserExternalIdSpecified { get; set; }

    }
}
