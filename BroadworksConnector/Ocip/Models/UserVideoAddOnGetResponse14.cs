using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVideoAddOnGetRequest14.
        /// <see cref="UserVideoAddOnGetRequest14"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVideoAddOnGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds _maxOriginatingCallDelaySeconds;

        [XmlElement(ElementName = "maxOriginatingCallDelaySeconds", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds MaxOriginatingCallDelaySeconds {
            get => _maxOriginatingCallDelaySeconds;
            set {
                MaxOriginatingCallDelaySecondsSpecified = true;
                _maxOriginatingCallDelaySeconds = value;
            }
        }

        [XmlIgnore]
        public bool MaxOriginatingCallDelaySecondsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint {
            get => _accessDeviceEndpoint;
            set {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceEndpointSpecified { get; set; }
        
    }
}
