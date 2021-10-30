using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the tree device linked with the service provider level leaf device passed in the request.
    /// A tree device is a device associated with a device type that has the option
    /// supportLinks set to "Support Links from Devices". Many leaf devices can be linked to it.
    /// A leaf device is a device associated with a device type that has the option
    /// supportLinks set to "Support Link to Device". It can be linked to only one tree device.
    /// 
    /// The response is either ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse or
    /// ErrorResponse.
    /// <see cref="ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:780""}]")]
    public class ServiceProviderAccessDeviceGetLinkedTreeDeviceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:780")]
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

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:780")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceNameSpecified { get; set; }

    }
}
