using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the number of access device of a particular device type and service provider.
    /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
    /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
    /// An error is returned if deviceType is specified but does not support device management.
    /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
    /// The response is either ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse or ErrorResponse.
    /// <see cref="ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2971""}]")]
    public class ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2971")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2971")]
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

        private bool _countOnlyResetSupportedDevice;

        [XmlElement(ElementName = "countOnlyResetSupportedDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2971")]
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

        private bool _allowUnmanagedDeviceType;

        [XmlElement(ElementName = "allowUnmanagedDeviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2971")]
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
