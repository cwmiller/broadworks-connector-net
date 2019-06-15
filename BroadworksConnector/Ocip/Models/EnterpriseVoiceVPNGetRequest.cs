using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the enterprise level data associated with Voice VPN.
    /// The response is either a EnterpriseVoiceVPNGetResponse or an ErrorResponse.
    /// Replaced By: EnterpriseVoiceVPNGetRequest14sp3
        /// <see cref="EnterpriseVoiceVPNGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="EnterpriseVoiceVPNGetRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseVoiceVPNGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
