using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configuration of a specified service provider access device.
    /// The response is either ServiceProviderAccessDeviceGetResponse22V3 or ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// deviceExternalId
    /// 
    /// Replaced by: ServiceProviderAccessDeviceGetRequest24
    /// <see cref="ServiceProviderAccessDeviceGetResponse22V3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderAccessDeviceGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:5314"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:5315""}]}]")]
    public class ServiceProviderAccessDeviceGetRequest22V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderAccessDeviceGetResponse22V3>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5315")]
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

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5315")]
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

        protected string _deviceExternalId;

        [XmlElement(ElementName = "deviceExternalId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5314")]
        [MaxLength(36)]
        public string DeviceExternalId
        {
            get => _deviceExternalId;
            set
            {
                DeviceExternalIdSpecified = true;
                _deviceExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceExternalIdSpecified { get; set; }

    }
}
