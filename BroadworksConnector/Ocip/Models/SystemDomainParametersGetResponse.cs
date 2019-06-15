using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDomainParametersGetRequest.
    /// Contains the system Domain parameters.
    /// 
    /// The following elements are only used in AS data mode:
    /// useAliasForDomain, value "false" is returned in XS data mode.
    /// 
    /// The following elements are only used in AS and XS data mode and not returned in Amplify data mode.
    /// defaultDomain
        /// <see cref="SystemDomainParametersGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDomainParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _useAliasForDomain;

        [XmlElement(ElementName = "useAliasForDomain", IsNullable = false, Namespace = "")]
        public bool UseAliasForDomain {
            get => _useAliasForDomain;
            set {
                UseAliasForDomainSpecified = true;
                _useAliasForDomain = value;
            }
        }

        [XmlIgnore]
        public bool UseAliasForDomainSpecified { get; set; }
        
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
