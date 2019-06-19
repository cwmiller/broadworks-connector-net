using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group pilot user information used when adding a Trunk Group.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4460""}]")]
    public class TrunkGroupPilotUser
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        public bool PasswordSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DepartmentKey _department;

        [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
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

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        public bool LinePortSpecified { get; set; }

        private string _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4460")]
        [MinLength(1)]
        [MaxLength(1020)]
        public string Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        public bool ContactSpecified { get; set; }

    }
}
