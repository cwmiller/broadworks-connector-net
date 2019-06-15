using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetRequest22V2.
    /// It is possible that the TrunkAddressingRead element is present with nothing populated in it which means
    /// the user is a trunk user.
    /// The following data elements are only used in AS data mode and not returned in XS data mode:
    /// contact[2]-contact[5]
    /// nameDialingName
    /// alternateUserId
    /// resellerId
    /// The following data elements are only used in XS data mode:
    /// alternateTrunkIdentityDomain
    /// 
    /// The following data elements are only used in AS data mode:
    /// userId
    /// 
    /// The userId returned in this response is the user's primary userId and may not be the userId passed in
    /// the request.
    /// 
    /// The country code (countryCode) included is the user's phone number country code when the user has a
    /// phone number assigned, or the
    /// user's Group associated country code when the user does not have a phone number assigned, or the system
    /// default country code when the
    /// user's Group does not have an associated country code.
    /// 
    /// The nationalPrefix in this response is the one associated to the included countryCode.
    /// 
    /// The callingLineIdPhoneNumber is no longer being formatted for display purpose. The value is returned
    /// exactly the same as being stored.
    /// 
    /// Replaced by: UserGetResponse22V3 in AS data mode.
        /// <see cref="UserGetRequest22V2"/>
        /// <see cref="UserGetResponse22V3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserGetResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.NameDialingName _nameDialingName;

        [XmlElement(ElementName = "nameDialingName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.NameDialingName NameDialingName {
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
        
        private BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointRead _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointRead AccessDeviceEndpoint {
            get => _accessDeviceEndpoint;
            set {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceEndpointSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactRead21 _trunkAddressing;

        [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactRead21 TrunkAddressing {
            get => _trunkAddressing;
            set {
                TrunkAddressingSpecified = true;
                _trunkAddressing = value;
            }
        }

        [XmlIgnore]
        public bool TrunkAddressingSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.StreetAddress Address {
            get => _address;
            set {
                AddressSpecified = true;
                _address = value;
            }
        }

        [XmlIgnore]
        public bool AddressSpecified { get; set; }
        
        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        public string CountryCode {
            get => _countryCode;
            set {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }
        
        private string _nationalPrefix;

        [XmlElement(ElementName = "nationalPrefix", IsNullable = false, Namespace = "")]
        public string NationalPrefix {
            get => _nationalPrefix;
            set {
                NationalPrefixSpecified = true;
                _nationalPrefix = value;
            }
        }

        [XmlIgnore]
        public bool NationalPrefixSpecified { get; set; }
        
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
        
        private string _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        public string OfficeZoneName {
            get => _officeZoneName;
            set {
                OfficeZoneNameSpecified = true;
                _officeZoneName = value;
            }
        }

        [XmlIgnore]
        public bool OfficeZoneNameSpecified { get; set; }
        
        private string _primaryZoneName;

        [XmlElement(ElementName = "primaryZoneName", IsNullable = false, Namespace = "")]
        public string PrimaryZoneName {
            get => _primaryZoneName;
            set {
                PrimaryZoneNameSpecified = true;
                _primaryZoneName = value;
            }
        }

        [XmlIgnore]
        public bool PrimaryZoneNameSpecified { get; set; }
        
        private string _impId;

        [XmlElement(ElementName = "impId", IsNullable = false, Namespace = "")]
        public string ImpId {
            get => _impId;
            set {
                ImpIdSpecified = true;
                _impId = value;
            }
        }

        [XmlIgnore]
        public bool ImpIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry> _alternateUserId;

        [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AlternateUserIdEntry> AlternateUserId {
            get => _alternateUserId;
            set {
                AlternateUserIdSpecified = true;
                _alternateUserId = value;
            }
        }

        [XmlIgnore]
        public bool AlternateUserIdSpecified { get; set; }
        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
