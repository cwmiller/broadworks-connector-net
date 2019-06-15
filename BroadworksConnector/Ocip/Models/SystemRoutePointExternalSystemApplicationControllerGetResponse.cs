using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRoutePointExternalSystemApplicationControllerGetRequest.
        /// <see cref="SystemRoutePointExternalSystemApplicationControllerGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutePointExternalSystemApplicationControllerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _applicationController;

        [XmlElement(ElementName = "applicationController", IsNullable = false, Namespace = "")]
        public List<string> ApplicationController {
            get => _applicationController;
            set {
                ApplicationControllerSpecified = true;
                _applicationController = value;
            }
        }

        [XmlIgnore]
        public bool ApplicationControllerSpecified { get; set; }
        
    }
}
