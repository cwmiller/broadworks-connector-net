using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents information about an endpoint device
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ProfileAndServiceDeviceEndpointInfo 
    {

        
        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDevice AccessDevice {
            get => _accessDevice;
            set {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceSpecified { get; set; }
        
        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        public string LinePort {
            get => _linePort;
            set {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        public bool LinePortSpecified { get; set; }
        
        private string _privateIdentity;

        [XmlElement(ElementName = "privateIdentity", IsNullable = false, Namespace = "")]
        public string PrivateIdentity {
            get => _privateIdentity;
            set {
                PrivateIdentitySpecified = true;
                _privateIdentity = value;
            }
        }

        [XmlIgnore]
        public bool PrivateIdentitySpecified { get; set; }
        
        private string _accessDeviceMacAddress;

        [XmlElement(ElementName = "accessDeviceMacAddress", IsNullable = false, Namespace = "")]
        public string AccessDeviceMacAddress {
            get => _accessDeviceMacAddress;
            set {
                AccessDeviceMacAddressSpecified = true;
                _accessDeviceMacAddress = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceMacAddressSpecified { get; set; }
        
    }
}
