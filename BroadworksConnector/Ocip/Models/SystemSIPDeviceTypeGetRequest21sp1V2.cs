using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a sip device type.
    /// See Also: SystemDeviceTypeGetRequest
    /// The response is either SystemSIPDeviceTypeGetResponse21sp1V2 or ErrorResponse.
    /// 
    /// Replaced by: SystemSIPDeviceTypeGetRequest22 in AS data mode.
        /// <see cref="SystemDeviceTypeGetRequest"/>
        /// <see cref="SystemSIPDeviceTypeGetResponse21sp1V2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSIPDeviceTypeGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeGetRequest21sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
