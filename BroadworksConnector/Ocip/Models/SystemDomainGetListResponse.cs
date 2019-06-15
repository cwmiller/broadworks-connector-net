using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a simple list of all system-level domain names.
    /// 
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode:
    /// systemDefaultDomain
    /// 
    /// Replaced by SystemDomainGetListResponse22 in AS data mode.
        /// <see cref="SystemDomainGetListResponse22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDomainGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _systemDefaultDomain;

        [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false, Namespace = "")]
        public string SystemDefaultDomain {
            get => _systemDefaultDomain;
            set {
                SystemDefaultDomainSpecified = true;
                _systemDefaultDomain = value;
            }
        }

        [XmlIgnore]
        public bool SystemDefaultDomainSpecified { get; set; }
        
        private List<string> _domain;

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        public List<string> Domain {
            get => _domain;
            set {
                DomainSpecified = true;
                _domain = value;
            }
        }

        [XmlIgnore]
        public bool DomainSpecified { get; set; }
        
    }
}
