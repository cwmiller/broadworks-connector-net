using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a user.
    /// When oldPassword is specified, all password rule applies. If oldPassword in not specified,
    /// any password rule related to old password does not apply.
    /// The request will fail if officeZoneName or primaryZoneName is present but the Location-Based Calling Restrictions service is not assigned to the user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following data elements are only used in AS data mode:
    /// contact[2]-contact[5]
    /// nameDialingName
    /// alternateUserIdList
    /// The following elements are only used in AS data mode and will fail in XS data mode:
    /// trunkAddressing
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// allowVideo
    /// 
    /// The allowVideo element can only be used by a system administrator.
    /// The impId and impPassword are accepted when the Third-Party IMP service is assigned to the user;
    /// when Integrated IMP service is assigned to the user and active, only the impPassword is accepted;
    /// all other cases, the request fails if either field is changed.
    /// 
    /// Replaced by : UserAddRequest22 in AS mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserAddRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7646""}]")]
    public class UserModifyRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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

        private string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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

        private BroadWorksConnector.Ocip.Models.UserModifyRequest21Endpoint _endpoint;

        [XmlElement(ElementName = "endpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
        public BroadWorksConnector.Ocip.Models.UserModifyRequest21Endpoint Endpoint
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

        private string _title;

        [XmlElement(ElementName = "title", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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

        private string _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        public bool OfficeZoneNameSpecified { get; set; }

        private string _primaryZoneName;

        [XmlElement(ElementName = "primaryZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        public bool PrimaryZoneNameSpecified { get; set; }

        private string _impId;

        [XmlElement(ElementName = "impId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        public bool ImpIdSpecified { get; set; }

        private string _impPassword;

        [XmlElement(ElementName = "impPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementAlternateUserIdEntryList _alternateUserIdList;

        [XmlElement(ElementName = "alternateUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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

        private bool _allowVideo;

        [XmlElement(ElementName = "allowVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7646")]
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
        public bool AllowVideoSpecified { get; set; }

    }
}
