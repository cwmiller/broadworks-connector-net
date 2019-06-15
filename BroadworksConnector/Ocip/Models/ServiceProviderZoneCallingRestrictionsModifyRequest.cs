using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Service Provider/Enterprise level Zone Calling Restrictions Policies.
    /// The response is SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderZoneCallingRestrictionsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _enableZoneCallingRestrictions;

        [XmlElement(ElementName = "enableZoneCallingRestrictions", IsNullable = false, Namespace = "")]
        public bool EnableZoneCallingRestrictions {
            get => _enableZoneCallingRestrictions;
            set {
                EnableZoneCallingRestrictionsSpecified = true;
                _enableZoneCallingRestrictions = value;
            }
        }

        [XmlIgnore]
        public bool EnableZoneCallingRestrictionsSpecified { get; set; }
        
        private bool _enableOriginationRoamingRestrictions;

        [XmlElement(ElementName = "enableOriginationRoamingRestrictions", IsNullable = false, Namespace = "")]
        public bool EnableOriginationRoamingRestrictions {
            get => _enableOriginationRoamingRestrictions;
            set {
                EnableOriginationRoamingRestrictionsSpecified = true;
                _enableOriginationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        public bool EnableOriginationRoamingRestrictionsSpecified { get; set; }
        
        private bool _enableEmergencyOriginationRoamingRestrictions;

        [XmlElement(ElementName = "enableEmergencyOriginationRoamingRestrictions", IsNullable = false, Namespace = "")]
        public bool EnableEmergencyOriginationRoamingRestrictions {
            get => _enableEmergencyOriginationRoamingRestrictions;
            set {
                EnableEmergencyOriginationRoamingRestrictionsSpecified = true;
                _enableEmergencyOriginationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        public bool EnableEmergencyOriginationRoamingRestrictionsSpecified { get; set; }
        
        private bool _enableTerminationRoamingRestrictions;

        [XmlElement(ElementName = "enableTerminationRoamingRestrictions", IsNullable = false, Namespace = "")]
        public bool EnableTerminationRoamingRestrictions {
            get => _enableTerminationRoamingRestrictions;
            set {
                EnableTerminationRoamingRestrictionsSpecified = true;
                _enableTerminationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        public bool EnableTerminationRoamingRestrictionsSpecified { get; set; }
        
    }
}
