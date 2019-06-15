using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceTypeGetAvailableListResponseTypeInfo 
    {

        
        private BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SignalingAddressType Profile {
            get => _profile;
            set {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        public bool ProfileSpecified { get; set; }
        
        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        public bool StaticRegistrationCapable {
            get => _staticRegistrationCapable;
            set {
                StaticRegistrationCapableSpecified = true;
                _staticRegistrationCapable = value;
            }
        }

        [XmlIgnore]
        public bool StaticRegistrationCapableSpecified { get; set; }
        
        private List<string> _protocolChoice;

        [XmlElement(ElementName = "protocolChoice", IsNullable = false, Namespace = "")]
        public List<string> ProtocolChoice {
            get => _protocolChoice;
            set {
                ProtocolChoiceSpecified = true;
                _protocolChoice = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolChoiceSpecified { get; set; }
        
        private bool _isIpAddressOptional;

        [XmlElement(ElementName = "isIpAddressOptional", IsNullable = false, Namespace = "")]
        public bool IsIpAddressOptional {
            get => _isIpAddressOptional;
            set {
                IsIpAddressOptionalSpecified = true;
                _isIpAddressOptional = value;
            }
        }

        [XmlIgnore]
        public bool IsIpAddressOptionalSpecified { get; set; }
        
        private bool _useDomain;

        [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
        public bool UseDomain {
            get => _useDomain;
            set {
                UseDomainSpecified = true;
                _useDomain = value;
            }
        }

        [XmlIgnore]
        public bool UseDomainSpecified { get; set; }
        
    }
}
