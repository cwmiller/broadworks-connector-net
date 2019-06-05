using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AccessDeviceMultipleContactEndpointAdd22
    {
        private BroadworksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceSpecified { get; set; }
        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        public bool LinePortSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SIPContactInfo> _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SIPContactInfo> Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        public bool ContactSpecified { get; set; }
        private int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        public int PortNumber
        {
            get => _portNumber;
            set
            {
                PortNumberSpecified = true;
                _portNumber = value;
            }
        }

        [XmlIgnore]
        public bool PortNumberSpecified { get; set; }
    }
}
