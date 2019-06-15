using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: SystemSIPDeviceTypeGetReponse18.
    /// Response to SystemDeviceTypeGetRequest16sp1.
        /// <see cref="SystemDeviceTypeGetRequest16sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDeviceTypeGetResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isObsolete;

        [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
        public bool IsObsolete {
            get => _isObsolete;
            set {
                IsObsoleteSpecified = true;
                _isObsolete = value;
            }
        }

        [XmlIgnore]
        public bool IsObsoleteSpecified { get; set; }
        
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
        
        private string _webBasedConfigURL;

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = false, Namespace = "")]
        public string WebBasedConfigURL {
            get => _webBasedConfigURL;
            set {
                WebBasedConfigURLSpecified = true;
                _webBasedConfigURL = value;
            }
        }

        [XmlIgnore]
        public bool WebBasedConfigURLSpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.CPEDeviceOptionsRead16sp1 _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceOptionsRead16sp1 CpeDeviceOptions {
            get => _cpeDeviceOptions;
            set {
                CpeDeviceOptionsSpecified = true;
                _cpeDeviceOptions = value;
            }
        }

        [XmlIgnore]
        public bool CpeDeviceOptionsSpecified { get; set; }
        
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
        
        private bool _isMobilityManagerDevice;

        [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false, Namespace = "")]
        public bool IsMobilityManagerDevice {
            get => _isMobilityManagerDevice;
            set {
                IsMobilityManagerDeviceSpecified = true;
                _isMobilityManagerDevice = value;
            }
        }

        [XmlIgnore]
        public bool IsMobilityManagerDeviceSpecified { get; set; }
        
    }
}
