using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15372""}]")]
    public class SystemRoutePointExternalSystemGetRoutePointListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemRoutePointExternalSystemGetRoutePointListResponse>
    {

        protected string _routePointExternalSystem;

        [XmlElement(ElementName = "routePointExternalSystem", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15372")]
        [MinLength(1)]
        [MaxLength(40)]
        public string RoutePointExternalSystem
        {
            get => _routePointExternalSystem;
            set
            {
                RoutePointExternalSystemSpecified = true;
                _routePointExternalSystem = value;
            }
        }

        [XmlIgnore]
        protected bool RoutePointExternalSystemSpecified { get; set; }

    }
}
