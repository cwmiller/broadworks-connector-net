using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Application Server set assigned to the service provider or enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderApplicationServerSetModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _applicationServerSetName;

        [XmlElement(ElementName = "applicationServerSetName", IsNullable = true, Namespace = "")]
        public string ApplicationServerSetName {
            get => _applicationServerSetName;
            set {
                ApplicationServerSetNameSpecified = true;
                _applicationServerSetName = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationServerSetNameSpecified { get; set; }
        
    }
}
