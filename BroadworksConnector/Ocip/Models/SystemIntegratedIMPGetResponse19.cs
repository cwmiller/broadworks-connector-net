using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemIntegratedIMPGetRequest19.
    /// The response contains the system Integrated IMP service attributes.
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// boshURL
    /// 
    /// Replaced by: SystemIntegratedIMPGetResponse21 in AS data mode
        /// <see cref="SystemIntegratedIMPGetRequest19"/>
        /// <see cref="SystemIntegratedIMPGetResponse21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemIntegratedIMPGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
        public string ServiceDomain {
            get => _serviceDomain;
            set {
                ServiceDomainSpecified = true;
                _serviceDomain = value;
            }
        }

        [XmlIgnore]
        public bool ServiceDomainSpecified { get; set; }
        
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
        
        private bool _addServiceProviderInIMPUserId;

        [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
        public bool AddServiceProviderInIMPUserId {
            get => _addServiceProviderInIMPUserId;
            set {
                AddServiceProviderInIMPUserIdSpecified = true;
                _addServiceProviderInIMPUserId = value;
            }
        }

        [XmlIgnore]
        public bool AddServiceProviderInIMPUserIdSpecified { get; set; }
        
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
