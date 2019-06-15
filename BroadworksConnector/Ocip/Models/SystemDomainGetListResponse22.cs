using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a table of all system-level domain names and all reseller level domains.
    /// The column headings are: "Domain Name" and "Reseller Id".
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode:
    /// systemDefaultDomain
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDomainGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _domainTable;

        [XmlElement(ElementName = "domainTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DomainTable {
            get => _domainTable;
            set {
                DomainTableSpecified = true;
                _domainTable = value;
            }
        }

        [XmlIgnore]
        public bool DomainTableSpecified { get; set; }
        
    }
}
