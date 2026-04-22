using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Profile Information for a flexible seating host
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4765""}]")]
    public class ServiceInstanceModifyProfileFlexibleSeatingHost
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = (value != null);
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected string _callingLineIdLastName;

        [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdLastName
        {
            get => _callingLineIdLastName;
            set
            {
                CallingLineIdLastNameSpecified = (value != null);
                _callingLineIdLastName = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdLastNameSpecified { get; set; }

        protected string _callingLineIdFirstName;

        [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(30)]
        public string CallingLineIdFirstName
        {
            get => _callingLineIdFirstName;
            set
            {
                CallingLineIdFirstNameSpecified = (value != null);
                _callingLineIdFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdFirstNameSpecified { get; set; }

        protected string _hiraganaLastName;

        [XmlElement(ElementName = "hiraganaLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HiraganaLastName
        {
            get => _hiraganaLastName;
            set
            {
                HiraganaLastNameSpecified = (value != null);
                _hiraganaLastName = value;
            }
        }

        [XmlIgnore]
        protected bool HiraganaLastNameSpecified { get; set; }

        protected string _hiraganaFirstName;

        [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(30)]
        public string HiraganaFirstName
        {
            get => _hiraganaFirstName;
            set
            {
                HiraganaFirstNameSpecified = (value != null);
                _hiraganaFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool HiraganaFirstNameSpecified { get; set; }

        protected string _phoneNumber;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
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

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
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

        protected string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(60)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = (value != null);
                _password = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "department", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Language
        {
            get => _language;
            set
            {
                LanguageSpecified = (value != null);
                _language = value;
            }
        }

        [XmlIgnore]
        protected bool LanguageSpecified { get; set; }

        protected string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
        [MinLength(1)]
        [MaxLength(127)]
        public string TimeZone
        {
            get => _timeZone;
            set
            {
                TimeZoneSpecified = (value != null);
                _timeZone = value;
            }
        }

        [XmlIgnore]
        protected bool TimeZoneSpecified { get; set; }

        protected string _callingLineIdPhoneNumber;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4765")]
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

    }
}
