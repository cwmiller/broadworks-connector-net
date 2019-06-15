using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemAdminGetRequest.
    /// The response contains the system or provisioning administrators profile information.
        /// <see cref="SystemAdminGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAdminGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private BroadWorksConnector.Ocip.Models.SystemAdminType _adminType;

        [XmlElement(ElementName = "adminType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemAdminType AdminType {
            get => _adminType;
            set {
                AdminTypeSpecified = true;
                _adminType = value;
            }
        }

        [XmlIgnore]
        public bool AdminTypeSpecified { get; set; }
        
        private bool _readOnly;

        [XmlElement(ElementName = "readOnly", IsNullable = false, Namespace = "")]
        public bool ReadOnly {
            get => _readOnly;
            set {
                ReadOnlySpecified = true;
                _readOnly = value;
            }
        }

        [XmlIgnore]
        public bool ReadOnlySpecified { get; set; }
        
    }
}
