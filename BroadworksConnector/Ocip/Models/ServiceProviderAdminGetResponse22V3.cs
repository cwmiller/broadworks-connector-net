using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderAdminGetRequest22V3.
    /// The response contains the service provider administrators profile information.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode.
    /// accountDisabled
    /// lastAuthenticatedDate
    /// hasPassword
    /// <see cref="ServiceProviderAdminGetRequest22V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:1562""}]")]
    public class ServiceProviderAdminGetResponse22V3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
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

        protected string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
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

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminType _administratorType;

        [XmlElement(ElementName = "administratorType", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminType AdministratorType
        {
            get => _administratorType;
            set
            {
                AdministratorTypeSpecified = true;
                _administratorType = value;
            }
        }

        [XmlIgnore]
        protected bool AdministratorTypeSpecified { get; set; }

        protected string _locale;

        [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
        [MaxLength(20)]
        public string Locale
        {
            get => _locale;
            set
            {
                LocaleSpecified = true;
                _locale = value;
            }
        }

        [XmlIgnore]
        protected bool LocaleSpecified { get; set; }

        protected string _encoding;

        [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Encoding
        {
            get => _encoding;
            set
            {
                EncodingSpecified = true;
                _encoding = value;
            }
        }

        [XmlIgnore]
        protected bool EncodingSpecified { get; set; }

        protected bool _accountDisabled;

        [XmlElement(ElementName = "accountDisabled", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:1562")]
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
