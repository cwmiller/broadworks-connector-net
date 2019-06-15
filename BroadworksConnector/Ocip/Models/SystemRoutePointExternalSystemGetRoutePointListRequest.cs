using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Route Points that are using the specified Route Point External System.
    /// The response is either a SystemRoutePointExternalSystemGetRoutePointListResponse or an
    /// ErrorResponse.
        /// <see cref="SystemRoutePointExternalSystemGetRoutePointListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutePointExternalSystemGetRoutePointListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _routePointExternalSystem;

        [XmlElement(ElementName = "routePointExternalSystem", IsNullable = false, Namespace = "")]
        public string RoutePointExternalSystem {
            get => _routePointExternalSystem;
            set {
                RoutePointExternalSystemSpecified = true;
                _routePointExternalSystem = value;
            }
        }

        [XmlIgnore]
        public bool RoutePointExternalSystemSpecified { get; set; }
        
    }
}
