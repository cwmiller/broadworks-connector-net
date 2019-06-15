using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Network Server in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// becomePreferred
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// order
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkSynchingServerModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        public string NetAddress {
            get => _netAddress;
            set {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }
        
        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        public int Port {
            get => _port;
            set {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private bool _becomePreferred;

        [XmlElement(ElementName = "becomePreferred", IsNullable = false, Namespace = "")]
        public bool BecomePreferred {
            get => _becomePreferred;
            set {
                BecomePreferredSpecified = true;
                _becomePreferred = value;
            }
        }

        [XmlIgnore]
        public bool BecomePreferredSpecified { get; set; }
        
        private int _order;

        [XmlElement(ElementName = "order", IsNullable = false, Namespace = "")]
        public int Order {
            get => _order;
            set {
                OrderSpecified = true;
                _order = value;
            }
        }

        [XmlIgnore]
        public bool OrderSpecified { get; set; }
        
        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        public bool Secure {
            get => _secure;
            set {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        public bool SecureSpecified { get; set; }
        
    }
}
