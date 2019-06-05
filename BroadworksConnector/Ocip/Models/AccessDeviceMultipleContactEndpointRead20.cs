using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AccessDeviceMultipleContactEndpointRead20
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
        private List<string> _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        public List<string> Contact
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
        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        public bool StaticRegistrationCapable
        {
            get => _staticRegistrationCapable;
            set
            {
                StaticRegistrationCapableSpecified = true;
                _staticRegistrationCapable = value;
            }
        }

        [XmlIgnore]
        public bool StaticRegistrationCapableSpecified { get; set; }
        private bool _useDomain;

        [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
        public bool UseDomain
        {
            get => _useDomain;
            set
            {
                UseDomainSpecified = true;
                _useDomain = value;
            }
        }

        [XmlIgnore]
        public bool UseDomainSpecified { get; set; }
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
        private bool _supportVisualDeviceManagement;

        [XmlElement(ElementName = "supportVisualDeviceManagement", IsNullable = false, Namespace = "")]
        public bool SupportVisualDeviceManagement
        {
            get => _supportVisualDeviceManagement;
            set
            {
                SupportVisualDeviceManagementSpecified = true;
                _supportVisualDeviceManagement = value;
            }
        }

        [XmlIgnore]
        public bool SupportVisualDeviceManagementSpecified { get; set; }
    }
}
