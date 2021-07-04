using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CPE device's options.
    /// 
    /// The field configType is optional to allow the use of field enableMonitoring for all device types being managed or not
    /// ie. device configuration option equals to DeviceManagement, or Legacy, or Not Supported).
    /// 
    /// If the device configuration option is set to "Not Supported", the value of configType is forced set to "None" regardless
    /// of its current value.
    /// 
    /// It is not allowed to add a device type with device configuration option set to Device Management or Legacy when the configType
    /// is not set.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1896""}]")]
    public class CPEDeviceOptions22V3
    {

        private bool _enableMonitoring;

        [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1896")]
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

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configType;

        [XmlElement(ElementName = "configType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1896")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1896")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1896")]
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

        private BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeOptions22V3 _deviceManagementDeviceTypeOptions;

        [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1896")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeOptions22V3 DeviceManagementDeviceTypeOptions
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
