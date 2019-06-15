using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an application controller to Route Point External System.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutePointExternalSystemApplicationControllerAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
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
