using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the service provider level data associated with Call Processing
    /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse17sp3 or an ErrorResponse.
    /// 
    /// Replaced by ServiceProviderCallProcessingGetPolicyResponse17sp4
        /// <see cref="ServiceProviderCallProcessingGetPolicyResponse17sp3"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderCallProcessingGetPolicyResponse17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCallProcessingGetPolicyRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
