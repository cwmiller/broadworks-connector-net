using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a routing Network Server to the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkRoutingServerAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.TransportProtocol _transportProtocol;

        [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol TransportProtocol {
            get => _transportProtocol;
            set {
                TransportProtocolSpecified = true;
                _transportProtocol = value;
            }
        }

        [XmlIgnore]
        public bool TransportProtocolSpecified { get; set; }
        
        private bool _poll;

        [XmlElement(ElementName = "poll", IsNullable = false, Namespace = "")]
        public bool Poll {
            get => _poll;
            set {
                PollSpecified = true;
                _poll = value;
            }
        }

        [XmlIgnore]
        public bool PollSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
    }
}
