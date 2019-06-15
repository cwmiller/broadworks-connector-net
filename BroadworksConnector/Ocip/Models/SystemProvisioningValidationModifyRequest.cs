using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system's provisioning validation attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// denyMobilityNumberAsRedirectionDestination
    /// denyEnterpriseNumberAsNetworkLocationDestination
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemProvisioningValidationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
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
        
        private bool _isNetworkServerQueryActive;

        [XmlElement(ElementName = "isNetworkServerQueryActive", IsNullable = false, Namespace = "")]
        public bool IsNetworkServerQueryActive {
            get => _isNetworkServerQueryActive;
            set {
                IsNetworkServerQueryActiveSpecified = true;
                _isNetworkServerQueryActive = value;
            }
        }

        [XmlIgnore]
        public bool IsNetworkServerQueryActiveSpecified { get; set; }
        
        private int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        public int TimeoutSeconds {
            get => _timeoutSeconds;
            set {
                TimeoutSecondsSpecified = true;
                _timeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeoutSecondsSpecified { get; set; }
        
        private bool _denyMobilityNumberAsRedirectionDestination;

        [XmlElement(ElementName = "denyMobilityNumberAsRedirectionDestination", IsNullable = false, Namespace = "")]
        public bool DenyMobilityNumberAsRedirectionDestination {
            get => _denyMobilityNumberAsRedirectionDestination;
            set {
                DenyMobilityNumberAsRedirectionDestinationSpecified = true;
                _denyMobilityNumberAsRedirectionDestination = value;
            }
        }

        [XmlIgnore]
        public bool DenyMobilityNumberAsRedirectionDestinationSpecified { get; set; }
        
        private bool _denyEnterpriseNumberAsNetworkLocationDestination;

        [XmlElement(ElementName = "denyEnterpriseNumberAsNetworkLocationDestination", IsNullable = false, Namespace = "")]
        public bool DenyEnterpriseNumberAsNetworkLocationDestination {
            get => _denyEnterpriseNumberAsNetworkLocationDestination;
            set {
                DenyEnterpriseNumberAsNetworkLocationDestinationSpecified = true;
                _denyEnterpriseNumberAsNetworkLocationDestination = value;
            }
        }

        [XmlIgnore]
        public bool DenyEnterpriseNumberAsNetworkLocationDestinationSpecified { get; set; }
        
    }
}
