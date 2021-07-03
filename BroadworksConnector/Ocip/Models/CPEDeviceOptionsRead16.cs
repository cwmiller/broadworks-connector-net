using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CPE device's options.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:48004""}]")]
    public class CPEDeviceOptionsRead16
    {

        private bool _enableMonitoring;

        [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48004")]
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
        protected bool EnableMonitoringSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CPEDeviceResetEventType _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48004")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceResetEventType ResetEvent
        {
            get => _resetEvent;
            set
            {
                ResetEventSpecified = true;
                _resetEvent = value;
            }
        }

        [XmlIgnore]
        protected bool ResetEventSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configType;

        [XmlElement(ElementName = "configType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48004")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigType
        {
            get => _configType;
            set
            {
                ConfigTypeSpecified = true;
                _configType = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigTypeSpecified { get; set; }

        private string _systemFileName;

        [XmlElement(ElementName = "systemFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48004")]
        [MinLength(1)]
        [MaxLength(265)]
        public string SystemFileName
        {
            get => _systemFileName;
            set
            {
                SystemFileNameSpecified = true;
                _systemFileName = value;
            }
        }

        [XmlIgnore]
        protected bool SystemFileNameSpecified { get; set; }

        private string _deviceFileFormat;

        [XmlElement(ElementName = "deviceFileFormat", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48004")]
        [MinLength(1)]
        [MaxLength(265)]
        public string DeviceFileFormat
        {
            get => _deviceFileFormat;
            set
            {
                DeviceFileFormatSpecified = true;
                _deviceFileFormat = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceFileFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeOptionsRead16 _deviceManagementDeviceTypeOptions;

        [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48004")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeOptionsRead16 DeviceManagementDeviceTypeOptions
        {
            get => _deviceManagementDeviceTypeOptions;
            set
            {
                DeviceManagementDeviceTypeOptionsSpecified = true;
                _deviceManagementDeviceTypeOptions = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceManagementDeviceTypeOptionsSpecified { get; set; }

    }
}
