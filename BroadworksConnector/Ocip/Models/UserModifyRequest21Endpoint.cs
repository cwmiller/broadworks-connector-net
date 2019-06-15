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
     
    public class UserModifyRequest21Endpoint 
    {

        
        private BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify AccessDeviceEndpoint {
            get => _accessDeviceEndpoint;
            set {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceEndpointSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactModify _trunkAddressing;

        [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactModify TrunkAddressing {
            get => _trunkAddressing;
            set {
                TrunkAddressingSpecified = true;
                _trunkAddressing = value;
            }
        }

        [XmlIgnore]
        public bool TrunkAddressingSpecified { get; set; }
        
    }
}
