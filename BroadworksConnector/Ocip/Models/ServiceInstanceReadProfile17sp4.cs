using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Profile Information for group service.
    /// 
    /// Replaced by: ServiceInstanceReadProfile19sp1
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3688""}]")]
    public class ServiceInstanceReadProfile17sp4
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

        private string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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

        private string _hiraganaLastName;

        [XmlElement(ElementName = "hiraganaLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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

        [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        public bool CountryCodeSpecified { get; set; }

        private string _nationalPrefix;

        [XmlElement(ElementName = "nationalPrefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        public bool NationalPrefixSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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

        private string _timeZoneDisplayName;

        [XmlElement(ElementName = "timeZoneDisplayName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        public bool TimeZoneDisplayNameSpecified { get; set; }

        private List<string> _alias = new List<string>();

        [XmlElement(ElementName = "alias", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
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
        public bool AliasSpecified { get; set; }

        private string _publicUserIdentity;

        [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3688")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PublicUserIdentity
        {
            get => _publicUserIdentity;
            set
            {
                PublicUserIdentitySpecified = true;
                _publicUserIdentity = value;
            }
        }

        [XmlIgnore]
        public bool PublicUserIdentitySpecified { get; set; }

    }
}
