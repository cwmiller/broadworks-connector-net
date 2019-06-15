using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the service provider level data associated with External Custom Ringback.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderExternalCustomRingbackModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _prefixDigits;

        [XmlElement(ElementName = "prefixDigits", IsNullable = true, Namespace = "")]
        public string PrefixDigits {
            get => _prefixDigits;
            set {
                PrefixDigitsSpecified = true;
                _prefixDigits = value;
            }
        }

        [XmlIgnore]
        public bool PrefixDigitsSpecified { get; set; }
        
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
        
        private int _timeoutSeconds;

        [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
        public int TimeoutSeconds {
            get => _timeoutSeconds;
            set {
                TimeoutSecondsSpecified = true;
                _timeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeoutSecondsSpecified { get; set; }
        
    }
}
