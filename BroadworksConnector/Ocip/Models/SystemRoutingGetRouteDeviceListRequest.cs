using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of devices for a route.
    /// The response is either a SystemRoutingGetRouteDeviceListResponse or an ErrorResponse.
        /// <see cref="SystemRoutingGetRouteDeviceListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRoutingGetRouteDeviceListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
