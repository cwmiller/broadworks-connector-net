using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to clear device profile authentication lockouts in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceProfileAuthenticationLockoutClearRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.AccessDeviceKey> AccessDevice {
            get => _accessDevice;
            set {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceSpecified { get; set; }
        
    }
}
