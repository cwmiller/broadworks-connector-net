using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAdminGetRequest22.
    /// The response contains the system or provisioning administrators profile information.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode.
    /// accountDisabled
    /// lastAuthenticatedDate
    /// <see cref="SystemAdminGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2201""}]")]
    public class SystemAdminGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2201")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2201")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2201")]
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

        protected BroadWorksConnector.Ocip.Models.SystemAdminType _adminType;

        [XmlElement(ElementName = "adminType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2201")]
        public BroadWorksConnector.Ocip.Models.SystemAdminType AdminType
        {
            get => _adminType;
            set
            {
                AdminTypeSpecified = true;
                _adminType = value;
            }
        }

        [XmlIgnore]
        protected bool AdminTypeSpecified { get; set; }

        protected bool _readOnly;

        [XmlElement(ElementName = "readOnly", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2201")]
        public bool ReadOnly
        {
            get => _readOnly;
            set
            {
                ReadOnlySpecified = true;
                _readOnly = value;
            }
        }

        [XmlIgnore]
        protected bool ReadOnlySpecified { get; set; }

        protected bool _accountDisabled;

        [XmlElement(ElementName = "accountDisabled", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2201")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:2201")]
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

    }
}
