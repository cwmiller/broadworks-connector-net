using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for users with/without Route List feature assigned.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1330""}]")]
    public class SearchCriteriaExactUserRouteListAssigned : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private bool _routeListAssigned;

        [XmlElement(ElementName = "routeListAssigned", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1330")]
        public bool RouteListAssigned
        {
            get => _routeListAssigned;
            set
            {
                RouteListAssignedSpecified = true;
                _routeListAssigned = value;
            }
        }

        [XmlIgnore]
        protected bool RouteListAssignedSpecified { get; set; }

    }
}
