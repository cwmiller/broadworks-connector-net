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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1379""}]")]
    public class SearchCriteriaExactUserRouteListAssigned : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected bool _routeListAssigned;

        [XmlElement(ElementName = "routeListAssigned", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1379")]
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
