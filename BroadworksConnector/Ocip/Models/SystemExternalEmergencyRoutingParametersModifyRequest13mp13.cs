using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Call External Emergency Routing system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemExternalEmergencyRoutingParametersModifyRequest13mp13 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceURI;

        [XmlElement(ElementName = "serviceURI", IsNullable = true, Namespace = "")]
        public string ServiceURI {
            get => _serviceURI;
            set {
                ServiceURISpecified = true;
                _serviceURI = value;
            }
        }

        [XmlIgnore]
        public bool ServiceURISpecified { get; set; }
        
        private string _defaultEmergencyNumber;

        [XmlElement(ElementName = "defaultEmergencyNumber", IsNullable = true, Namespace = "")]
        public string DefaultEmergencyNumber {
            get => _defaultEmergencyNumber;
            set {
                DefaultEmergencyNumberSpecified = true;
                _defaultEmergencyNumber = value;
            }
        }

        [XmlIgnore]
        public bool DefaultEmergencyNumberSpecified { get; set; }
        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private bool _supportsDNSSRV;

        [XmlElement(ElementName = "supportsDNSSRV", IsNullable = false, Namespace = "")]
        public bool SupportsDNSSRV {
            get => _supportsDNSSRV;
            set {
                SupportsDNSSRVSpecified = true;
                _supportsDNSSRV = value;
            }
        }

        [XmlIgnore]
        public bool SupportsDNSSRVSpecified { get; set; }
        
        private int _connectionTimeoutSeconds;

        [XmlElement(ElementName = "connectionTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int ConnectionTimeoutSeconds {
            get => _connectionTimeoutSeconds;
            set {
                ConnectionTimeoutSecondsSpecified = true;
                _connectionTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ConnectionTimeoutSecondsSpecified { get; set; }
        
    }
}
