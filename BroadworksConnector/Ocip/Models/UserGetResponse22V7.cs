using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetRequest22V7.
    /// It is possible that the TrunkAddressingRead element is present with nothing populated in it which means the user is a trunk user.
    /// The following data elements are only used in AS data mode and not returned in XS data mode:
    /// contact[2]-contact[5]
    /// userId
    /// nameDialingName
    /// alternateUserId
    /// resellerId
    /// serviceProviderExternalId
    /// groupExternalId
    /// userExternalId
    /// The following data elements are only used in XS data mode:
    /// alternateTrunkIdentityDomain
    /// 
    /// The following data elements are only used in AS data mode:
    /// userId
    /// resellerId
    /// The following data elements are only used in XS data mode:
    /// alternateTrunkIdentityDomain
    /// allowVideo, value "true" is returned in AS data mode.
    /// 
    /// The userId returned in this response is the user's primary userId and may not be the userId passed in the request.
    /// 
    /// The country code (countryCode) included is the user's phone number country code when the user has a phone number assigned, or the
    /// user's Group associated country code when the user does not have a phone number assigned, or the system default country code when the
    /// user's Group does not have an associated country code.
    /// 
    /// The nationalPrefix in this response is the one associated to the included countryCode.
    /// 
    /// The callingLineIdPhoneNumber is no longer being formatted for display purpose. The value is returned exactly the same as being stored.
    /// <see cref="UserGetRequest22V7"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:17992"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18013""}]}]")]
    public class UserGetResponse22V7 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "nameDialingName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _extension;

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _departmentFullPath;

        [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        public string DepartmentFullPath
        {
            get => _departmentFullPath;
            set
            {
                DepartmentFullPathSpecified = true;
                _departmentFullPath = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentFullPathSpecified { get; set; }

        protected string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _timeZoneDisplayName;

        [XmlElement(ElementName = "timeZoneDisplayName", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        [MaxLength(127)]
        public string TimeZoneDisplayName
        {
            get => _timeZoneDisplayName;
            set
            {
                TimeZoneDisplayNameSpecified = true;
                _timeZoneDisplayName = value;
            }
        }

        [XmlIgnore]
        protected bool TimeZoneDisplayNameSpecified { get; set; }

        protected string _defaultAlias;

        [XmlElement(ElementName = "defaultAlias", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DefaultAlias
        {
            get => _defaultAlias;
            set
            {
                DefaultAliasSpecified = true;
                _defaultAlias = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultAliasSpecified { get; set; }

        protected List<string> _alias = new List<string>();

        [XmlElement(ElementName = "alias", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointRead22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18013")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointRead22 AccessDeviceEndpoint
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

        protected BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactRead22 _trunkAddressing;

        [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18013")]
        public BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactRead22 TrunkAddressing
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

        protected string _title;

        [XmlElement(ElementName = "title", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "yahooId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        [XmlElement(ElementName = "addressLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        protected bool CountryCodeSpecified { get; set; }

        protected string _nationalPrefix;

        [XmlElement(ElementName = "nationalPrefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        [MaxLength(2)]
        public string NationalPrefix
        {
            get => _nationalPrefix;
            set
            {
                NationalPrefixSpecified = true;
                _nationalPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool NationalPrefixSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        [MaxLength(40)]
        public string OfficeZoneName
        {
            get => _officeZoneName;
            set
            {
                OfficeZoneNameSpecified = true;
                _officeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneNameSpecified { get; set; }

        protected string _primaryZoneName;

        [XmlElement(ElementName = "primaryZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PrimaryZoneName
        {
            get => _primaryZoneName;
            set
            {
                PrimaryZoneNameSpecified = true;
                _primaryZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool PrimaryZoneNameSpecified { get; set; }

        protected string _impId;

        [XmlElement(ElementName = "impId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        [MaxLength(196)]
        public string ImpId
        {
            get => _impId;
            set
            {
                ImpIdSpecified = true;
                _impId = value;
            }
        }

        [XmlIgnore]
        protected bool ImpIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry> _alternateUserId = new List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry>();

        [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected bool _allowVideo;

        [XmlElement(ElementName = "allowVideo", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        public bool AllowVideo
        {
            get => _allowVideo;
            set
            {
                AllowVideoSpecified = true;
                _allowVideo = value;
            }
        }

        [XmlIgnore]
        protected bool AllowVideoSpecified { get; set; }

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected string _serviceProviderExternalId;

        [XmlElement(ElementName = "serviceProviderExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
        [MaxLength(36)]
        public string ServiceProviderExternalId
        {
            get => _serviceProviderExternalId;
            set
            {
                ServiceProviderExternalIdSpecified = true;
                _serviceProviderExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderExternalIdSpecified { get; set; }

        protected string _groupExternalId;

        [XmlElement(ElementName = "groupExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

        protected string _userExternalId;

        [XmlElement(ElementName = "userExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17992")]
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

    }
}
