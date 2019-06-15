using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Deactivate number prefixes in a service provider.
    /// It is not an error to deactivate an already deactivated number prefix.
    /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _numberPrefix;

        [XmlElement(ElementName = "numberPrefix", IsNullable = false, Namespace = "")]
        public List<string> NumberPrefix {
            get => _numberPrefix;
            set {
                NumberPrefixSpecified = true;
                _numberPrefix = value;
            }
        }

        [XmlIgnore]
        public bool NumberPrefixSpecified { get; set; }
        
    }
}
