using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a route from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingDeleteRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _routeName;

        [XmlElement(ElementName = "routeName", IsNullable = false, Namespace = "")]
        public string RouteName {
            get => _routeName;
            set {
                RouteNameSpecified = true;
                _routeName = value;
            }
        }

        [XmlIgnore]
        public bool RouteNameSpecified { get; set; }
        
    }
}
