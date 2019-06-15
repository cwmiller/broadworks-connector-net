using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CPE device's options when used with a modify request.
    /// The following options are not changeable:
    /// configType
    /// systemFileName
    /// deviceFileFormat
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CPEDeviceModifyOptions16sp1 
    {

        
        private bool _enableMonitoring;

        [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
        public bool EnableMonitoring {
            get => _enableMonitoring;
            set {
                EnableMonitoringSpecified = true;
                _enableMonitoring = value;
            }
        }

        [XmlIgnore]
        public bool EnableMonitoringSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions16 _deviceManagementDeviceTypeOptions;

        [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions16 DeviceManagementDeviceTypeOptions {
            get => _deviceManagementDeviceTypeOptions;
            set {
                DeviceManagementDeviceTypeOptionsSpecified = true;
                _deviceManagementDeviceTypeOptions = value;
            }
        }

        [XmlIgnore]
        public bool DeviceManagementDeviceTypeOptionsSpecified { get; set; }
        
    }
}
