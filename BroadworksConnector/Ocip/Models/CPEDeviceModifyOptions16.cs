using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CPEDeviceModifyOptions16
    {
        private bool _enableMonitoring;

        [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
        public bool EnableMonitoring
        {
            get => _enableMonitoring;
            set
            {
                EnableMonitoringSpecified = true;
                _enableMonitoring = value;
            }
        }

        [XmlIgnore]
        public bool EnableMonitoringSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CPEDeviceResetEventType? _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CPEDeviceResetEventType? ResetEvent
        {
            get => _resetEvent;
            set
            {
                ResetEventSpecified = true;
                _resetEvent = value;
            }
        }

        [XmlIgnore]
        public bool ResetEventSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions16 _deviceManagementDeviceTypeOptions;

        [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions16 DeviceManagementDeviceTypeOptions
        {
            get => _deviceManagementDeviceTypeOptions;
            set
            {
                DeviceManagementDeviceTypeOptionsSpecified = true;
                _deviceManagementDeviceTypeOptions = value;
            }
        }

        [XmlIgnore]
        public bool DeviceManagementDeviceTypeOptionsSpecified { get; set; }
    }
}
