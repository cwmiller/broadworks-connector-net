using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a sip device type.
    /// See Also: SystemDeviceTypeGetRequest
    /// The response is either SystemSIPDeviceTypeGetResponse14sp2 or ErrorResponse.
    /// Replaced By: SystemSIPDeviceTypeGetRequest14sp3
        /// <see cref="SystemDeviceTypeGetRequest"/>
        /// <see cref="SystemSIPDeviceTypeGetResponse14sp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSIPDeviceTypeGetRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeGetRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
