using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a sip device type.
    /// See Also: SystemDeviceTypeGetRequest
    /// The response is either SystemSIPDeviceTypeGetResponse14sp3 or ErrorResponse.
    /// Replaced by: SystemSIPDeviceTypeGetRequest14sp6
        /// <see cref="SystemDeviceTypeGetRequest"/>
        /// <see cref="SystemSIPDeviceTypeGetResponse14sp3"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSIPDeviceTypeGetRequest14sp6"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeGetRequest14sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public string DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
    }
}
