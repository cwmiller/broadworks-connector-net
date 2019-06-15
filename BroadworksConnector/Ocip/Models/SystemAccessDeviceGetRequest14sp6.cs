using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configuration of a specified system access device.
    /// The response is either SystemAccessDeviceGetResponse14sp6 or ErrorResponse.
    /// Replaced by: SystemAccessDeviceGetRequest16
        /// <see cref="SystemAccessDeviceGetResponse14sp6"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAccessDeviceGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceGetRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
