using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:43824""}]")]
    public class CPEDeviceModifyOptions16
    {

        private bool _enableMonitoring;

        [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43824")]
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

        private BroadWorksConnector.Ocip.Models.CPEDeviceResetEventType? _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43824")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceResetEventType? ResetEvent
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

        private BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions16 _deviceManagementDeviceTypeOptions;

        [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43824")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions16 DeviceManagementDeviceTypeOptions
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
