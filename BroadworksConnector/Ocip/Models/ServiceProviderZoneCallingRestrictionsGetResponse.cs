using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderZoneCallingRestrictionsGetRequest
        /// <see cref="ServiceProviderZoneCallingRestrictionsGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderZoneCallingRestrictionsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
