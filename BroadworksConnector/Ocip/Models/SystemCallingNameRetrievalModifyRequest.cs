using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's calling name retrieval attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallingNameRetrievalModifyRequest16sp1
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallingNameRetrievalModifyRequest16sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallingNameRetrievalModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _queryTimerMilliSeconds;

        [XmlElement(ElementName = "queryTimerMilliSeconds", IsNullable = false, Namespace = "")]
        public int QueryTimerMilliSeconds {
            get => _queryTimerMilliSeconds;
            set {
                QueryTimerMilliSecondsSpecified = true;
                _queryTimerMilliSeconds = value;
            }
        }

        [XmlIgnore]
        public bool QueryTimerMilliSecondsSpecified { get; set; }
        
        private string _serverNetAddress;

        [XmlElement(ElementName = "serverNetAddress", IsNullable = true, Namespace = "")]
        public string ServerNetAddress {
            get => _serverNetAddress;
            set {
                ServerNetAddressSpecified = true;
                _serverNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool ServerNetAddressSpecified { get; set; }
        
        private int? _serverPort;

        [XmlElement(ElementName = "serverPort", IsNullable = true, Namespace = "")]
        public int? ServerPort {
            get => _serverPort;
            set {
                ServerPortSpecified = true;
                _serverPort = value;
            }
        }

        [XmlIgnore]
        public bool ServerPortSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TransportProtocol _serverTransportProtocol;

        [XmlElement(ElementName = "serverTransportProtocol", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol ServerTransportProtocol {
            get => _serverTransportProtocol;
            set {
                ServerTransportProtocolSpecified = true;
                _serverTransportProtocol = value;
            }
        }

        [XmlIgnore]
        public bool ServerTransportProtocolSpecified { get; set; }
        
    }
}
