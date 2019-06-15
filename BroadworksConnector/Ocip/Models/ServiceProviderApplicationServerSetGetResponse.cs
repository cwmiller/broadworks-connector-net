using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderApplicationServerSetGetRequest.
    /// The response contains the service provider or enterprise's Application Server set information.
        /// <see cref="ServiceProviderApplicationServerSetGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderApplicationServerSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _applicationServerSetName;

        [XmlElement(ElementName = "applicationServerSetName", IsNullable = false, Namespace = "")]
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
