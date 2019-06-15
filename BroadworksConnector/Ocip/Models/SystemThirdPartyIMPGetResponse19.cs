using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemThirdPartyIMPGetRequest19.
    /// The response contains the system Third-Party IMP service attributes.
        /// <see cref="SystemThirdPartyIMPGetRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemThirdPartyIMPGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _serviceNetAddress;

        [XmlElement(ElementName = "serviceNetAddress", IsNullable = false, Namespace = "")]
        public string ServiceNetAddress {
            get => _serviceNetAddress;
            set {
                ServiceNetAddressSpecified = true;
                _serviceNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNetAddressSpecified { get; set; }
        
        private int _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
        public int ServicePort {
            get => _servicePort;
            set {
                ServicePortSpecified = true;
                _servicePort = value;
            }
        }

        [XmlIgnore]
        public bool ServicePortSpecified { get; set; }
        
        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = false, Namespace = "")]
        public string BoshURL {
            get => _boshURL;
            set {
                BoshURLSpecified = true;
                _boshURL = value;
            }
        }

        [XmlIgnore]
        public bool BoshURLSpecified { get; set; }
        
    }
}
