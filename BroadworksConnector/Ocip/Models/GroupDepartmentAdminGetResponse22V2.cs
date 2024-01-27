using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDepartmentAdminGetRequest22V2.
    /// The response contains the group department administrators profile information.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode.
    /// accountDisabled
    /// lastAuthenticatedDate
    /// hasPassword
    /// <see cref="GroupDepartmentAdminGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:3566""}]")]
    public class GroupDepartmentAdminGetResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentKey _departmentKey;

        [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentKey DepartmentKey
        {
            get => _departmentKey;
            set
            {
                DepartmentKeySpecified = true;
                _departmentKey = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentKeySpecified { get; set; }

        protected string _departmentFullPath;

        [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
        [MinLength(1)]
        [MaxLength(50)]
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

        protected string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
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

        protected string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
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

        protected string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
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

        protected bool _accountDisabled;

        [XmlElement(ElementName = "accountDisabled", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
        public bool AccountDisabled
        {
            get => _accountDisabled;
            set
            {
                AccountDisabledSpecified = true;
                _accountDisabled = value;
            }
        }

        [XmlIgnore]
        protected bool AccountDisabledSpecified { get; set; }

        protected string _lastAuthenticatedDate;

        [XmlElement(ElementName = "lastAuthenticatedDate", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
        public string LastAuthenticatedDate
        {
            get => _lastAuthenticatedDate;
            set
            {
                LastAuthenticatedDateSpecified = true;
                _lastAuthenticatedDate = value;
            }
        }

        [XmlIgnore]
        protected bool LastAuthenticatedDateSpecified { get; set; }

        protected bool _hasPassword;

        [XmlElement(ElementName = "hasPassword", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3566")]
        public bool HasPassword
        {
            get => _hasPassword;
            set
            {
                HasPasswordSpecified = true;
                _hasPassword = value;
            }
        }

        [XmlIgnore]
        protected bool HasPasswordSpecified { get; set; }

    }
}
