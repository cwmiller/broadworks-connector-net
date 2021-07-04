using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// In AS and Amplify  Data Mode:
    /// The group user limit will be increased by one if needed.
    /// 
    /// The group will be added if it does not exist and if the command is executed by a Service
    /// Provider level administrator or above. If the group needs to be created, the
    /// groupProperties element must be set or the request will fail.
    /// The groupProperties element will be ignored if the group already exists.
    /// 
    /// If the domain has not been assigned to the group, it will be added to group if the
    /// command is executed by a Service provider level administrator or above.
    /// If the domain has not been assigned to the service provider, it will be added to the
    /// service provider if the command is executed by a Provisioning level administrator or
    /// above. The command will fail otherwise.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set
    /// to true, it will be added to group if the command is executed by a service provider
    /// administrator or above and the number is already assigned to the service provider. The
    /// command will fail otherwise.
    /// 
    /// The password is not required if external authentication is enabled.
    /// Alternate user ids can be added by a group level administrator or above.
    /// 
    /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call
    /// Appearance is not included in the service/service pack of the request or in the
    /// "new user template", the request will fail.
    /// 
    /// The userService/servicePack will be authorized to the group if it has not been
    /// authorized to the group if the command is executed by a Service Provider level
    /// administrator or above. The command will fail otherwise.
    /// The authorizedQuantity will be set to unlimited if not present.
    /// 
    /// When thirdPartyVoiceMail elements are included and the Third Party Voice Mail Support
    /// service is not included in the service/service pack of the request or in the
    /// "new user template", the request will fail.
    /// 
    /// When sipAuthenticationData element is included and the Authentication service is not
    /// included in the service/service pack of the request or in the "new user template",
    /// the request will fail.
    /// 
    /// 
    /// In XS data mode:
    /// only the System level administrator has the authorization level to execute the command.
    /// The group will be added if it does not exist. If the group needs to be created, the
    /// groupProperties element must be set or the request will fail.
    /// The groupProperties element will be ignored if the group already exists.
    /// 
    /// If the phoneNumber has not been assigned to the group, it will be added to group and
    /// service provider if needed.
    /// 
    /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared
    /// Call Appearance is not included in the service/service pack of the request, the request
    /// will fail.
    /// 
    /// The following elements are ignored in XS data mode:
    /// addPhoneNumberToGroup
    /// nameDialingName
    /// alternateUserId
    /// passcode
    /// trunkAddressing
    /// thirdPartyVoiceMailServerSelection
    /// thirdPartyVoiceMailServerUserServer
    /// thirdPartyVoiceMailServerMailboxIdType
    /// thirdPartyVoiceMailMailboxURL
    /// sipAuthenticationData
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1337"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1338"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1339""}]},{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1366""}]}]")]
    public class UserConsolidatedAddRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1339")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1339")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _groupExternalId;

        [XmlElement(ElementName = "groupExternalId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1338")]
        [MaxLength(36)]
        public string GroupExternalId
        {
            get => _groupExternalId;
            set
            {
                GroupExternalIdSpecified = true;
                _groupExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupExternalIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ConsolidatedGroupProperties _groupProperties;

        [XmlElement(ElementName = "groupProperties", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        public BroadWorksConnector.Ocip.Models.ConsolidatedGroupProperties GroupProperties
        {
            get => _groupProperties;
            set
            {
                GroupPropertiesSpecified = true;
                _groupProperties = value;
            }
        }

        [XmlIgnore]
        protected bool GroupPropertiesSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _userExternalId;

        [XmlElement(ElementName = "userExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        [MaxLength(36)]
        public string UserExternalId
        {
            get => _userExternalId;
            set
            {
                UserExternalIdSpecified = true;
                _userExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool UserExternalIdSpecified { get; set; }

        private bool _addPhoneNumberToGroup;

        [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private BroadWorksConnector.Ocip.Models.NameDialingName _nameDialingName;

        [XmlElement(ElementName = "nameDialingName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _hiraganaLastName;

        [XmlElement(ElementName = "hiraganaLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _hiraganaFirstName;

        [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry> _alternateUserId = new List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry>();

        [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        public List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry> AlternateUserId
        {
            get => _alternateUserId;
            set
            {
                AlternateUserIdSpecified = true;
                _alternateUserId = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateUserIdSpecified { get; set; }

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _callingLineIdPhoneNumber;

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        [MinLength(1)]
        [MaxLength(60)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordSpecified { get; set; }

        private string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private List<string> _alias = new List<string>();

        [XmlElement(ElementName = "alias", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> Alias
        {
            get => _alias;
            set
            {
                AliasSpecified = true;
                _alias = value;
            }
        }

        [XmlIgnore]
        protected bool AliasSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactAdd22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1366")]
        public BroadWorksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactAdd22 AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactAdd _trunkAddressing;

        [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1366")]
        public BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactAdd TrunkAddressing
        {
            get => _trunkAddressing;
            set
            {
                TrunkAddressingSpecified = true;
                _trunkAddressing = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkAddressingSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointAdd22> _sharedCallAppearanceAccessDeviceEndpoint = new List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointAdd22>();

        [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointAdd22> SharedCallAppearanceAccessDeviceEndpoint
        {
            get => _sharedCallAppearanceAccessDeviceEndpoint;
            set
            {
                SharedCallAppearanceAccessDeviceEndpointSpecified = true;
                _sharedCallAppearanceAccessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool SharedCallAppearanceAccessDeviceEndpointSpecified { get; set; }

        private string _title;

        [XmlElement(ElementName = "title", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _pagerPhoneNumber;

        [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _mobilePhoneNumber;

        [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _emailAddress;

        [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _yahooId;

        [XmlElement(ElementName = "yahooId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _addressLocation;

        [XmlElement(ElementName = "addressLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private BroadWorksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _userService = new List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment>();

        [XmlElement(ElementName = "userService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> UserService
        {
            get => _userService;
            set
            {
                UserServiceSpecified = true;
                _userService = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment> _servicePack = new List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment>();

        [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedServicePackAssignment> ServicePack
        {
            get => _servicePack;
            set
            {
                ServicePackSpecified = true;
                _servicePack = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection _thirdPartyVoiceMailServerSelection;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _thirdPartyVoiceMailServerUserServer;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerUserServer", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private BroadWorksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType _thirdPartyVoiceMailServerMailboxIdType;

        [XmlElement(ElementName = "thirdPartyVoiceMailServerMailboxIdType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private string _thirdPartyVoiceMailMailboxURL;

        [XmlElement(ElementName = "thirdPartyVoiceMailMailboxURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
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

        private BroadWorksConnector.Ocip.Models.SIPAuthenticationUserNamePassword _sipAuthenticationData;

        [XmlElement(ElementName = "sipAuthenticationData", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1337")]
        public BroadWorksConnector.Ocip.Models.SIPAuthenticationUserNamePassword SipAuthenticationData
        {
            get => _sipAuthenticationData;
            set
            {
                SipAuthenticationDataSpecified = true;
                _sipAuthenticationData = value;
            }
        }

        [XmlIgnore]
        protected bool SipAuthenticationDataSpecified { get; set; }

    }
}
