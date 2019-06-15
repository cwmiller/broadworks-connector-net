using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configuration of a specified system access device.
    /// The response is either SystemAccessDeviceGetResponse or ErrorResponse.
    /// Replaced By: SystemAccessDeviceGetRequest14sp3
        /// <see cref="SystemAccessDeviceGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAccessDeviceGetRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
