using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderGetDefaultRequest. All values are default values for
    /// a service provider or enterprise's profile.
    /// 
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode.
    /// defaultDomain
        /// <see cref="ServiceProviderGetDefaultRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderGetDefaultResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isEnterprise;

        [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
        public bool IsEnterprise {
            get => _isEnterprise;
            set {
                IsEnterpriseSpecified = true;
                _isEnterprise = value;
            }
        }

        [XmlIgnore]
        public bool IsEnterpriseSpecified { get; set; }
        
        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        public string DefaultDomain {
            get => _defaultDomain;
            set {
                DefaultDomainSpecified = true;
                _defaultDomain = value;
            }
        }

        [XmlIgnore]
        public bool DefaultDomainSpecified { get; set; }
        
    }
}
