using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider's service authorization information for a specific service or service pack.
    /// The response is either ServiceProviderServiceGetAuthorizationResponse or ErrorResponse.
        /// <see cref="ServiceProviderServiceGetAuthorizationResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServiceGetAuthorizationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.UserService _userServiceName;

        [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserService UserServiceName {
            get => _userServiceName;
            set {
                UserServiceNameSpecified = true;
                _userServiceName = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupService _groupServiceName;

        [XmlElement(ElementName = "groupServiceName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupService GroupServiceName {
            get => _groupServiceName;
            set {
                GroupServiceNameSpecified = true;
                _groupServiceName = value;
            }
        }

        [XmlIgnore]
        public bool GroupServiceNameSpecified { get; set; }
        
        private string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        public string ServicePackName {
            get => _servicePackName;
            set {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }
        
    }
}
