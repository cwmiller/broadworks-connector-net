using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderAdminGetRequest14.
    /// The response contains the service provider administrators profile information.
    /// Replaced by ServiceProviderAdminGetResponse21sp1.
        /// <see cref="ServiceProviderAdminGetRequest14"/>
        /// <see cref="ServiceProviderAdminGetResponse21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAdminGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminType _administratorType;

        [XmlElement(ElementName = "administratorType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminType AdministratorType {
            get => _administratorType;
            set {
                AdministratorTypeSpecified = true;
                _administratorType = value;
            }
        }

        [XmlIgnore]
        public bool AdministratorTypeSpecified { get; set; }
        
    }
}
