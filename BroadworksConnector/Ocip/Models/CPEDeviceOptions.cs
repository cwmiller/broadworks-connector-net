using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CPE device's options.
    /// Replaced by: CPEDeviceOptions14sp6
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:47869""}]")]
    public class CPEDeviceOptions
    {

        protected bool _enableMonitoring;

        [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47869")]
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

        protected BroadWorksConnector.Ocip.Models.CPEDeviceResetEventType _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47869")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configType;

        [XmlElement(ElementName = "configType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47869")]
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

        protected string _systemFileName;

        [XmlElement(ElementName = "systemFileName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47869")]
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

        protected string _deviceFileFormat;

        [XmlElement(ElementName = "deviceFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:47869")]
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

    }
}
