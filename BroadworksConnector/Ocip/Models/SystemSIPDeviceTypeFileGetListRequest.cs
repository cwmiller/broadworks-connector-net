using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of device files managed by the Device Management System, on a per-device type
    /// basis.
    /// The response is either SystemSIPDeviceTypeFileGetListResponse or ErrorResponse.
    /// Replaced By: SystemSIPDeviceTypeFileGetListRequest14sp8
        /// <see cref="SystemSIPDeviceTypeFileGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSIPDeviceTypeFileGetListRequest14sp8"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeFileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
