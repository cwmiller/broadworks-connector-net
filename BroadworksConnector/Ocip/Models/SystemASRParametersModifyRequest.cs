using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Application Server Registration system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemASRParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        public int MaxTransmissions {
            get => _maxTransmissions;
            set {
                MaxTransmissionsSpecified = true;
                _maxTransmissions = value;
            }
        }

        [XmlIgnore]
        public bool MaxTransmissionsSpecified { get; set; }
        
        private int _retransmissionDelayMilliSeconds;

        [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false, Namespace = "")]
        public int RetransmissionDelayMilliSeconds {
            get => _retransmissionDelayMilliSeconds;
            set {
                RetransmissionDelayMilliSecondsSpecified = true;
                _retransmissionDelayMilliSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RetransmissionDelayMilliSecondsSpecified { get; set; }
        
        private int _listeningPort;

        [XmlElement(ElementName = "listeningPort", IsNullable = false, Namespace = "")]
        public int ListeningPort {
            get => _listeningPort;
            set {
                ListeningPortSpecified = true;
                _listeningPort = value;
            }
        }

        [XmlIgnore]
        public bool ListeningPortSpecified { get; set; }
        
        private string _sourceAddress;

        [XmlElement(ElementName = "sourceAddress", IsNullable = true, Namespace = "")]
        public string SourceAddress {
            get => _sourceAddress;
            set {
                SourceAddressSpecified = true;
                _sourceAddress = value;
            }
        }

        [XmlIgnore]
        public bool SourceAddressSpecified { get; set; }
        
    }
}
