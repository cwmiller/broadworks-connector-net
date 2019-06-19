using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the number of access device of a particular device type or all
    /// device types if deviceType is not specified.
    /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
    /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
    /// An error is returned if deviceType is specified but does not support device management.
    /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
    /// The response is either SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse or ErrorResponse.
    /// <see cref="SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7092""}]")]
    public class SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7092")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }

        private bool _countOnlyResetSupportedDevice;

        [XmlElement(ElementName = "countOnlyResetSupportedDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7092")]
        public bool CountOnlyResetSupportedDevice
        {
            get => _countOnlyResetSupportedDevice;
            set
            {
                CountOnlyResetSupportedDeviceSpecified = true;
                _countOnlyResetSupportedDevice = value;
            }
        }

        [XmlIgnore]
        public bool CountOnlyResetSupportedDeviceSpecified { get; set; }

        private bool _allowUnmanagedDeviceType;

        [XmlElement(ElementName = "allowUnmanagedDeviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7092")]
        public bool AllowUnmanagedDeviceType
        {
            get => _allowUnmanagedDeviceType;
            set
            {
                AllowUnmanagedDeviceTypeSpecified = true;
                _allowUnmanagedDeviceType = value;
            }
        }

        [XmlIgnore]
        public bool AllowUnmanagedDeviceTypeSpecified { get; set; }

    }
}
