using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a simple list of all group domain names.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupDomainGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _groupDefaultDomain;

        [XmlElement(ElementName = "groupDefaultDomain", IsNullable = false, Namespace = "")]
        public string GroupDefaultDomain {
            get => _groupDefaultDomain;
            set {
                GroupDefaultDomainSpecified = true;
                _groupDefaultDomain = value;
            }
        }

        [XmlIgnore]
        public bool GroupDefaultDomainSpecified { get; set; }
        
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
