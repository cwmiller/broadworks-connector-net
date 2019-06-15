using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Application Controllers assigned to the Route Point External Systems specified.
    /// The response is either SystemRoutePointExternalSystemApplicationControllerGetResponse or ErrorResponse.
        /// <see cref="SystemRoutePointExternalSystemApplicationControllerGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutePointExternalSystemApplicationControllerGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _externalSystem;

        [XmlElement(ElementName = "externalSystem", IsNullable = false, Namespace = "")]
        public string ExternalSystem {
            get => _externalSystem;
            set {
                ExternalSystemSpecified = true;
                _externalSystem = value;
            }
        }

        [XmlIgnore]
        public bool ExternalSystemSpecified { get; set; }
        
    }
}
