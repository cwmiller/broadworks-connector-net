using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify system Domain parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// useAliasForDomain
    /// 
    /// The following elements are only used in AS and XS data mode and ignored in Amplify data mode:
    /// defaultDomain
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDomainParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
