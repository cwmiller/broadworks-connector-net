using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for users with/without Route List feature assigned.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactUserRouteListAssigned : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private bool _routeListAssigned;

        [XmlElement(ElementName = "routeListAssigned", IsNullable = false, Namespace = "")]
        public bool RouteListAssigned {
            get => _routeListAssigned;
            set {
                RouteListAssignedSpecified = true;
                _routeListAssigned = value;
            }
        }

        [XmlIgnore]
        public bool RouteListAssignedSpecified { get; set; }
        
    }
}
