using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a SMDI Server route from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMDIMessageDeskDeleteServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _routeDestination;

        [XmlElement(ElementName = "routeDestination", IsNullable = false, Namespace = "")]
        public string RouteDestination {
            get => _routeDestination;
            set {
                RouteDestinationSpecified = true;
                _routeDestination = value;
            }
        }

        [XmlIgnore]
        public bool RouteDestinationSpecified { get; set; }
        
    }
}
