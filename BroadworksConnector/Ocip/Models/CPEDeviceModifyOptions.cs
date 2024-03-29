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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:48708""}]")]
    public class CPEDeviceModifyOptions
    {

        protected bool _enableMonitoring;

        [XmlElement(ElementName = "enableMonitoring", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48708")]
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

        protected BroadWorksConnector.Ocip.Models.CPEDeviceResetEventType? _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48708")]
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
        protected bool ResetEventSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions _deviceManagementDeviceTypeOptions;

        [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48708")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions DeviceManagementDeviceTypeOptions
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
