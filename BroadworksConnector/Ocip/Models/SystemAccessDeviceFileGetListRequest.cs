using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of device files managed by the Device Management System, on a per-device profile
    /// basis.
    /// The response is either SystemAccessDeviceFileGetListResponse or ErrorResponse.
    /// Replaced By: SystemAccessDeviceFileGetListRequest14sp8
        /// <see cref="SystemAccessDeviceFileGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemAccessDeviceFileGetListRequest14sp8"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccessDeviceFileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
