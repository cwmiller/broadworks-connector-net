using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of Communication Barring Authorization codes to an enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCommunicationBarringAuthorizationCodeAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> _code;

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> Code {
            get => _code;
            set {
                CodeSpecified = true;
                _code = value;
            }
        }

        [XmlIgnore]
        public bool CodeSpecified { get; set; }
        
    }
}
