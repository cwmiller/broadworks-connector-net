using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to set the level of integration that a device type has in relation to BroadWorks services.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeServiceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public string DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
        private bool _supportsPolycomPhoneServices;

        [XmlElement(ElementName = "supportsPolycomPhoneServices", IsNullable = false, Namespace = "")]
        public bool SupportsPolycomPhoneServices {
            get => _supportsPolycomPhoneServices;
            set {
                SupportsPolycomPhoneServicesSpecified = true;
                _supportsPolycomPhoneServices = value;
            }
        }

        [XmlIgnore]
        public bool SupportsPolycomPhoneServicesSpecified { get; set; }
        
    }
}
