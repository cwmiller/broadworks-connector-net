using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointExternalSystemGetAssignedRoutePointListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Video", "Phone Number", "Extension", "Department".
    /// The column values for "Video" can either be "true", or "false".
    /// <see cref="GroupRoutePointExternalSystemGetAssignedRoutePointListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:6973""}]")]
    public class GroupRoutePointExternalSystemGetAssignedRoutePointListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _routePointTable;

        [XmlElement(ElementName = "routePointTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:6973")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoutePointTable
        {
            get => _routePointTable;
            set
            {
                RoutePointTableSpecified = true;
                _routePointTable = value;
            }
        }

        [XmlIgnore]
        protected bool RoutePointTableSpecified { get; set; }

    }
}
