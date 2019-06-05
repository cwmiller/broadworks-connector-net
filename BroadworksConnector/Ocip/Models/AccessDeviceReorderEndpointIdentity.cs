using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AccessDeviceReorderEndpointIdentity
    {
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
        private string _privateIdentity;

        [XmlElement(ElementName = "privateIdentity", IsNullable = false, Namespace = "")]
        public string PrivateIdentity
        {
            get => _privateIdentity;
            set
            {
                PrivateIdentitySpecified = true;
                _privateIdentity = value;
            }
        }

        [XmlIgnore]
        public bool PrivateIdentitySpecified { get; set; }
    }
}
