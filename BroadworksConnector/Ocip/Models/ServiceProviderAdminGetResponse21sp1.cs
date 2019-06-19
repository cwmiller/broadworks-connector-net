using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderAdminGetRequest21sp1.
    /// The response contains the service provider administrators profile information.
    /// <see cref="ServiceProviderAdminGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:1060""}]")]
    public class ServiceProviderAdminGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1060")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _firstName;

        [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1060")]
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

        private string _lastName;

        [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1060")]
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

        private string _language;

        [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1060")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminType _administratorType;

        [XmlElement(ElementName = "administratorType", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1060")]
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
        public bool AdministratorTypeSpecified { get; set; }

        private string _locale;

        [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1060")]
        [MaxLength(5)]
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
        public bool LocaleSpecified { get; set; }

        private string _encoding;

        [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1060")]
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
        public bool EncodingSpecified { get; set; }

    }
}
