using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configuration of a specified service provider access device.
    /// The response is either ServiceProviderAccessDeviceGetResponse14sp3 or ErrorResponse.
    /// Replaced By: ServiceProviderAccessDeviceGetRequest14sp6
        /// <see cref="ServiceProviderAccessDeviceGetResponse14sp3"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderAccessDeviceGetRequest14sp6"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAccessDeviceGetRequest14sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        public string DeviceName {
            get => _deviceName;
            set {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }
        
    }
}
