using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configuration of a specified system access device.
    /// The response is either SystemAccessDeviceGetResponse16 or ErrorResponse.
    /// 
    /// Replaced by: SystemAccessDeviceGetRequest19
        /// <see cref="SystemAccessDeviceGetResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAccessDeviceGetRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        public string DeviceName {
            get => _deviceName;
            set {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }
        
    }
}
