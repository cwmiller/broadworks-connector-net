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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14060""}]")]
    public class SystemRoutePointExternalSystemGetRoutePointListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _routePointExternalSystem;

        [XmlElement(ElementName = "routePointExternalSystem", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14060")]
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
        public bool RoutePointExternalSystemSpecified { get; set; }

    }
}
