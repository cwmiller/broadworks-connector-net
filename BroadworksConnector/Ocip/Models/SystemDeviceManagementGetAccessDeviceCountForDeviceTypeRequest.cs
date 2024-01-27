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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7913""}]")]
    public class SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7913")]
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
        protected bool DeviceTypeSpecified { get; set; }

        protected bool _countOnlyResetSupportedDevice;

        [XmlElement(ElementName = "countOnlyResetSupportedDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7913")]
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
        protected bool CountOnlyResetSupportedDeviceSpecified { get; set; }

        protected bool _allowUnmanagedDeviceType;

        [XmlElement(ElementName = "allowUnmanagedDeviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7913")]
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
        protected bool AllowUnmanagedDeviceTypeSpecified { get; set; }

    }
}
