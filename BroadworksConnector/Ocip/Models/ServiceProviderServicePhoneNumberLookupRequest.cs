using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Lookup if the given number is defined in the specified service in the service provider.
    /// The response is ServiceProviderServicePhoneNumberLookupResponse.
        /// <see cref="ServiceProviderServicePhoneNumberLookupResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePhoneNumberLookupRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.NumberLookupServiceType _serviceType;

        [XmlElement(ElementName = "serviceType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.NumberLookupServiceType ServiceType {
            get => _serviceType;
            set {
                ServiceTypeSpecified = true;
                _serviceType = value;
            }
        }

        [XmlIgnore]
        public bool ServiceTypeSpecified { get; set; }
        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
    }
}
