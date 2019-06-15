using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseBroadWorksMobileManagerGetDomainListRequest.
    /// Contains the list of domains.
        /// <see cref="EnterpriseBroadWorksMobileManagerGetDomainListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseBroadWorksMobileManagerGetDomainListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _domainName;

        [XmlElement(ElementName = "domainName", IsNullable = false, Namespace = "")]
        public List<string> DomainName {
            get => _domainName;
            set {
                DomainNameSpecified = true;
                _domainName = value;
            }
        }

        [XmlIgnore]
        public bool DomainNameSpecified { get; set; }
        
    }
}
