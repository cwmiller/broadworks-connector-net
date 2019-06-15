using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point used in the context of add that can have more than one contact defined.
    /// Only Static Registration capabable devices may have more than one contact defined.
    /// Port numbers are only used by devices with static line ordering.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AccessDeviceMultipleContactEndpointAdd22 
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
        
        private List<BroadWorksConnector.Ocip.Models.SIPContactInfo> _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SIPContactInfo> Contact {
            get => _contact;
            set {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        public bool ContactSpecified { get; set; }
        
        private int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        public int PortNumber {
            get => _portNumber;
            set {
                PortNumberSpecified = true;
                _portNumber = value;
            }
        }

        [XmlIgnore]
        public bool PortNumberSpecified { get; set; }
        
    }
}
